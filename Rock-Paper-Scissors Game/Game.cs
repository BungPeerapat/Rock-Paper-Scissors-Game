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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            CB.BackColor = Color.FromArgb(0, 0, 0, 0);
            PlayFile2(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Tiny Little Adiantum Pinno.wav");
            AT1.HideSync(PictureMain);
            Animation1();
            
        }
        async Task Time2second() //เอาไว้ Delay คำสั่งเด้อ สู้ๆ!!!!! >0<
        {
            await Task.Delay(2000);
        }
        async Task Animation1() //เอาไว้ Delay คำสั่งเด้อ สู้ๆ!!!!! >0<
        {
            await Task.Delay(3000);
            if(PictureMain.Visible == false)
               AT1.ShowSync(PictureMain);
            else
               AT1.HideSync(PictureMain);
        }

        WMPLib.WindowsMediaPlayer FS1;
        WMPLib.WindowsMediaPlayer FS2;
        WMPLib.WindowsMediaPlayer Start;
        WMPLib.WindowsMediaPlayer Player2;
        private void SpeakerCute1(string url)
        {
            FS1 = new WMPLib.WindowsMediaPlayer();
            FS1.URL = url;
            FS1.controls.play();
            FS1.settings.volume = 150;
        }

        private void LetStartText(string url)
        {

        }
        private void SpeakerCute2(string url)
        {
            FS2 = new WMPLib.WindowsMediaPlayer();
            FS2.URL = url;
            FS2.controls.play();
            FS2.settings.volume = 150;
        }
        private void PlayFile2(string url)
        {
            Player2 = new WMPLib.WindowsMediaPlayer();
            Player2.URL = url;
            Player2.controls.play();
            Player2.settings.setMode("loop", true);
            Player2.settings.volume = 5;
        }

        private void StartSound(string url)
        {
            Start = new WMPLib.WindowsMediaPlayer();
            Start.URL = url;
            Start.controls.play();
            Start.settings.setMode("loop", false);
            Start.settings.volume = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BGGAMESTART_Click(object sender, EventArgs e)
        {
            
        }

        private void CB1_Click(object sender, EventArgs e)
        {

        }

        private void EXIT_Click_1(object sender, EventArgs e)
        {
            Player2.close();
            this.Close();
            Form1 Menu = new Form1();
            Menu.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
