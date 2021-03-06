
namespace WinformGame
{
    partial class RPS
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.cpuDecisionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(396, -2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(10, 452);
            this.progressBar1.TabIndex = 0;
            // 
            // rockButton
            // 
            this.rockButton.Location = new System.Drawing.Point(165, 166);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(75, 23);
            this.rockButton.TabIndex = 1;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Location = new System.Drawing.Point(165, 195);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(75, 23);
            this.paperButton.TabIndex = 2;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorsButton
            // 
            this.scissorsButton.Location = new System.Drawing.Point(165, 224);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(75, 23);
            this.scissorsButton.TabIndex = 3;
            this.scissorsButton.Text = "Scissors";
            this.scissorsButton.UseVisualStyleBackColor = true;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.Location = new System.Drawing.Point(108, 150);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(195, 13);
            this.choiceLabel.TabIndex = 4;
            this.choiceLabel.Text = "Selecting your choice will execute a roll.";
            // 
            // cpuDecisionLabel
            // 
            this.cpuDecisionLabel.AutoSize = true;
            this.cpuDecisionLabel.Location = new System.Drawing.Point(580, 200);
            this.cpuDecisionLabel.Name = "cpuDecisionLabel";
            this.cpuDecisionLabel.Size = new System.Drawing.Size(68, 13);
            this.cpuDecisionLabel.TabIndex = 5;
            this.cpuDecisionLabel.Text = "AI\'s Decision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wins";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Losses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Draws";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "0";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // RPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpuDecisionLabel);
            this.Controls.Add(this.choiceLabel);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.progressBar1);
            this.Name = "RPS";
            this.Text = "RPS";
            this.Load += new System.EventHandler(this.RPS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.Label cpuDecisionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}