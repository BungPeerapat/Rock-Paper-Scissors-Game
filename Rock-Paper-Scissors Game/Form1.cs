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
using System.Threading;

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
            PlayFile(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Tiny Little Adiantum.wav");
        }

        private void EXITBUTTON_Click(object sender, EventArgs e)
        {
            Close();
        }

        WMPLib.WindowsMediaPlayer STARTSOUNDFIRST;
        private void STARTSOUND1(string url)
        {
            STARTSOUNDFIRST = new WMPLib.WindowsMediaPlayer();
            STARTSOUNDFIRST.URL = url;
            STARTSOUNDFIRST.controls.play();
            STARTSOUNDFIRST.settings.volume = 20;
        }

        private void STARTBUTTON_Click(object sender, EventArgs e)
        {
            MessageBox.Show("if you Ready Please press : OK");
            Player.close();
            STARTSOUND1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\จัดให้ค่า.wav");
            for (int time = 0; time < 1; time++)
            {
                Thread.Sleep(1000);
                for (int Delay = 0; Delay < 1; Delay++)
                {
                    Thread.Sleep(2000);
                    Game GameStart = new Game();
                    GameStart.Show();
                    this.Hide();
                }
            }
        }

        private void RPSG_Click(object sender, EventArgs e)
        {

        }

        private void DelayforStartGame_Tick(object sender, EventArgs e)
        {

        }
    }
}