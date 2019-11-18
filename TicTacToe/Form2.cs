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
            Move.Text = "X";
            if (Who == "Computer")
            {
                bool AI = true;
                UserTwoName.Text = "Computer";
            }
        }
        private bool Winner()
        {
            bool Winner = false;
            if(OneOne.Text == OneTwo.Text && OneOne.Text == OneThree.Text && OneOne.Text !="" || TwoOne.Text== TwoTwo.Text && TwoOne.Text == TwoThree.Text && TwoOne.Text !="" || ThreeOne.Text == ThreeTwo.Text && ThreeOne.Text==ThreeThree.Text && ThreeOne.Text !="" || OneOne.Text == TwoTwo.Text && OneOne.Text==ThreeThree.Text && OneOne.Text!="" || OneThree.Text == TwoTwo.Text && OneThree.Text == ThreeOne.Text && ThreeOne.Text != "" || OneOne.Text == TwoOne.Text && OneOne.Text == ThreeOne.Text && OneOne.Text != "" || OneTwo.Text == TwoTwo.Text && OneTwo.Text == ThreeTwo.Text && OneTwo.Text != "" || OneThree.Text == TwoThree.Text && OneThree.Text == ThreeThree.Text && OneThree.Text != "")
            {
                Winner = true; 
            }
            return Winner;
        }
        private string NewMove(string Name)
        {
            if (Move.Text == "X") { Move.Text = "O"; } else { Move.Text = "X"; }
            if (Winner())
            {
                this.Hide();
            }
            return Name;
            
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

        private void OneOne_Click(object sender, EventArgs e)
        {
           OneOne.Text=NewMove(Move.Text);
           OneOne.Enabled = false; 
        }

        private void OneTwo_Click(object sender, EventArgs e)
        {
            OneTwo.Text = NewMove(Move.Text);
            OneTwo.Enabled = false;
        }

        private void OneThree_Click(object sender, EventArgs e)
        {
            OneThree.Text = NewMove(Move.Text);
            OneThree.Enabled = false;
        }

        private void TwoOne_Click(object sender, EventArgs e)
        {
            TwoOne.Text = NewMove(Move.Text);
            TwoOne.Enabled = false;
        }

        private void TwoTwo_Click(object sender, EventArgs e)
        {
            TwoTwo.Text = NewMove(Move.Text);
            TwoTwo.Enabled = false;
        }

        private void TwoThree_Click(object sender, EventArgs e)
        {
            TwoThree.Text = NewMove(Move.Text);
            TwoThree.Enabled = false;
        }

        private void ThreeOne_Click(object sender, EventArgs e)
        {
            ThreeOne.Text = NewMove(Move.Text);
            ThreeOne.Enabled = false;
        }

        private void ThreeTwo_Click(object sender, EventArgs e)
        {
            ThreeTwo.Text = NewMove(Move.Text);
            ThreeTwo.Enabled = false;
        }

        private void ThreeThree_Click(object sender, EventArgs e)
        {
            ThreeThree.Text = NewMove(Move.Text);
            ThreeThree.Enabled = false;
        }
    }
}
