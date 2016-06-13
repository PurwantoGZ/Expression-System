namespace Emotion.Apps
{
    partial class LoginView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtUser = new System.Windows.Forms.TextBox();
            this.notif = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notif);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RegisterLabel);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Location = new System.Drawing.Point(27, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(17, 105);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(325, 29);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Belum punya akun?";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(132, 156);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(44, 17);
            this.RegisterLabel.TabIndex = 5;
            this.RegisterLabel.Text = "Daftar";
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.ImageKey = "gardener-32.png";
            this.btnLogin.ImageList = this.imageList1;
            this.btnLogin.Location = new System.Drawing.Point(243, 142);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogin.Size = new System.Drawing.Size(99, 43);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "gardener-32.png");
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(17, 44);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(325, 29);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // notif
            // 
            this.notif.AutoSize = true;
            this.notif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notif.ForeColor = System.Drawing.Color.Red;
            this.notif.Location = new System.Drawing.Point(18, 137);
            this.notif.Name = "notif";
            this.notif.Size = new System.Drawing.Size(0, 15);
            this.notif.TabIndex = 12;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 276);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginView";
            this.Padding = new System.Windows.Forms.Padding(37, 111, 37, 37);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginView_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label notif;
    }
}