namespace Emotion.Apps
{
    partial class TestingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestingView));
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Terminal = new System.Windows.Forms.ListBox();
            this.btnTraining = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.UserInfo = new System.Windows.Forms.Button();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.Keterangan = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Kesenangan = new System.Windows.Forms.Label();
            this.Kesedihan = new System.Windows.Forms.Label();
            this.NamaFull = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelSaran = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.captureImageBox = new Emgu.CV.UI.ImageBox();
            this.PanelPreview = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.statusF1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusF2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusF3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusF4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusF5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusF6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.yValuesText = new System.Windows.Forms.ToolStripStatusLabel();
            this.Accuracy = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorText = new System.Windows.Forms.ToolStripStatusLabel();
            this.PanelInfo.SuspendLayout();
            this.PanelSaran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).BeginInit();
            this.PanelPreview.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageKey = "(none)";
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Citra Wajah";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "engineering-32.png");
            this.imageList1.Images.SetKeyName(1, "webcam-32.png");
            this.imageList1.Images.SetKeyName(2, "user-32.png");
            this.imageList1.Images.SetKeyName(3, "camera-48.png");
            this.imageList1.Images.SetKeyName(4, "slr_camera-36.png");
            this.imageList1.Images.SetKeyName(5, "slr_camera-48.png");
            this.imageList1.Images.SetKeyName(6, "idea-36.png");
            this.imageList1.Images.SetKeyName(7, "mind_map-36.png");
            this.imageList1.Images.SetKeyName(8, "play-36.png");
            this.imageList1.Images.SetKeyName(9, "stop-36.png");
            // 
            // Terminal
            // 
            this.Terminal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Terminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Terminal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Terminal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terminal.FormattingEnabled = true;
            this.Terminal.ItemHeight = 21;
            this.Terminal.Location = new System.Drawing.Point(9, 32);
            this.Terminal.Name = "Terminal";
            this.Terminal.Size = new System.Drawing.Size(258, 42);
            this.Terminal.TabIndex = 4;
            this.Terminal.SelectedIndexChanged += new System.EventHandler(this.Terminal_SelectedIndexChanged);
            // 
            // btnTraining
            // 
            this.btnTraining.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraining.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTraining.FlatAppearance.BorderSize = 0;
            this.btnTraining.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnTraining.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraining.ImageKey = "engineering-32.png";
            this.btnTraining.ImageList = this.imageList1;
            this.btnTraining.Location = new System.Drawing.Point(765, 43);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(35, 30);
            this.btnTraining.TabIndex = 4;
            this.btnTraining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraining.UseVisualStyleBackColor = true;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // UserInfo
            // 
            this.UserInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UserInfo.AutoSize = true;
            this.UserInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UserInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserInfo.FlatAppearance.BorderSize = 0;
            this.UserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserInfo.ImageKey = "user-32.png";
            this.UserInfo.ImageList = this.imageList1;
            this.UserInfo.Location = new System.Drawing.Point(657, 42);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserInfo.Size = new System.Drawing.Size(102, 30);
            this.UserInfo.TabIndex = 6;
            this.UserInfo.Text = "Purwanto";
            this.UserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.UserInfo.UseVisualStyleBackColor = true;
            this.UserInfo.Click += new System.EventHandler(this.UserInfo_Click);
            // 
            // PanelInfo
            // 
            this.PanelInfo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PanelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelInfo.Controls.Add(this.Keterangan);
            this.PanelInfo.Controls.Add(this.label8);
            this.PanelInfo.Controls.Add(this.label7);
            this.PanelInfo.Controls.Add(this.label6);
            this.PanelInfo.Controls.Add(this.label5);
            this.PanelInfo.Controls.Add(this.Kesenangan);
            this.PanelInfo.Controls.Add(this.Kesedihan);
            this.PanelInfo.Controls.Add(this.NamaFull);
            this.PanelInfo.Controls.Add(this.label2);
            this.PanelInfo.Location = new System.Drawing.Point(510, 75);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(290, 264);
            this.PanelInfo.TabIndex = 7;
            // 
            // Keterangan
            // 
            this.Keterangan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Keterangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Keterangan.Location = new System.Drawing.Point(3, 147);
            this.Keterangan.Name = "Keterangan";
            this.Keterangan.ReadOnly = true;
            this.Keterangan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Keterangan.Size = new System.Drawing.Size(264, 80);
            this.Keterangan.TabIndex = 14;
            this.Keterangan.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(150, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ekspresi Sedih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ekspresi Senang";
            // 
            // Kesenangan
            // 
            this.Kesenangan.AutoSize = true;
            this.Kesenangan.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kesenangan.Location = new System.Drawing.Point(164, 60);
            this.Kesenangan.Name = "Kesenangan";
            this.Kesenangan.Size = new System.Drawing.Size(0, 32);
            this.Kesenangan.TabIndex = 9;
            // 
            // Kesedihan
            // 
            this.Kesedihan.AutoSize = true;
            this.Kesedihan.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kesedihan.Location = new System.Drawing.Point(164, 95);
            this.Kesedihan.Name = "Kesedihan";
            this.Kesedihan.Size = new System.Drawing.Size(0, 32);
            this.Kesedihan.TabIndex = 8;
            // 
            // NamaFull
            // 
            this.NamaFull.AutoSize = true;
            this.NamaFull.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaFull.Location = new System.Drawing.Point(10, 28);
            this.NamaFull.Name = "NamaFull";
            this.NamaFull.Size = new System.Drawing.Size(136, 37);
            this.NamaFull.TabIndex = 7;
            this.NamaFull.Text = "Purwanto";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageKey = "(none)";
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ekspresi Anda";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelSaran
            // 
            this.PanelSaran.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PanelSaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSaran.Controls.Add(this.label3);
            this.PanelSaran.Controls.Add(this.Terminal);
            this.PanelSaran.Location = new System.Drawing.Point(510, 301);
            this.PanelSaran.Name = "PanelSaran";
            this.PanelSaran.Size = new System.Drawing.Size(290, 125);
            this.PanelSaran.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.ImageKey = "(none)";
            this.label3.ImageList = this.imageList1;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Silahkan klik link dibawah ini:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // captureImageBox
            // 
            this.captureImageBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.captureImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captureImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captureImageBox.Location = new System.Drawing.Point(0, 0);
            this.captureImageBox.Name = "captureImageBox";
            this.captureImageBox.Size = new System.Drawing.Size(471, 351);
            this.captureImageBox.TabIndex = 2;
            this.captureImageBox.TabStop = false;
            // 
            // PanelPreview
            // 
            this.PanelPreview.Controls.Add(this.label1);
            this.PanelPreview.Controls.Add(this.captureImageBox);
            this.PanelPreview.Location = new System.Drawing.Point(33, 75);
            this.PanelPreview.Name = "PanelPreview";
            this.PanelPreview.Size = new System.Drawing.Size(471, 351);
            this.PanelPreview.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStart.AutoSize = true;
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.ImageIndex = 8;
            this.btnStart.ImageList = this.imageList1;
            this.btnStart.Location = new System.Drawing.Point(33, 435);
            this.btnStart.Name = "btnStart";
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStart.Size = new System.Drawing.Size(72, 32);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusF1,
            this.statusF2,
            this.statusF3,
            this.statusF4,
            this.statusF5,
            this.statusF6,
            this.yValuesText,
            this.Accuracy,
            this.ErrorText});
            this.StatusBar.Location = new System.Drawing.Point(30, 479);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(776, 22);
            this.StatusBar.TabIndex = 11;
            this.StatusBar.Text = "statusStrip1";
            // 
            // statusF1
            // 
            this.statusF1.Name = "statusF1";
            this.statusF1.Size = new System.Drawing.Size(22, 17);
            this.statusF1.Text = "F1:";
            // 
            // statusF2
            // 
            this.statusF2.Name = "statusF2";
            this.statusF2.Size = new System.Drawing.Size(22, 17);
            this.statusF2.Text = "F2:";
            // 
            // statusF3
            // 
            this.statusF3.Name = "statusF3";
            this.statusF3.Size = new System.Drawing.Size(22, 17);
            this.statusF3.Text = "F3:";
            // 
            // statusF4
            // 
            this.statusF4.Name = "statusF4";
            this.statusF4.Size = new System.Drawing.Size(22, 17);
            this.statusF4.Text = "F4:";
            // 
            // statusF5
            // 
            this.statusF5.Name = "statusF5";
            this.statusF5.Size = new System.Drawing.Size(22, 17);
            this.statusF5.Text = "F5:";
            // 
            // statusF6
            // 
            this.statusF6.Name = "statusF6";
            this.statusF6.Size = new System.Drawing.Size(22, 17);
            this.statusF6.Text = "F6:";
            // 
            // yValuesText
            // 
            this.yValuesText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yValuesText.Name = "yValuesText";
            this.yValuesText.Size = new System.Drawing.Size(58, 17);
            this.yValuesText.Text = "yValues : ";
            // 
            // Accuracy
            // 
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.Size = new System.Drawing.Size(56, 17);
            this.Accuracy.Text = "Accuracy";
            // 
            // ErrorText
            // 
            this.ErrorText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ErrorText.Size = new System.Drawing.Size(34, 17);
            this.ErrorText.Text = "Error:";
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TestingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 532);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.PanelPreview);
            this.Controls.Add(this.PanelSaran);
            this.Controls.Add(this.PanelInfo);
            this.Controls.Add(this.UserInfo);
            this.Controls.Add(this.btnTraining);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TestingView";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Resizable = false;
            this.Text = "Sistem Deteksi Ekspresi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestingView_FormClosing);
            this.Load += new System.EventHandler(this.TestingView_Load);
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.PanelSaran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).EndInit();
            this.PanelPreview.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox Terminal;
        private System.Windows.Forms.Button UserInfo;
        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Panel PanelSaran;
        private Emgu.CV.UI.ImageBox captureImageBox;
        private System.Windows.Forms.Panel PanelPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel yValuesText;
        private System.Windows.Forms.ToolStripStatusLabel ErrorText;
        private System.Windows.Forms.ToolStripStatusLabel Accuracy;
        private System.Windows.Forms.ToolStripStatusLabel statusF1;
        private System.Windows.Forms.ToolStripStatusLabel statusF2;
        private System.Windows.Forms.ToolStripStatusLabel statusF3;
        private System.Windows.Forms.ToolStripStatusLabel statusF4;
        private System.Windows.Forms.ToolStripStatusLabel statusF5;
        private System.Windows.Forms.ToolStripStatusLabel statusF6;
        private System.Windows.Forms.Label NamaFull;
        private System.Windows.Forms.Label Kesenangan;
        private System.Windows.Forms.Label Kesedihan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Keterangan;
    }
}