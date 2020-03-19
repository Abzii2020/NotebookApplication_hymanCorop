namespace NotebookApplication_hymanCorop
{
    partial class MainWindow
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatusDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivedUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsilLoginText = new System.Windows.Forms.ToolStripStatusLabel();
            this.deleteUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.manageUsersToolStripMenuItem,
            this.manageAccessToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.editUserDetailsToolStripMenuItem,
            this.viewUserDetailsToolStripMenuItem,
            this.deleteUserToolStripMenuItem1});
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editUserDetailsToolStripMenuItem
            // 
            this.editUserDetailsToolStripMenuItem.Name = "editUserDetailsToolStripMenuItem";
            this.editUserDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editUserDetailsToolStripMenuItem.Text = "Edit User Details";
            this.editUserDetailsToolStripMenuItem.Click += new System.EventHandler(this.editUserDetailsToolStripMenuItem_Click);
            // 
            // viewUserDetailsToolStripMenuItem
            // 
            this.viewUserDetailsToolStripMenuItem.Name = "viewUserDetailsToolStripMenuItem";
            this.viewUserDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewUserDetailsToolStripMenuItem.Text = "View User Details";
            this.viewUserDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewUserDetailsToolStripMenuItem_Click);
            // 
            // manageAccessToolStripMenuItem
            // 
            this.manageAccessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserStatusToolStripMenuItem,
            this.viewStatusDetailsToolStripMenuItem,
            this.resetPasswordToolStripMenuItem});
            this.manageAccessToolStripMenuItem.Name = "manageAccessToolStripMenuItem";
            this.manageAccessToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.manageAccessToolStripMenuItem.Text = "Manage Access";
            this.manageAccessToolStripMenuItem.Click += new System.EventHandler(this.manageAccessToolStripMenuItem_Click);
            // 
            // UserStatusToolStripMenuItem
            // 
            this.UserStatusToolStripMenuItem.Name = "UserStatusToolStripMenuItem";
            this.UserStatusToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.UserStatusToolStripMenuItem.Text = "Deactivate/Activate User";
            this.UserStatusToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // viewStatusDetailsToolStripMenuItem
            // 
            this.viewStatusDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeUsersToolStripMenuItem,
            this.deactivedUsersToolStripMenuItem});
            this.viewStatusDetailsToolStripMenuItem.Name = "viewStatusDetailsToolStripMenuItem";
            this.viewStatusDetailsToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.viewStatusDetailsToolStripMenuItem.Text = "View Status Details";
            // 
            // activeUsersToolStripMenuItem
            // 
            this.activeUsersToolStripMenuItem.Name = "activeUsersToolStripMenuItem";
            this.activeUsersToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.activeUsersToolStripMenuItem.Text = "Active Users";
            this.activeUsersToolStripMenuItem.Click += new System.EventHandler(this.activeUsersToolStripMenuItem_Click);
            // 
            // deactivedUsersToolStripMenuItem
            // 
            this.deactivedUsersToolStripMenuItem.Name = "deactivedUsersToolStripMenuItem";
            this.deactivedUsersToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.deactivedUsersToolStripMenuItem.Text = "Deactived Users";
            this.deactivedUsersToolStripMenuItem.Click += new System.EventHandler(this.deactivedUsersToolStripMenuItem_Click);
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password";
            this.resetPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetPasswordToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsilLoginText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsilLoginText
            // 
            this.tsilLoginText.Name = "tsilLoginText";
            this.tsilLoginText.Size = new System.Drawing.Size(0, 16);
            // 
            // deleteUserToolStripMenuItem1
            // 
            this.deleteUserToolStripMenuItem1.Name = "deleteUserToolStripMenuItem1";
            this.deleteUserToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.deleteUserToolStripMenuItem1.Text = "Delete User ";
            this.deleteUserToolStripMenuItem1.Click += new System.EventHandler(this.deleteUserToolStripMenuItem1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NotebookApplication_hymanCorop.Properties.Resources.formImg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUserDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatusDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactivedUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsilLoginText;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem1;
    }
}