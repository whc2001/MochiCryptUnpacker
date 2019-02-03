namespace MochiCryptUnpacker
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.panAbout = new System.Windows.Forms.Panel();
            this.lblAbout = new System.Windows.Forms.Label();
            this.panAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panAbout
            // 
            this.panAbout.AutoScroll = true;
            this.panAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panAbout.Controls.Add(this.lblAbout);
            this.panAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panAbout.Location = new System.Drawing.Point(0, 0);
            this.panAbout.Name = "panAbout";
            this.panAbout.Size = new System.Drawing.Size(443, 241);
            this.panAbout.TabIndex = 0;
            // 
            // lblAbout
            // 
            this.lblAbout.Location = new System.Drawing.Point(0, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(50, 50);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = resources.GetString("lblAbout.Text");
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 241);
            this.Controls.Add(this.panAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.panAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panAbout;
        private System.Windows.Forms.Label lblAbout;
    }
}