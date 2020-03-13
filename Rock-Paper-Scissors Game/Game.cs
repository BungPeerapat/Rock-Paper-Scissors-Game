﻿using System;
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
using System.Drawing.Imaging;
namespace Rock_Paper_Scissors_Game
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            CB.BackColor = Color.FromArgb(0, 0, 0, 0);
            PlayFile2(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Tiny Little Adiantum Pinno.wav");

        }

        async Task Time5second() //เอาไว้ Delay คำสั่งเด้อ สู้ๆ!!!!! >0<
        {
            await Task.Delay(5000);
        }
        async Task Time01second() //เอาไว้ Delay คำสั่งเด้อ สู้ๆ!!!!! >0<
        {
            await Task.Delay(10);
        }
        async Task Time2second() //เอาไว้ Delay คำสั่งเด้อ สู้ๆ!!!!! >0<
        {
            await Task.Delay(2000);
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
        async Task AnimationOpen() //Delay For Start Animation
        {
            await Task.Delay(2000);
            if (PictureMain.Visible == false)
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
                AT1.ShowSync(PictureMain);
                await Task.Delay(2000);
                PictureMain.Visible = true;
            }
        }
        async Task AnimatioClose() //Delay Close Animation
        {
            if (PictureMain.Visible == true)
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
                AT1.HideSync(PictureMain);
                await Task.Delay(2000);
                PictureMain.Visible = true;
                PictureMain.Hide();
            }
        }
        async Task Moveup() //รอให้ CD เลื่อนขึ้นจนเสร็จ
        {
            for (int PositionTop = 0; PositionTop < 20;)
            {
                CB.Top -= 5;
                await Time01second();
            }
        }
        async private void CB_Click(object sender, EventArgs e)
        {
            Moveup();
            await AnimationOpen();
            await AnimatioClose();
            PictureMain.Location = new Point(339, 12); //สร้าง Position ใหม่่
            PictureMain.Size = new Size(245, 172);
            PictureMain.Show();

        }

        //ไปแต่งฉากตอนที่ PictureMain เปลี่ยนจุดแล้วให้มันเปิดสวยๆหน่อย เอา Effect เดิมก็ได้นะบุ๊งในอีก 10 ชั่วโมงข้างหน้า ^0^
    }
}
