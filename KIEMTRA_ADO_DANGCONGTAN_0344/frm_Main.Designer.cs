namespace KIEMTRA_ADO_DANGCONGTAN_0344
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhaCungCapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaCungCapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhaCungCapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhaCungCapToolStripMenuItem
            // 
            this.nhaCungCapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhaCungCapToolStripMenuItem1,
            this.danhMucHangToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.nhaCungCapToolStripMenuItem.Name = "nhaCungCapToolStripMenuItem";
            this.nhaCungCapToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.nhaCungCapToolStripMenuItem.Text = "Open";
            // 
            // nhaCungCapToolStripMenuItem1
            // 
            this.nhaCungCapToolStripMenuItem1.Name = "nhaCungCapToolStripMenuItem1";
            this.nhaCungCapToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.nhaCungCapToolStripMenuItem1.Text = "Nha Cung Cap";
            this.nhaCungCapToolStripMenuItem1.Click += new System.EventHandler(this.nhaCungCapToolStripMenuItem1_Click);
            // 
            // danhMucHangToolStripMenuItem
            // 
            this.danhMucHangToolStripMenuItem.Name = "danhMucHangToolStripMenuItem";
            this.danhMucHangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.danhMucHangToolStripMenuItem.Text = "Danh Muc Hang";
            this.danhMucHangToolStripMenuItem.Click += new System.EventHandler(this.danhMucHangToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 557);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "frm_Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhaCungCapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhaCungCapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem danhMucHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}