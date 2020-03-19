namespace NotebookApplication_hymanCorop
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loginClose_btn = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_pb = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loginClose_btn);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login Screen";
            // 
            // loginClose_btn
            // 
            this.loginClose_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.loginClose_btn.FlatAppearance.BorderSize = 0;
            this.loginClose_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginClose_btn.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginClose_btn.ForeColor = System.Drawing.Color.White;
            this.loginClose_btn.Location = new System.Drawing.Point(413, 12);
            this.loginClose_btn.Name = "loginClose_btn";
            this.loginClose_btn.Size = new System.Drawing.Size(32, 36);
            this.loginClose_btn.TabIndex = 1;
            this.loginClose_btn.Text = "X";
            this.loginClose_btn.UseVisualStyleBackColor = false;
            this.loginClose_btn.Click += new System.EventHandler(this.loginClose_btn_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(452, 61);
            this.shapeContainer2.TabIndex = 3;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 15;
            this.lineShape1.X2 = 213;
            this.lineShape1.Y1 = 44;
            this.lineShape1.Y2 = 44;
            // 
            // username_tb
            // 
            this.username_tb.BackColor = System.Drawing.Color.White;
            this.username_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.ForeColor = System.Drawing.Color.Black;
            this.username_tb.Location = new System.Drawing.Point(95, 69);
            this.username_tb.Multiline = true;
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(290, 41);
            this.username_tb.TabIndex = 1;
            this.username_tb.Text = "Username";
            this.username_tb.Enter += new System.EventHandler(this.username_tb_Enter);
            this.username_tb.Leave += new System.EventHandler(this.username_tb_Leave);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(83, 298);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(234, 54);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(14, 32);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(1, 74);
            this.rectangleShape1.Visible = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(12, 153);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(1, 77);
            this.rectangleShape2.Visible = false;
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.White;
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.ForeColor = System.Drawing.Color.Black;
            this.password_tb.Location = new System.Drawing.Point(95, 197);
            this.password_tb.Multiline = true;
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(290, 41);
            this.password_tb.TabIndex = 7;
            this.password_tb.Text = "Password";
            this.password_tb.Enter += new System.EventHandler(this.password_tb_Enter);
            this.password_tb.Leave += new System.EventHandler(this.password_tb_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 59);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // user_pb
            // 
            this.user_pb.Image = ((System.Drawing.Image)(resources.GetObject("user_pb.Image")));
            this.user_pb.Location = new System.Drawing.Point(20, 62);
            this.user_pb.Name = "user_pb";
            this.user_pb.Size = new System.Drawing.Size(63, 50);
            this.user_pb.TabIndex = 5;
            this.user_pb.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.password_tb);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.login_btn);
            this.groupBox1.Controls.Add(this.user_pb);
            this.groupBox1.Controls.Add(this.username_tb);
            this.groupBox1.Controls.Add(this.shapeContainer3);
            this.groupBox1.Location = new System.Drawing.Point(17, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 371);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer3.Size = new System.Drawing.Size(399, 350);
            this.shapeContainer3.TabIndex = 8;
            this.shapeContainer3.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 478);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginClose_btn;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Button login_btn;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.PictureBox user_pb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
    }
}