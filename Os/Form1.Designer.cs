namespace Os
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
            this.LRU = new System.Windows.Forms.Button();
            this.OPT = new System.Windows.Forms.Button();
            this.AllBegin = new System.Windows.Forms.Button();
            this.FIFOPanel = new System.Windows.Forms.Panel();
            this.OPTPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LRUPanel = new System.Windows.Forms.Panel();
            this.FIFO = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.acce = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LRU
            // 
            this.LRU.Location = new System.Drawing.Point(17, 151);
            this.LRU.Name = "LRU";
            this.LRU.Size = new System.Drawing.Size(99, 74);
            this.LRU.TabIndex = 3;
            this.LRU.Text = "LRU";
            this.LRU.UseVisualStyleBackColor = true;
            this.LRU.Click += new System.EventHandler(this.button2_Click);
            // 
            // OPT
            // 
            this.OPT.Location = new System.Drawing.Point(17, 253);
            this.OPT.Name = "OPT";
            this.OPT.Size = new System.Drawing.Size(99, 74);
            this.OPT.TabIndex = 4;
            this.OPT.Text = "OPT";
            this.OPT.UseVisualStyleBackColor = true;
            this.OPT.Click += new System.EventHandler(this.OPT_Click);
            // 
            // AllBegin
            // 
            this.AllBegin.Location = new System.Drawing.Point(17, 355);
            this.AllBegin.Name = "AllBegin";
            this.AllBegin.Size = new System.Drawing.Size(99, 74);
            this.AllBegin.TabIndex = 5;
            this.AllBegin.Text = "图示";
            this.AllBegin.UseVisualStyleBackColor = true;
            this.AllBegin.Click += new System.EventHandler(this.AllBegin_Click_1);
            // 
            // FIFOPanel
            // 
            this.FIFOPanel.AutoScroll = true;
            this.FIFOPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FIFOPanel.Location = new System.Drawing.Point(132, 57);
            this.FIFOPanel.Name = "FIFOPanel";
            this.FIFOPanel.Size = new System.Drawing.Size(1170, 240);
            this.FIFOPanel.TabIndex = 6;
            this.FIFOPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // OPTPanel
            // 
            this.OPTPanel.AutoScroll = true;
            this.OPTPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OPTPanel.Location = new System.Drawing.Point(132, 553);
            this.OPTPanel.Name = "OPTPanel";
            this.OPTPanel.Size = new System.Drawing.Size(1170, 240);
            this.OPTPanel.TabIndex = 7;
            this.OPTPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "页面访问序列：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LRUPanel
            // 
            this.LRUPanel.AutoScroll = true;
            this.LRUPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LRUPanel.Location = new System.Drawing.Point(132, 307);
            this.LRUPanel.Name = "LRUPanel";
            this.LRUPanel.Size = new System.Drawing.Size(1170, 240);
            this.LRUPanel.TabIndex = 7;
            this.LRUPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LRUPanel_Paint);
            // 
            // FIFO
            // 
            this.FIFO.Location = new System.Drawing.Point(17, 57);
            this.FIFO.Name = "FIFO";
            this.FIFO.Size = new System.Drawing.Size(99, 74);
            this.FIFO.TabIndex = 2;
            this.FIFO.Text = "FIFO";
            this.FIFO.UseVisualStyleBackColor = true;
            this.FIFO.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(15, 457);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(101, 33);
            this.Pause.TabIndex = 8;
            this.Pause.Text = "暂停/恢复";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // acce
            // 
            this.acce.AutoSize = true;
            this.acce.Location = new System.Drawing.Point(30, 24);
            this.acce.Name = "acce";
            this.acce.Size = new System.Drawing.Size(82, 15);
            this.acce.TabIndex = 9;
            this.acce.Text = "快表已开启";
            this.acce.Click += new System.EventHandler(this.acce_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 74);
            this.button1.TabIndex = 10;
            this.button1.Text = "设置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 74);
            this.button2.TabIndex = 11;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 736);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 74);
            this.button3.TabIndex = 12;
            this.button3.Text = "全部清除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 805);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.acce);
            this.Controls.Add(this.OPTPanel);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AllBegin);
            this.Controls.Add(this.OPT);
            this.Controls.Add(this.FIFOPanel);
            this.Controls.Add(this.LRU);
            this.Controls.Add(this.FIFO);
            this.Controls.Add(this.LRUPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LRU;
        private System.Windows.Forms.Button OPT;
        private System.Windows.Forms.Button AllBegin;
        private System.Windows.Forms.Panel FIFOPanel;
        private System.Windows.Forms.Panel LRUPanel;
        private System.Windows.Forms.Panel OPTPanel;
        private System.Windows.Forms.Button FIFO;
        private System.Windows.Forms.Button Pause;
        public System.Windows.Forms.Label acce;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

