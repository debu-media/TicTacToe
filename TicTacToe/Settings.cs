using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Settings
    {
        readonly string FilePath = @"settings.conf";
       
        public string[] ReadSettingsFile()
        {
            if (!File.Exists(FilePath)){
                string[] settings = { "Player One", "Player Two", "0" };
                System.IO.File.WriteAllLines(@"settings.conf", settings);
            }
            string[] lines = System.IO.File.ReadAllLines(FilePath);    
            return lines; 
        }
        public string GetPlayerOneName()
        {
            string [] lines = ReadSettingsFile();
            string PlayerOneName= lines[0];
            return PlayerOneName; 
        }
        public string GetPlayerTwoName()
        {
            string[] lines = ReadSettingsFile();
            string PlayerTwoName = lines[1];
            return PlayerTwoName;
        }
        public int Count()
        {
            string[] lines = ReadSettingsFile();
            int Count = Convert.ToInt32(lines[2]);
            return Count; 
        }
    }
}
