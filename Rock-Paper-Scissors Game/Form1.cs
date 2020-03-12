using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Rock_Paper_Scissors_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WMPLib.WindowsMediaPlayer Player;
        private void PlayFile(string url)
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.URL = url;
            Player.controls.play();
            Player.settings.setMode("loop", true);
            Player.settings.volume = 5;
        }

        private void Form1_Load(object sender, EventArgs e) //C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Tiny Little Adiantum.wav
        {
            PlayFile(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Tiny Little Adiantum Pinno.wav");
        }

        private void EXITBUTTON_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void STARTBUTTON_Click(object sender, EventArgs e)
        {
            MessageBox.Show("if you Ready Please press : OK");
            PlayFile(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\จัดให้ค่า.wav");
            Player.close();
            Game GameStart = new Game();
            GameStart.Show();
            this.Hide();
        }
    }
}