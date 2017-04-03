﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxField
{
    public partial class GameoverScreen : UserControl
    {
        public GameoverScreen()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);

            gameoverLabel.Visible = false;
            continueButton.Visible = false;
            exitButton2.Visible = false;
        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}