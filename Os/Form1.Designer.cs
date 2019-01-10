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
            this.label1 = new System.Windows.Forms.Label();
            this.OPTPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LRUPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.FIFO = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.acce = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FIFOPanel.SuspendLayout();
            this.OPTPanel.SuspendLayout();
            this.LRUPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LRU
            // 
            this.LRU.Location = new System.Drawing.Point(17, 122);
            this.LRU.Name = "LRU";
            this.LRU.Size = new System.Drawing.Size(99, 74);
            this.LRU.TabIndex = 3;
            this.LRU.Text = "LRU";
            this.LRU.UseVisualStyleBackColor = true;
            this.LRU.Click += new System.EventHandler(this.button2_Click);
            // 
            // OPT
            // 
            this.OPT.Location = new System.Drawing.Point(17, 220);
            this.OPT.Name = "OPT";
            this.OPT.Size = new System.Drawing.Size(99, 74);
            this.OPT.TabIndex = 4;
            this.OPT.Text = "OPT";
            this.OPT.UseVisualStyleBackColor = true;
            this.OPT.Click += new System.EventHandler(this.OPT_Click);
            // 
            // AllBegin
            // 
            this.AllBegin.Location = new System.Drawing.Point(17, 318);
            this.AllBegin.Name = "AllBegin";
            this.AllBegin.Size = new System.Drawing.Size(99, 74);
            this.AllBegin.TabIndex = 5;
            this.AllBegin.Text = "全部执行";
            this.AllBegin.UseVisualStyleBackColor = true;
            this.AllBegin.Click += new System.EventHandler(this.AllBegin_Click_1);
            // 
            // FIFOPanel
            // 
            this.FIFOPanel.AutoScroll = true;
            this.FIFOPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FIFOPanel.Controls.Add(this.label1);
            this.FIFOPanel.Location = new System.Drawing.Point(132, 57);
            this.FIFOPanel.Name = "FIFOPanel";
            this.FIFOPanel.Size = new System.Drawing.Size(1170, 240);
            this.FIFOPanel.TabIndex = 6;
            this.FIFOPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIFO算法用时";
            // 
            // OPTPanel
            // 
            this.OPTPanel.AutoScroll = true;
            this.OPTPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OPTPanel.Controls.Add(this.label4);
            this.OPTPanel.Location = new System.Drawing.Point(132, 553);
            this.OPTPanel.Name = "OPTPanel";
            this.OPTPanel.Size = new System.Drawing.Size(1170, 240);
            this.OPTPanel.TabIndex = 7;
            this.OPTPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "OPT算法用时";
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
            this.LRUPanel.Controls.Add(this.label5);
            this.LRUPanel.Location = new System.Drawing.Point(132, 307);
            this.LRUPanel.Name = "LRUPanel";
            this.LRUPanel.Size = new System.Drawing.Size(1170, 240);
            this.LRUPanel.TabIndex = 7;
            this.LRUPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LRUPanel_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "LRU算法用时";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FIFO
            // 
            this.FIFO.Location = new System.Drawing.Point(17, 24);
            this.FIFO.Name = "FIFO";
            this.FIFO.Size = new System.Drawing.Size(99, 74);
            this.FIFO.TabIndex = 2;
            this.FIFO.Text = "FIFO";
            this.FIFO.UseVisualStyleBackColor = true;
            this.FIFO.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(15, 410);
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
            this.acce.Location = new System.Drawing.Point(12, 470);
            this.acce.Name = "acce";
            this.acce.Size = new System.Drawing.Size(82, 15);
            this.acce.TabIndex = 9;
            this.acce.Text = "快表已开启";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 74);
            this.button1.TabIndex = 10;
            this.button1.Text = "设置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 805);
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
            this.FIFOPanel.ResumeLayout(false);
            this.FIFOPanel.PerformLayout();
            this.OPTPanel.ResumeLayout(false);
            this.OPTPanel.PerformLayout();
            this.LRUPanel.ResumeLayout(false);
            this.LRUPanel.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FIFO;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label acce;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
    }
}

