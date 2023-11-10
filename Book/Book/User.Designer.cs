namespace Book
{
    partial class User
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
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书查阅和借阅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.当前借出图书和归还ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.图书查阅和借阅ToolStripMenuItem,
            this.当前借出图书和归还ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 图书查阅和借阅ToolStripMenuItem
            // 
            this.图书查阅和借阅ToolStripMenuItem.Name = "图书查阅和借阅ToolStripMenuItem";
            this.图书查阅和借阅ToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.图书查阅和借阅ToolStripMenuItem.Text = "图书查看和借阅";
            this.图书查阅和借阅ToolStripMenuItem.Click += new System.EventHandler(this.图书查阅和借阅ToolStripMenuItem_Click);
            // 
            // 当前借出图书和归还ToolStripMenuItem
            // 
            this.当前借出图书和归还ToolStripMenuItem.Name = "当前借出图书和归还ToolStripMenuItem";
            this.当前借出图书和归还ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.当前借出图书和归还ToolStripMenuItem.Text = "当前借出图书和归还";
            this.当前借出图书和归还ToolStripMenuItem.Click += new System.EventHandler(this.当前借出图书和归还ToolStripMenuItem_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User";
            this.Text = "用户页面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书查阅和借阅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 当前借出图书和归还ToolStripMenuItem;
    }
}