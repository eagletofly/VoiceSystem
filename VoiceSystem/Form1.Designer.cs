
namespace VoiceSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.rtxtInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpOutput = new System.Windows.Forms.GroupBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gpTry = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gpSetting = new System.Windows.Forms.GroupBox();
            this.comboBoxVoices = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarRate = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpOutput.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpTry.SuspendLayout();
            this.gpSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsLabelState,
            this.tsProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(977, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel1.Text = "当前状态：";
            // 
            // tsLabelState
            // 
            this.tsLabelState.Name = "tsLabelState";
            this.tsLabelState.Size = new System.Drawing.Size(54, 20);
            this.tsLabelState.Text = "Ready";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 18);
            // 
            // rtxtInput
            // 
            this.rtxtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtInput.Location = new System.Drawing.Point(0, 39);
            this.rtxtInput.Name = "rtxtInput";
            this.rtxtInput.Size = new System.Drawing.Size(648, 589);
            this.rtxtInput.TabIndex = 4;
            this.rtxtInput.Text = "";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入待转换的文字内容：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gpOutput);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.gpTry);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gpSetting);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(648, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 628);
            this.panel1.TabIndex = 2;
            // 
            // gpOutput
            // 
            this.gpOutput.Controls.Add(this.listBoxFiles);
            this.gpOutput.Controls.Add(this.label8);
            this.gpOutput.Controls.Add(this.panel2);
            this.gpOutput.Controls.Add(this.label9);
            this.gpOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpOutput.Location = new System.Drawing.Point(0, 408);
            this.gpOutput.Name = "gpOutput";
            this.gpOutput.Size = new System.Drawing.Size(329, 220);
            this.gpOutput.TabIndex = 22;
            this.gpOutput.TabStop = false;
            this.gpOutput.Text = "导出";
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 15;
            this.listBoxFiles.Location = new System.Drawing.Point(3, 136);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(323, 81);
            this.listBoxFiles.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(3, 99);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label8.Size = new System.Drawing.Size(323, 37);
            this.label8.TabIndex = 11;
            this.label8.Text = "历史音频文件";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtFileName);
            this.panel2.Controls.Add(this.btnOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 48);
            this.panel2.TabIndex = 10;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(3, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(213, 25);
            this.txtFileName.TabIndex = 8;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(241, 12);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(79, 25);
            this.btnOutput.TabIndex = 9;
            this.btnOutput.Text = "输出";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(3, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(323, 30);
            this.label9.TabIndex = 7;
            this.label9.Text = "名称：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 26);
            this.label6.TabIndex = 21;
            // 
            // gpTry
            // 
            this.gpTry.Controls.Add(this.btnStop);
            this.gpTry.Controls.Add(this.btnStart);
            this.gpTry.Controls.Add(this.btnPause);
            this.gpTry.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpTry.Location = new System.Drawing.Point(0, 260);
            this.gpTry.Name = "gpTry";
            this.gpTry.Size = new System.Drawing.Size(329, 122);
            this.gpTry.TabIndex = 20;
            this.gpTry.TabStop = false;
            this.gpTry.Text = "试听";
            // 
            // btnStop
            // 
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(216, 50);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(57, 41);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Image = global::VoiceSystem.Properties.Resources.start_32px;
            this.btnStart.Location = new System.Drawing.Point(32, 50);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(57, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPause.Image = global::VoiceSystem.Properties.Resources.pause_32px;
            this.btnPause.Location = new System.Drawing.Point(127, 50);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(57, 41);
            this.btnPause.TabIndex = 2;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 24);
            this.label5.TabIndex = 18;
            // 
            // gpSetting
            // 
            this.gpSetting.Controls.Add(this.comboBoxVoices);
            this.gpSetting.Controls.Add(this.label4);
            this.gpSetting.Controls.Add(this.trackBarRate);
            this.gpSetting.Controls.Add(this.label3);
            this.gpSetting.Controls.Add(this.trackBarVolume);
            this.gpSetting.Controls.Add(this.label2);
            this.gpSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpSetting.Location = new System.Drawing.Point(0, 39);
            this.gpSetting.Name = "gpSetting";
            this.gpSetting.Size = new System.Drawing.Size(329, 197);
            this.gpSetting.TabIndex = 17;
            this.gpSetting.TabStop = false;
            this.gpSetting.Text = "参数设置";
            // 
            // comboBoxVoices
            // 
            this.comboBoxVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVoices.FormattingEnabled = true;
            this.comboBoxVoices.Location = new System.Drawing.Point(73, 148);
            this.comboBoxVoices.Name = "comboBoxVoices";
            this.comboBoxVoices.Size = new System.Drawing.Size(231, 23);
            this.comboBoxVoices.TabIndex = 5;
            this.comboBoxVoices.SelectedIndexChanged += new System.EventHandler(this.comboBoxVoices_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "声音：";
            // 
            // trackBarRate
            // 
            this.trackBarRate.Location = new System.Drawing.Point(73, 86);
            this.trackBarRate.Minimum = -10;
            this.trackBarRate.Name = "trackBarRate";
            this.trackBarRate.Size = new System.Drawing.Size(231, 56);
            this.trackBarRate.TabIndex = 3;
            this.trackBarRate.Scroll += new System.EventHandler(this.trackBarRate_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "语速：";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(73, 24);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(231, 56);
            this.trackBarVolume.TabIndex = 1;
            this.trackBarVolume.TickFrequency = 5;
            this.trackBarVolume.Value = 20;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "音量：";
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 39);
            this.label7.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 654);
            this.Controls.Add(this.rtxtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "文字语音转换工具";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gpOutput.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gpTry.ResumeLayout(false);
            this.gpSetting.ResumeLayout(false);
            this.gpSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.RichTextBox rtxtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpTry;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpSetting;
        private System.Windows.Forms.ComboBox comboBoxVoices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxFiles;
    }
}

