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
        private string url;

        private void Form1_Load(object sender, EventArgs e) //C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Tiny Little Adiantum.wav
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.URL = url;
            Player.controls.play();
            Player.settings.volume = 20;
            Player(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Tiny Little Adiantum.wav");
        }
    }
}