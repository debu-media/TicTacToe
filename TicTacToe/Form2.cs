using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Game : Form
    {
        public Game(string Who)
        {
            InitializeComponent();
            Settings settings = new Settings();
            UserOneName.Text = settings.GetPlayerOneName();
            UserTwoName.Text = settings.GetPlayerTwoName();
            if (Who == "Computer")
            {
                bool AI = true; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            StartForm start = new StartForm();
            start.ShowDialog();
            this.Close();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
           
        }
    }
}
