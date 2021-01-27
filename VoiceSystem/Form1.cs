using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace VoiceSystem
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 输出目录
        /// </summary>
        private const string outputDir = "./Output/";
        /// <summary>
        /// 高亮颜色
        /// </summary>
        private static Color highlightColor = Color.Yellow;
        /// <summary>
        /// 语音生成引擎
        /// </summary>
        private SpeechSynthesizer _speechSynthesizer;
        /// <summary>
        /// 输出按钮是否处于工作状态（默认为否）
        /// </summary>
        private bool _isOutputWorking = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ResetUI();
                Init();
                if (_speechSynthesizer.GetInstalledVoices().Count == 0)
                {
                    UIHelper.ShowError("启动失败", "当前系统中未发现安装的语音，请检查！");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError("程序启动失败", "原因：" + ex.Message);
                this.Close();
            }
        }
        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            var track = (TrackBar)sender;
            _speechSynthesizer.Volume = track.Value;
        }
        private void comboBoxVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            _speechSynthesizer.SelectVoice(comboBoxVoices.SelectedItem.ToString());
        }

        private void trackBarRate_Scroll(object sender, EventArgs e)
        {
            var track = (TrackBar)sender;
            _speechSynthesizer.Rate = track.Value;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReleaseSpeechSynthesizer();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            UpdateGpTryState(false, true, true);
            UpdateOtherState(false);

            if (SynthesizerState.Ready == _speechSynthesizer.State)
            {
                gpOutput.Enabled = false;
                UpdateProgressMaxium();

                _speechSynthesizer.SpeakAsync(rtxtInput.Text);
            }
            else if (SynthesizerState.Paused == _speechSynthesizer.State)
            {
                _speechSynthesizer.Resume();
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            UpdateGpTryState(true, false, true);
            UpdateOtherState(false);

            _speechSynthesizer.Pause();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            ResetUI();
            ReleaseSpeechSynthesizer();

            Init();
        }
        private void btnOutput_Click(object sender, EventArgs e)
        {
            var fileName = txtFileName.Text;
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("文件名称为空！", "导出文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateGpOutputState(false);
            UpdateOtherState(false);
            UpdateProgressMaxium();
            try
            {
                CreateDirectoryIfNotExist();
                if (CheckIfFileNameExist(fileName))
                {
                    if (DialogResult.Yes == MessageBox.Show("已存在同名文件，是否进行覆盖！", "导出文件", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        OutputToFile(fileName);
                    }
                    else
                    {
                        UpdateGpOutputState(true);
                        UpdateOtherState(true);
                    }
                }
                else
                {
                    OutputToFile(fileName);
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError("输出动作执行失败", ex.Message);
            }
        }
        /// <summary>
        /// 导出文件
        /// </summary>
        /// <param name="fileName"></param>
        void OutputToFile(string fileName)
        {
            //输出到本地的音频文件
            _speechSynthesizer.SetOutputToWaveFile(Path.Combine(outputDir, fileName + ".wav"));
            _speechSynthesizer.SpeakAsync(rtxtInput.Text);
        }
        /// <summary>
        /// 初始化动作
        /// </summary>
        void Init()
        {
            CreateDirectoryIfNotExist();
            InitializeNewSpeechSynthesizer();
            comboBoxVoices.DataSource = GetVoiceNames();
            ManualInvokeEvent();
            tsLabelState.Text = _speechSynthesizer.State.ToString();
            listBoxFiles.DataSource = Directory.GetFiles(outputDir).Select(f => Path.GetFileNameWithoutExtension(f)).ToList();
        }
        List<string> GetVoiceNames()
        {
            var names = new List<string>();
            var voices = _speechSynthesizer.GetInstalledVoices();
            foreach (var voice in voices)
            {
                names.Add(voice.VoiceInfo.Name);
            }

            return names;
        }
        /// <summary>
        /// 初始化新的语音生成引擎
        /// </summary>
        void InitializeNewSpeechSynthesizer()
        {
            _speechSynthesizer = new SpeechSynthesizer();
            _speechSynthesizer.StateChanged += _speechSynthesizer_StateChanged;
            _speechSynthesizer.SpeakCompleted += _speechSynthesizer_SpeakCompleted;
            _speechSynthesizer.SpeakProgress += _speechSynthesizer_SpeakProgress;
        }
        /// <summary>
        /// 手动触发事件
        /// </summary>
        void ManualInvokeEvent()
        {
            trackBarVolume.Invoke(new EventHandler(trackBarVolume_Scroll));
            trackBarRate.Invoke(new EventHandler(trackBarRate_Scroll));
        }
        /// <summary>
        /// 语音输出进度展示
        /// </summary>
        private void _speechSynthesizer_SpeakProgress(object sender, SpeakProgressEventArgs e)
        {
            if (_isOutputWorking)
            {
                tsProgress.Value = e.CharacterPosition;
            }
            else
            {
                rtxtInput.Select(e.CharacterPosition, e.CharacterCount);
                rtxtInput.SelectionBackColor = highlightColor;
                tsProgress.Value = e.CharacterPosition;
            }
        }
        /// <summary>
        /// 语音输出结束事件
        /// </summary>
        private void _speechSynthesizer_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            //针对导出部分的特殊处理
            if (_isOutputWorking)
            {
                //恢复输出到音频设备
                _speechSynthesizer.SetOutputToDefaultAudioDevice();
            }
            ResetUI();
        }
        /// <summary>
        /// 语音生成引擎状态切换事件
        /// </summary>
        private void _speechSynthesizer_StateChanged(object sender, StateChangedEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                tsLabelState.Text = GetState(e.State);
            }));
        }
        string GetState(SynthesizerState state)
        {
            if (_isOutputWorking && SynthesizerState.Speaking == state)
            {
                return "导出中";
            }
            else
            {
                return state.ToString();
            }
        }
        /// <summary>
        /// 释放当前语音生成引擎
        /// </summary>
        void ReleaseSpeechSynthesizer()
        {
            try
            {
                _speechSynthesizer.SpeakAsyncCancelAll();
                _speechSynthesizer.Dispose();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _speechSynthesizer = null;
            }
        }
        /// <summary>
        /// 目录不存在自动创建
        /// </summary>
        void CreateDirectoryIfNotExist()
        {
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }
        }
        /// <summary>
        /// 检查是否已存在同名文件
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool CheckIfFileNameExist(string name)
        {
            var names = Directory.GetFiles(outputDir).Select(f => Path.GetFileNameWithoutExtension(f));
            return names.Contains(name);
        }
        /// <summary>
        /// 重置UI控件状态和默认值
        /// </summary>
        void ResetUI()
        {
            tsProgress.Value = 0;
            UpdateGpTryState(true, false, false);
            UpdateGpOutputState(true);
            UpdateOtherState(true);
            gpOutput.Enabled = true;

            //恢复内容默认前景色
            rtxtInput.SelectAll();
            rtxtInput.SelectionBackColor = SystemColors.Window;
        }
        /// <summary>
        /// 更新试用区按钮启用状态
        /// </summary>
        void UpdateGpTryState(bool start, bool pause, bool stop)
        {
            btnStart.Enabled = start;
            btnPause.Enabled = pause;
            btnStop.Enabled = stop;
        }
        /// <summary>
        /// 更新导出区按钮启用状态
        /// </summary>
        /// <param name="enable">是否启用</param>
        void UpdateGpOutputState(bool enable)
        {
            btnOutput.Enabled = enable;
            gpTry.Enabled = enable;
            txtFileName.Enabled = enable;
            _isOutputWorking = !enable;
        }
        /// <summary>
        /// 更新其他控件状态
        /// </summary>
        /// <param name="enable">是否启用</param>
        void UpdateOtherState(bool enable)
        {
            tsProgress.Visible = !enable;
            gpSetting.Enabled = enable;
            rtxtInput.Enabled = enable;
        }
        /// <summary>
        /// 更新进度条最大值
        /// </summary>
        void UpdateProgressMaxium()
        {
            tsProgress.Maximum = rtxtInput.Text.Length;
        }
    }
}
