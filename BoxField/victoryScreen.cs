﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace BoxField
{
    public partial class victoryScreen : UserControl
    {
        public victoryScreen()
        {
            InitializeComponent();
            scoreOutput.Text = GameScreen.score2;
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.victory);
            player2.Play();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);

            victoryLabel.Visible = false;
            restartButton.Visible = false;
            exitButton3.Visible = false;
            scoreTitle.Visible = false;
            scoreOutput.Visible = false;
        }

        private void exitButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
