﻿namespace BoxField
{
    partial class victoryScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.restartButton = new System.Windows.Forms.Button();
            this.exitButton3 = new System.Windows.Forms.Button();
            this.victoryLabel = new System.Windows.Forms.Label();
            this.scoreTitle = new System.Windows.Forms.Label();
            this.scoreOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(315, 245);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 0;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // exitButton3
            // 
            this.exitButton3.Location = new System.Drawing.Point(486, 245);
            this.exitButton3.Name = "exitButton3";
            this.exitButton3.Size = new System.Drawing.Size(75, 23);
            this.exitButton3.TabIndex = 1;
            this.exitButton3.Text = "Exit";
            this.exitButton3.UseVisualStyleBackColor = true;
            this.exitButton3.Click += new System.EventHandler(this.exitButton3_Click);
            // 
            // victoryLabel
            // 
            this.victoryLabel.AutoSize = true;
            this.victoryLabel.ForeColor = System.Drawing.Color.White;
            this.victoryLabel.Location = new System.Drawing.Point(413, 146);
            this.victoryLabel.Name = "victoryLabel";
            this.victoryLabel.Size = new System.Drawing.Size(51, 13);
            this.victoryLabel.TabIndex = 2;
            this.victoryLabel.Text = "You Win!";
            // 
            // scoreTitle
            // 
            this.scoreTitle.AutoSize = true;
            this.scoreTitle.ForeColor = System.Drawing.Color.White;
            this.scoreTitle.Location = new System.Drawing.Point(390, 206);
            this.scoreTitle.Name = "scoreTitle";
            this.scoreTitle.Size = new System.Drawing.Size(38, 13);
            this.scoreTitle.TabIndex = 3;
            this.scoreTitle.Text = "Score:";
            // 
            // scoreOutput
            // 
            this.scoreOutput.AutoSize = true;
            this.scoreOutput.ForeColor = System.Drawing.Color.White;
            this.scoreOutput.Location = new System.Drawing.Point(434, 206);
            this.scoreOutput.Name = "scoreOutput";
            this.scoreOutput.Size = new System.Drawing.Size(35, 13);
            this.scoreOutput.TabIndex = 4;
            this.scoreOutput.Text = "label1";
            // 
            // victoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.scoreOutput);
            this.Controls.Add(this.scoreTitle);
            this.Controls.Add(this.victoryLabel);
            this.Controls.Add(this.exitButton3);
            this.Controls.Add(this.restartButton);
            this.Name = "victoryScreen";
            this.Size = new System.Drawing.Size(900, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button exitButton3;
        private System.Windows.Forms.Label victoryLabel;
        private System.Windows.Forms.Label scoreTitle;
        private System.Windows.Forms.Label scoreOutput;
    }
}
