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
            this.button4 = new System.Windows.Forms.Button();
            this.FIFOPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OPTPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LFUPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LRUPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FIFO = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.FIFOPanel.SuspendLayout();
            this.OPTPanel.SuspendLayout();
            this.LFUPanel.SuspendLayout();
            this.LRUPanel.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LRU
            // 
            this.LRU.Location = new System.Drawing.Point(225, 28);
            this.LRU.Name = "LRU";
            this.LRU.Size = new System.Drawing.Size(99, 74);
            this.LRU.TabIndex = 3;
            this.LRU.Text = "LRU";
            this.LRU.UseVisualStyleBackColor = true;
            this.LRU.Click += new System.EventHandler(this.button2_Click);
            // 
            // OPT
            // 
            this.OPT.Location = new System.Drawing.Point(406, 28);
            this.OPT.Name = "OPT";
            this.OPT.Size = new System.Drawing.Size(99, 74);
            this.OPT.TabIndex = 4;
            this.OPT.Text = "OPT";
            this.OPT.UseVisualStyleBackColor = true;
            this.OPT.Click += new System.EventHandler(this.OPT_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(587, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 74);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FIFOPanel
            // 
            this.FIFOPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FIFOPanel.Controls.Add(this.label1);
            this.FIFOPanel.Location = new System.Drawing.Point(0, 154);
            this.FIFOPanel.Name = "FIFOPanel";
            this.FIFOPanel.Size = new System.Drawing.Size(1181, 534);
            this.FIFOPanel.TabIndex = 6;
            this.FIFOPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIFO";
            // 
            // OPTPanel
            // 
            this.OPTPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OPTPanel.Controls.Add(this.label4);
            this.OPTPanel.Location = new System.Drawing.Point(0, 154);
            this.OPTPanel.Name = "OPTPanel";
            this.OPTPanel.Size = new System.Drawing.Size(1181, 534);
            this.OPTPanel.TabIndex = 7;
            this.OPTPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "OPT";
            // 
            // LFUPanel
            // 
            this.LFUPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LFUPanel.Controls.Add(this.label5);
            this.LFUPanel.Location = new System.Drawing.Point(0, 154);
            this.LFUPanel.Name = "LFUPanel";
            this.LFUPanel.Size = new System.Drawing.Size(1181, 534);
            this.LFUPanel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(13, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "LFU";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(29, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(912, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "页面访问序列：";
            // 
            // LRUPanel
            // 
            this.LRUPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LRUPanel.Controls.Add(this.label2);
            this.LRUPanel.Location = new System.Drawing.Point(0, 154);
            this.LRUPanel.Name = "LRUPanel";
            this.LRUPanel.Size = new System.Drawing.Size(1181, 534);
            this.LRUPanel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "LRU";
            // 
            // FIFO
            // 
            this.FIFO.Location = new System.Drawing.Point(44, 28);
            this.FIFO.Name = "FIFO";
            this.FIFO.Size = new System.Drawing.Size(99, 74);
            this.FIFO.TabIndex = 2;
            this.FIFO.Text = "FIFO";
            this.FIFO.UseVisualStyleBackColor = true;
            this.FIFO.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(746, 69);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(101, 33);
            this.Pause.TabIndex = 8;
            this.Pause.Text = "暂停/恢复";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1181, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 669);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.LFUPanel);
            this.Controls.Add(this.OPT);
            this.Controls.Add(this.OPTPanel);
            this.Controls.Add(this.LRU);
            this.Controls.Add(this.FIFOPanel);
            this.Controls.Add(this.FIFO);
            this.Controls.Add(this.LRUPanel);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FIFOPanel.ResumeLayout(false);
            this.FIFOPanel.PerformLayout();
            this.OPTPanel.ResumeLayout(false);
            this.OPTPanel.PerformLayout();
            this.LFUPanel.ResumeLayout(false);
            this.LFUPanel.PerformLayout();
            this.LRUPanel.ResumeLayout(false);
            this.LRUPanel.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LRU;
        private System.Windows.Forms.Button OPT;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel FIFOPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel LRUPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel OPTPanel;
        private System.Windows.Forms.Panel LFUPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FIFO;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}

