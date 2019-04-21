﻿namespace BookProject.Views.Admin.MasterView
{
    partial class MasterPage
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
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.panelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // panelToolStripMenuItem
            // 
            this.panelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userPanelToolStripMenuItem,
            this.categoryPanelToolStripMenuItem,
            this.bookPanelToolStripMenuItem});
            this.panelToolStripMenuItem.Enabled = false;
            this.panelToolStripMenuItem.Name = "panelToolStripMenuItem";
            this.panelToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.panelToolStripMenuItem.Text = "Panels";
            this.panelToolStripMenuItem.Visible = false;
            // 
            // userPanelToolStripMenuItem
            // 
            this.userPanelToolStripMenuItem.Name = "userPanelToolStripMenuItem";
            this.userPanelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userPanelToolStripMenuItem.Text = "User Panel";
            this.userPanelToolStripMenuItem.Click += new System.EventHandler(this.UserPanelToolStripMenuItem_Click);
            // 
            // categoryPanelToolStripMenuItem
            // 
            this.categoryPanelToolStripMenuItem.Name = "categoryPanelToolStripMenuItem";
            this.categoryPanelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoryPanelToolStripMenuItem.Text = "Category Panel";
            this.categoryPanelToolStripMenuItem.Click += new System.EventHandler(this.CategoryPanelToolStripMenuItem_Click);
            // 
            // bookPanelToolStripMenuItem
            // 
            this.bookPanelToolStripMenuItem.Name = "bookPanelToolStripMenuItem";
            this.bookPanelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookPanelToolStripMenuItem.Text = "Book Panel";
            this.bookPanelToolStripMenuItem.Click += new System.EventHandler(this.BookPanelToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // MasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 393);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterPage";
            this.Load += new System.EventHandler(this.MasterPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem panelToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem userPanelToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem categoryPanelToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem bookPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}