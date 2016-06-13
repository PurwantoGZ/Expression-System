namespace Emotion.Apps
{
    partial class MainView
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
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.ViewImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(23, 63);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(516, 267);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // ViewImage
            // 
            this.ViewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewImage.Location = new System.Drawing.Point(23, 346);
            this.ViewImage.Name = "ViewImage";
            this.ViewImage.Size = new System.Drawing.Size(169, 155);
            this.ViewImage.TabIndex = 3;
            this.ViewImage.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 510);
            this.Controls.Add(this.ViewImage);
            this.Controls.Add(this.imageBox1);
            this.Name = "MainView";
            this.Resizable = false;
            this.Text = "Emotion Learning System";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.PictureBox ViewImage;
    }
}