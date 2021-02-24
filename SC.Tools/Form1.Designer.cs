namespace SC.Tools
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LowerFirstcheckBox = new System.Windows.Forms.CheckBox();
            this.Calcbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UnSignedDectextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SignedDectextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HextextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LowerFirstcheckBox);
            this.tabPage1.Controls.Add(this.Calcbutton);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.HextextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(727, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LowerFirstcheckBox
            // 
            this.LowerFirstcheckBox.AutoSize = true;
            this.LowerFirstcheckBox.Checked = true;
            this.LowerFirstcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LowerFirstcheckBox.Location = new System.Drawing.Point(49, 61);
            this.LowerFirstcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.LowerFirstcheckBox.Name = "LowerFirstcheckBox";
            this.LowerFirstcheckBox.Size = new System.Drawing.Size(72, 16);
            this.LowerFirstcheckBox.TabIndex = 9;
            this.LowerFirstcheckBox.Text = "低位在前";
            this.LowerFirstcheckBox.UseVisualStyleBackColor = true;
            // 
            // Calcbutton
            // 
            this.Calcbutton.Location = new System.Drawing.Point(355, 18);
            this.Calcbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Calcbutton.Name = "Calcbutton";
            this.Calcbutton.Size = new System.Drawing.Size(56, 29);
            this.Calcbutton.TabIndex = 8;
            this.Calcbutton.Text = "计算";
            this.Calcbutton.UseVisualStyleBackColor = true;
            this.Calcbutton.Click += new System.EventHandler(this.Calcbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnSignedDectextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SignedDectextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(411, 126);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "十进制结果";
            // 
            // UnSignedDectextBox
            // 
            this.UnSignedDectextBox.Location = new System.Drawing.Point(84, 91);
            this.UnSignedDectextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UnSignedDectextBox.Name = "UnSignedDectextBox";
            this.UnSignedDectextBox.ReadOnly = true;
            this.UnSignedDectextBox.Size = new System.Drawing.Size(194, 21);
            this.UnSignedDectextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "不带符号：";
            // 
            // SignedDectextBox
            // 
            this.SignedDectextBox.Location = new System.Drawing.Point(84, 38);
            this.SignedDectextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SignedDectextBox.Name = "SignedDectextBox";
            this.SignedDectextBox.ReadOnly = true;
            this.SignedDectextBox.Size = new System.Drawing.Size(194, 21);
            this.SignedDectextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "带符号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "十六进制数：";
            // 
            // HextextBox
            // 
            this.HextextBox.Location = new System.Drawing.Point(93, 23);
            this.HextextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HextextBox.Name = "HextextBox";
            this.HextextBox.Size = new System.Drawing.Size(194, 21);
            this.HextextBox.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(727, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xml文件自动缩进";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 580);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox LowerFirstcheckBox;
        private System.Windows.Forms.Button Calcbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox UnSignedDectextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SignedDectextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HextextBox;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

