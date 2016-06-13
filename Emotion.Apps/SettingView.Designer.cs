namespace Emotion.Apps
{
    partial class SettingView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DetectionScale = new System.Windows.Forms.TextBox();
            this.Neighbors = new MetroFramework.Controls.MetroComboBox();
            this.Increase = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.DetectionScale);
            this.groupBox1.Controls.Add(this.Neighbors);
            this.groupBox1.Controls.Add(this.Increase);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(261, 199);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(111, 41);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // DetectionScale
            // 
            this.DetectionScale.Location = new System.Drawing.Point(218, 131);
            this.DetectionScale.Name = "DetectionScale";
            this.DetectionScale.Size = new System.Drawing.Size(154, 33);
            this.DetectionScale.TabIndex = 6;
            // 
            // Neighbors
            // 
            this.Neighbors.FormattingEnabled = true;
            this.Neighbors.ItemHeight = 23;
            this.Neighbors.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Neighbors.Location = new System.Drawing.Point(218, 83);
            this.Neighbors.Name = "Neighbors";
            this.Neighbors.Size = new System.Drawing.Size(154, 29);
            this.Neighbors.TabIndex = 5;
            this.Neighbors.UseSelectable = true;
            // 
            // Increase
            // 
            this.Increase.FormattingEnabled = true;
            this.Increase.ItemHeight = 23;
            this.Increase.Items.AddRange(new object[] {
            "0.8",
            "0.9",
            "1.0",
            "1.1",
            "1.2",
            "1.3",
            "1.4",
            "1.5",
            "1.6",
            "1.7",
            "1.9",
            "2.0"});
            this.Increase.Location = new System.Drawing.Point(218, 29);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(154, 29);
            this.Increase.TabIndex = 4;
            this.Increase.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "(Window Size)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min. Detection Scale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min. Neighbor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scale Increase Rate";
            // 
            // SettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 358);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingView";
            this.Padding = new System.Windows.Forms.Padding(37, 115, 37, 38);
            this.Resizable = false;
            this.Text = "Setting Camera";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox Neighbors;
        private MetroFramework.Controls.MetroComboBox Increase;
        private System.Windows.Forms.TextBox DetectionScale;
        private System.Windows.Forms.Button SaveBtn;
    }
}