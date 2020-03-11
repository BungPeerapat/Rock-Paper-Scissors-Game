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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            CB1.BackColor = Color.FromArgb(0, 0, 0, 0);
            for (int i = 0; i < 3; i++)
            {
                Console.Beep();
                System.Threading.Thread.Sleep(1000);
            }
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

        private void EXITBUTTON_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Menu = new Form1();
            Menu.Show();
        }
    }
}
