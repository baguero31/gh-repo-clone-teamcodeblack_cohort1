namespace CareerFairApp2022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NumberGuess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GuessCountDisplay = new System.Windows.Forms.Label();
            this.StartMission = new System.Windows.Forms.Button();
            this.TakeAWhack = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Countdown Timer";
            // 
            // NumberGuess
            // 
            this.NumberGuess.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberGuess.Location = new System.Drawing.Point(520, 91);
            this.NumberGuess.MaxLength = 9999999;
            this.NumberGuess.Name = "NumberGuess";
            this.NumberGuess.Size = new System.Drawing.Size(268, 52);
            this.NumberGuess.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Number  (1 - 9999999):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(301, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Guesses:";
            // 
            // GuessCountDisplay
            // 
            this.GuessCountDisplay.AutoSize = true;
            this.GuessCountDisplay.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuessCountDisplay.Location = new System.Drawing.Point(454, 177);
            this.GuessCountDisplay.Name = "GuessCountDisplay";
            this.GuessCountDisplay.Size = new System.Drawing.Size(38, 46);
            this.GuessCountDisplay.TabIndex = 4;
            this.GuessCountDisplay.Text = "0";
            // 
            // StartMission
            // 
            this.StartMission.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartMission.Location = new System.Drawing.Point(131, 236);
            this.StartMission.Name = "StartMission";
            this.StartMission.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartMission.Size = new System.Drawing.Size(251, 87);
            this.StartMission.TabIndex = 5;
            this.StartMission.Text = "Start Your Mission!";
            this.StartMission.UseVisualStyleBackColor = true;
            this.StartMission.Click += new System.EventHandler(this.StartMission_Click);
            // 
            // TakeAWhack
            // 
            this.TakeAWhack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TakeAWhack.Location = new System.Drawing.Point(406, 236);
            this.TakeAWhack.Name = "TakeAWhack";
            this.TakeAWhack.Size = new System.Drawing.Size(251, 87);
            this.TakeAWhack.TabIndex = 6;
            this.TakeAWhack.Text = "Take A Guess!";
            this.TakeAWhack.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBar1.Location = new System.Drawing.Point(12, 364);
            this.progressBar1.Maximum = 60;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 63);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.TakeAWhack);
            this.Controls.Add(this.StartMission);
            this.Controls.Add(this.GuessCountDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberGuess);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Mission:  IMPOSSIBLE!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberGuess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GuessCountDisplay;
        private System.Windows.Forms.Button StartMission;
        private System.Windows.Forms.Button TakeAWhack;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
