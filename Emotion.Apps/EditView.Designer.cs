namespace Emotion.Apps
{
    partial class EditView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbConfirm = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtWarna = new System.Windows.Forms.TextBox();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.txtGambar = new System.Windows.Forms.TextBox();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.txtMusic = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.cbConfirm);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtWarna);
            this.panel1.Controls.Add(this.txtBook);
            this.panel1.Controls.Add(this.txtGambar);
            this.panel1.Controls.Add(this.txtVideo);
            this.panel1.Controls.Add(this.txtMovie);
            this.panel1.Controls.Add(this.txtMusic);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.fullName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(33, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 576);
            this.panel1.TabIndex = 0;
            // 
            // cbConfirm
            // 
            this.cbConfirm.AutoSize = true;
            this.cbConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConfirm.Location = new System.Drawing.Point(17, 500);
            this.cbConfirm.Name = "cbConfirm";
            this.cbConfirm.Size = new System.Drawing.Size(177, 25);
            this.cbConfirm.TabIndex = 27;
            this.cbConfirm.Text = "*) Data sudah benar?";
            this.cbConfirm.UseVisualStyleBackColor = true;
            this.cbConfirm.CheckedChanged += new System.EventHandler(this.cbConfirm_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.ImageKey = "checked_user-36.png";
            this.btnUpdate.ImageList = this.imageList1;
            this.btnUpdate.Location = new System.Drawing.Point(337, 522);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 34);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Ubah";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "checked_user-36.png");
            // 
            // txtWarna
            // 
            this.txtWarna.Location = new System.Drawing.Point(17, 465);
            this.txtWarna.Name = "txtWarna";
            this.txtWarna.Size = new System.Drawing.Size(408, 29);
            this.txtWarna.TabIndex = 25;
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(17, 409);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(408, 29);
            this.txtBook.TabIndex = 24;
            // 
            // txtGambar
            // 
            this.txtGambar.Location = new System.Drawing.Point(17, 353);
            this.txtGambar.Name = "txtGambar";
            this.txtGambar.Size = new System.Drawing.Size(408, 29);
            this.txtGambar.TabIndex = 23;
            // 
            // txtVideo
            // 
            this.txtVideo.Location = new System.Drawing.Point(17, 299);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(408, 29);
            this.txtVideo.TabIndex = 22;
            // 
            // txtMovie
            // 
            this.txtMovie.Location = new System.Drawing.Point(17, 243);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(408, 29);
            this.txtMovie.TabIndex = 21;
            // 
            // txtMusic
            // 
            this.txtMusic.Location = new System.Drawing.Point(17, 187);
            this.txtMusic.Name = "txtMusic";
            this.txtMusic.Size = new System.Drawing.Size(408, 29);
            this.txtMusic.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Warna:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Buku/Tulisan:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Gambar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Video:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Movie/Film:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Music/Audio:";
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(17, 49);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(335, 29);
            this.fullName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data Diri Anda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama Lengkap :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Diri Anda";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(222, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Isilah data pribadi anda dengan benar.";
            // 
            // EditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 675);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditView";
            this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
            this.Text = "Formulir Ubah data";
            this.Load += new System.EventHandler(this.EditView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMusic;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.TextBox txtGambar;
        private System.Windows.Forms.TextBox txtVideo;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.TextBox txtWarna;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox cbConfirm;
        private System.Windows.Forms.ImageList imageList1;
    }
}