namespace WinformGame
{
    partial class loginPage
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
            this.pfpButton = new System.Windows.Forms.Button();
            this.PFPPath = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pfpButton
            // 
            this.pfpButton.Location = new System.Drawing.Point(328, 210);
            this.pfpButton.Name = "pfpButton";
            this.pfpButton.Size = new System.Drawing.Size(75, 23);
            this.pfpButton.TabIndex = 2;
            this.pfpButton.Text = "Select PFP";
            this.pfpButton.UseVisualStyleBackColor = true;
            this.pfpButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PFPPath
            // 
            this.PFPPath.AutoSize = true;
            this.PFPPath.Location = new System.Drawing.Point(319, 105);
            this.PFPPath.Name = "PFPPath";
            this.PFPPath.Size = new System.Drawing.Size(97, 13);
            this.PFPPath.TabIndex = 3;
            this.PFPPath.Text = "Profile Picture Path";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(316, 184);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 20);
            this.usernameBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(340, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(252, 187);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username:";
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(323, 238);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(87, 41);
            this.continueButton.TabIndex = 7;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.PFPPath);
            this.Controls.Add(this.pfpButton);
            this.Name = "loginPage";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pfpButton;
        private System.Windows.Forms.Label PFPPath;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button continueButton;
    }
}

