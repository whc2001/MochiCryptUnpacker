namespace MochiCryptUnpacker
{
    partial class frmMain
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.llbAbout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(36, 6);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(251, 24);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "将 MochiCrypt 加密的 SWF 拖入窗口进行解密\r\nDrop SWF file inside to unpack";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 33);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(299, 113);
            this.txtLog.TabIndex = 1;
            // 
            // llbAbout
            // 
            this.llbAbout.AutoSize = true;
            this.llbAbout.Location = new System.Drawing.Point(287, 149);
            this.llbAbout.Name = "llbAbout";
            this.llbAbout.Size = new System.Drawing.Size(35, 12);
            this.llbAbout.TabIndex = 2;
            this.llbAbout.TabStop = true;
            this.llbAbout.Text = "About";
            this.llbAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbAbout_LinkClicked);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 162);
            this.Controls.Add(this.llbAbout);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "MochiCryptUnpacker";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.LinkLabel llbAbout;
    }
}

