using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer BGMUSIC = new System.Media.SoundPlayer(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Tiny Little Adiantum.wav");
            BGMUSIC.PlayLooping();
        }
    }
}
