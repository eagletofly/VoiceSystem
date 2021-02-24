namespace ModBus.Component
{
    partial class SerialPanel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPortNumber = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbDataBit = new System.Windows.Forms.ComboBox();
            this.cmbStopBit = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.btnOpenOrClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 13;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cmbParity, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbStopBit, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbDataBit, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbBaudRate, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPortNumber, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenOrClose, 11, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(838, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(156, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(309, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 59);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据位:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(455, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 59);
            this.label4.TabIndex = 3;
            this.label4.Text = "停止位：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(608, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 59);
            this.label5.TabIndex = 4;
            this.label5.Text = "校验位：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPortNumber
            // 
            this.cmbPortNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbPortNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortNumber.FormattingEnabled = true;
            this.cmbPortNumber.Location = new System.Drawing.Point(76, 18);
            this.cmbPortNumber.Name = "cmbPortNumber";
            this.cmbPortNumber.Size = new System.Drawing.Size(69, 23);
            this.cmbPortNumber.TabIndex = 5;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(229, 18);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(69, 23);
            this.cmbBaudRate.TabIndex = 6;
            // 
            // cmbDataBit
            // 
            this.cmbDataBit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBit.FormattingEnabled = true;
            this.cmbDataBit.Location = new System.Drawing.Point(375, 18);
            this.cmbDataBit.Name = "cmbDataBit";
            this.cmbDataBit.Size = new System.Drawing.Size(69, 23);
            this.cmbDataBit.TabIndex = 7;
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBit.FormattingEnabled = true;
            this.cmbStopBit.Location = new System.Drawing.Point(528, 18);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(69, 23);
            this.cmbStopBit.TabIndex = 8;
            // 
            // cmbParity
            // 
            this.cmbParity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(681, 18);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(70, 23);
            this.cmbParity.TabIndex = 9;
            // 
            // btnOpenOrClose
            // 
            this.btnOpenOrClose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOpenOrClose.Location = new System.Drawing.Point(761, 10);
            this.btnOpenOrClose.Name = "btnOpenOrClose";
            this.btnOpenOrClose.Padding = new System.Windows.Forms.Padding(3);
            this.btnOpenOrClose.Size = new System.Drawing.Size(74, 38);
            this.btnOpenOrClose.TabIndex = 10;
            this.btnOpenOrClose.UseVisualStyleBackColor = true;
            this.btnOpenOrClose.Click += new System.EventHandler(this.btnOpenOrClose_Click);
            // 
            // SerialPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SerialPanel";
            this.Size = new System.Drawing.Size(838, 59);
            this.Load += new System.EventHandler(this.SerialPanel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbStopBit;
        private System.Windows.Forms.ComboBox cmbDataBit;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPortNumber;
        private System.Windows.Forms.Button btnOpenOrClose;
    }
}
