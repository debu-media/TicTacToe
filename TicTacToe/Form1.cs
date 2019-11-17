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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            Settings settings = new Settings();
            OnePlayerNameTXT.Text = settings.GetPlayerOneName();
            TwoPlayerNameTXT.Text = settings.GetPlayerTwoName();
            int ProgramCount = settings.Count();
            ProgramCount++;
        }

        private void HumanVsHuman_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game StartGame = new Game("Human");
            StartGame.ShowDialog(); 
            this.Close();
        }


        private void HumanVsComputer_Click_1(object sender, EventArgs e)
        {
            Game StartGame = new Game("Computer");
            StartGame.Show();
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            ClearData();
            CreditsLBL.Show();

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            ClearData();
            OnePlayerNameTXT.Show();
            TwoPlayerNameTXT.Show();
            Save.Show();
  
        }

        private void ClearData()
        {
            HumanVsComputer.Hide();
            HumanVsHuman.Hide();
            Credits.Hide();
            Settings.Hide();
            Back.Show();
        }
        private void BackToMenu()
        {
            HumanVsComputer.Show();
            HumanVsHuman.Show();
            Credits.Show();
            Settings.Show();
            Back.Hide();
            if (!CreditsLBL.IsDisposed)
            {
                CreditsLBL.Hide();
            }
            if (!OnePlayerNameTXT.IsDisposed)
            {
                OnePlayerNameTXT.Hide();
                TwoPlayerNameTXT.Hide();
                Save.Hide();
                if (!Save.Enabled)
                {
                    Save.Enabled = true;
                    Save.Text = "Save";
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            BackToMenu();
        }

        private void Save_Click(object sender, EventArgs e)
        {
             string PlayerOneName = OnePlayerNameTXT.Text;
             string PlayerTwoName = TwoPlayerNameTXT.Text;
            string[] settings = { PlayerOneName, PlayerTwoName, "99" };
            System.IO.File.WriteAllLines(@"settings.conf", settings);
            Save.Text = "Saved !";
            Save.Enabled = false;
            Back.Focus();
        }
    }
}
