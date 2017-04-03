namespace BoxField
{
    partial class GameoverScreen
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
            this.continueButton = new System.Windows.Forms.Button();
            this.exitButton2 = new System.Windows.Forms.Button();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(324, 234);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 0;
            this.continueButton.Text = "Continue?";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // exitButton2
            // 
            this.exitButton2.Location = new System.Drawing.Point(497, 234);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(75, 23);
            this.exitButton2.TabIndex = 1;
            this.exitButton2.Text = "Exit";
            this.exitButton2.UseVisualStyleBackColor = true;
            this.exitButton2.Click += new System.EventHandler(this.exitButton2_Click);
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.ForeColor = System.Drawing.Color.White;
            this.gameoverLabel.Location = new System.Drawing.Point(415, 170);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(64, 13);
            this.gameoverLabel.TabIndex = 2;
            this.gameoverLabel.Text = "Game Over!";
            // 
            // GameoverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.gameoverLabel);
            this.Controls.Add(this.exitButton2);
            this.Controls.Add(this.continueButton);
            this.Name = "GameoverScreen";
            this.Size = new System.Drawing.Size(900, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button exitButton2;
        private System.Windows.Forms.Label gameoverLabel;
    }
}
