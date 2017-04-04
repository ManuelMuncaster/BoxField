using System;
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
    public partial class victoryScreen : UserControl
    {
        public victoryScreen()
        {
            InitializeComponent();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);

            victoryLabel.Visible = false;
            restartButton.Visible = false;
            exitButton3.Visible = false;
        }

        private void exitButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
