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
            Closepicture();
            int Round = 0;
        }
        async Task Closepicture()
        {
            Rock.Hide();
            paper.Hide();
            Scissors.Hide();
            PlayerC.Hide();
            BOTC.Hide();
            PLAYERNAME.Hide();
            BOTNAME.Hide();
            POINTPLAYER.Hide();
            POINTBOT.Hide();
            POINTNUMBERBOT.Visible = true;
            POINTNUMBERPLAYER.Visible = true;
        }
        async Task Time05second() //เอาไว้ Delay คำสั่งเด้อ สู้ๆ!!!!! >0<
        {
            await Task.Delay(500);
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
        async Task Time1second() //เอาไว้ Delay คำสั่งเด้อ สู้ๆ!!!!! >0<
        {
            await Task.Delay(1000);
        }

        WMPLib.WindowsMediaPlayer FS1;
        WMPLib.WindowsMediaPlayer FS2;
        WMPLib.WindowsMediaPlayer Start;
        WMPLib.WindowsMediaPlayer Player2;
        private string PG;
        private readonly string botchoose;

        public string BGF { get; private set; }
        public int x { get; private set; }

        private void SpeakerCute1(string url)
        {
            FS1 = new WMPLib.WindowsMediaPlayer();
            FS1.URL = url;
            FS1.controls.play();
            FS1.settings.volume = 20;
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
        private void pictureBox1_Click(object sender, EventArgs e) //เอาไว้เป่าใหม่ /////ยังไม่เสร๊จเลยยยยยยยยยยยยย
        {

        }
        async Task Replay()//เอาไว้เป่าใหม่อีกครั้ง
        {
            this.PlayerC.Load("C:\\Users\\BungK\\source\\repos\\Rock-Paper-Scissors Game\\Picture\\ANime Male 1.png");
            this.BOTC.Load("C:\\Users\\BungK\\source\\repos\\Rock-Paper-Scissors Game\\Picture\\Himegoto.png");
            Time2second();
            ShowRPSPictureBox();
            VisibleShowAnimation();
            PictureEnabletrue();
            CountDownCC.Enabled = false;
            CountDownCC.Visible = true;
            if (POINTNUMBERBOT.Text == "1")
            {

            }
        }
        async Task AnimationOpen() //Delay For Start Animation
        {
            await Task.Delay(2000);
            if (PictureMain.Visible == false)
            {
                Console.Beep();
                await Task.Delay(2000);
                PictureMain.Visible = true;
            }
        }
        async Task AnimatioClose() //Delay Close Animation
        {
            if (PictureMain.Visible == true)
            {
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
        async Task ShowRPSPictureBox() //โชภาพ ค้อน กรรไกร กระดาษ
        {
            Rock.Show();
            paper.Show();
            Scissors.Show();
        }
        async Task VisibleShowAnimation() //ปิดล่องหนและโช Animation
        {
            Rock.Visible = false;
            paper.Visible = false;
            Scissors.Visible = false;
            if (Rock.Visible == false || paper.Visible == false || Scissors.Visible == false)
            {
                AT2.ShowSync(Rock);
                AT2.ShowSync(paper);
                AT2.ShowSync(Scissors);
            }
        }
        async Task Visibleturerps() //เปิดภาพ ค้อน กรรไกร กระดาษ
        {
            Rock.Show();
            paper.Show();
            Scissors.Show();
            PlayerC.Show();
            BOTC.Show();
            PLAYERNAME.Show();
            BOTNAME.Show();
            POINTPLAYER.Show();
            POINTBOT.Show();
            POINTBOT.Visible = false;
            POINTPLAYER.Visible = false;
            POINTNUMBERBOT.Visible = false;
            POINTNUMBERPLAYER.Visible = false;
            Rock.Visible = false;
            Scissors.Visible = false;
            paper.Visible = false;
            PlayerC.Visible = false;
            BOTC.Visible = false;
            PLAYERNAME.Visible = false;
            BOTNAME.Visible = false;
        }
        async public void CB_Click(object sender, EventArgs e)
        {
            Moveup();
            await AnimationOpen();
            await AnimatioClose();
            PictureMain.Location = new Point(349, 80); //สร้าง Position ใหม่่
            PictureMain.Size = new Size(156, 142);
            PictureMain.Visible = false;
            await Visibleturerps();
            if (PictureMain.Visible == false)
            {
                AT1.ShowSync(PictureMain);
                await Time05second();
                AT2.ShowSync(Rock);
                await Time05second();
                AT2.ShowSync(paper);
                await Time05second();
                AT2.ShowSync(Scissors);
                await Time05second();
                AT2.ShowSync(POINTPLAYER);
                AT2.ShowSync(POINTBOT);
                AT2.ShowSync(POINTNUMBERBOT);
                AT2.ShowSync(POINTNUMBERPLAYER);
                AT1.ShowSync(PlayerC);
                AT1.ShowSync(BOTC);
                AT1.ShowSync(PLAYERNAME);
                AT1.ShowSync(BOTNAME);
                CB.Enabled = false;
                CB.Visible = true;
            }
        }
        async Task PictureEnabletrue()
        {
            Rock.Enabled = true;
            Scissors.Enabled = true;
            paper.Enabled = true;
        }

        async Task PictureEnablefalse()
        {
            Rock.Enabled = false;
            Scissors.Enabled = false;
            paper.Enabled = false;
        }
        async Task CountDownStart() //เริ่มนับถอยหลัง 3-1 ******************************************************
        {
            CountDownCC.Visible = false;
            CountDownCC.Enabled = true;
            if (CountDownCC.Visible == false)
            {
                AT3.ShowSync(CountDownCC);
            }
            SpeakerCute2(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\1-3.wav");
            SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\ComputerData.wav");
            this.CountDownCC.Load("C:\\Users\\BungK\\source\\repos\\Rock-Paper-Scissors Game\\Picture\\Number 1.jpg");
            await Time2second();
            SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\ComputerData.wav");
            this.CountDownCC.Load("C:\\Users\\BungK\\source\\repos\\Rock-Paper-Scissors Game\\Picture\\Number 2.jpg");
            await Time2second();
            SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\ComputerData.wav");
            this.CountDownCC.Load("C:\\Users\\BungK\\source\\repos\\Rock-Paper-Scissors Game\\Picture\\Number 3.jpg");
            await Time1second();
            SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\เป่ายิ้งฉุบ.wav");
            await Time2second();

        }

        public void Calculator()  //Codeing ตัวตัดสิน!****************************************
        {
            //PG - Player
            //BGF - BotGeneration

            if (PG == "Rock" && BGF == "Rock")
            {
                MessageBox.Show("Draw!!!");
            } else if (PG == "Paper" && BGF == "Paper")
            {
                MessageBox.Show("Draw!!!");
            } else if (PG == "Scissors" && BGF == "Scissors")
            {
                MessageBox.Show("Draw!!!");
            } else if (PG == "Rock" && BGF == "Paper")
            {
                MessageBox.Show("You Lose!!!");
            }else if (PG == "Rock" && BGF == "Scissors")
            {
                MessageBox.Show("You Win!!");
            }else if (PG == "Paper" && BGF == "Rock")
            {
                MessageBox.Show("You Win!!");
            }
            else if (PG == "Paper" && BGF == "Scissors")
            {
                MessageBox.Show("You Lose!!!");
            }
            else if (PG == "Scissors" && BGF == "Paper")
            {
                MessageBox.Show("You Win!!!");
            }
            else
            {
                MessageBox.Show("You Lose!!!");
            }
        }
        public async Task RandomNumber() //Codeing For Random.!*******************************************
        {
            Random botrandomnumber = new Random();
            int botchoose = botrandomnumber.Next(1, 4);
            if (botchoose == 1)
            {
                this.BOTC.Load("C:\\Users\\BungK\\source\\repos\\Rock-Paper-Scissors Game\\Picture\\ค้อน.png");
                SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\pop.wav");
                BGF = "Rock";
            }
            else if (botchoose == 2)
            {
                this.BOTC.Load("C:\\Users\\BungK\\source\\repos\\Rock-Paper-Scissors Game\\Picture\\กรรไกร.png");
                SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\pop.wav");
                BGF = "Scissors";
            }
            else if (botchoose == 3)
            {
                this.BOTC.Load("C:\\Users\\BungK\\source\\repos\\Rock-Paper-Scissors Game\\Picture\\กระดาษ.png");
                SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\pop.wav");
                BGF = "Paper";
            }
        }
        public static int Pointplayer(int PP) //บวกคะแนน PLAYER
        {
            return PP + 1;
        }
        public static int Pointbot(int PB)
        {
            return PB + 1; //บวกคะแนน BOT
        }
        async public void Rock_Click(object sender, EventArgs e) //ออกค้อน***********************
        {
            paper.Hide();
            Scissors.Hide();
            SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\pop.wav");
            PictureEnablefalse();
            await Time2second();
            Rock.Visible = true;
            if (Rock.Visible == true)
            {
                AT1.HideSync(Rock);
                this.PlayerC.Load("C:\\Users\\BungK\\source\\repos\\Rock-Paper-Scissors Game\\Picture\\ค้อน.png");
                SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\pop.wav");
                await Time1second();
                await BOTCLOADING();
                await CountDownStart();
                PG = "Rock";
                //ระบบ RandomNumber
                RandomNumber();
                ChackVar();
                //ระบบ RandomNumber
                //ตัวตัดสิน Zone ************************
                if (PG == "Rock" && BGF == "Rock")
                {
                    MessageBox.Show("Draw!!!");
                }
                else if (PG == "Paper" && BGF == "Paper")
                {
                    MessageBox.Show("Draw!!!");
                }
                else if (PG == "Scissors" && BGF == "Scissors")
                {
                    MessageBox.Show("Draw!!!");
                }
                else if (PG == "Rock" && BGF == "Paper")
                {
                    MessageBox.Show("You Lose!!!");
                    Pointbot();
                }
                else if (PG == "Rock" && BGF == "Scissors")
                {
                    MessageBox.Show("You Win!!");
                }
                else if (PG == "Paper" && BGF == "Rock")
                {
                    MessageBox.Show("You Win!!");
                }
                else if (PG == "Paper" && BGF == "Scissors")
                {
                    MessageBox.Show("You Lose!!!");
                }
                else if (PG == "Scissors" && BGF == "Paper")
                {
                    MessageBox.Show("You Win!!!");
                }
                else
                {
                    MessageBox.Show("You Lose!!!");
                }
                //ตัวตัดสิน Zone ************************
                Replay();

            }
        }
        async Task BOTCLOADING()
        {
            this.BOTC.Load("C:\\Users\\BungK\\source\\repos\\Rock-Paper-Scissors Game\\Picture\\Question.jpg");
            SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\pop.wav");
        }
        async private void Scissors_Click(object sender, EventArgs e) //ออกกรรไกร****************
        {
            Rock.Hide();
            paper.Hide();
            SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\pop.wav");
            PictureEnablefalse();
            await Time2second();
            Scissors.Visible = true;
            if (Scissors.Visible == true)
            {
                AT1.HideSync(Scissors);
                this.PlayerC.Load("C:\\Users\\BungK\\source\\repos\\Rock-Paper-Scissors Game\\Picture\\กรรไกร.png");
                SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\pop.wav");
                await Time1second();
                await BOTCLOADING();
                await CountDownStart();
                PG = "Scissors";
                //ระบบ RandomNumber
                RandomNumber();
                //ระบบ RandomNumber
                //ตัวตัดสิน Zone ************************
                Calculator();
                //ตัวตัดสิน Zone ************************
            }
        }

        async private void paper_Click(object sender, EventArgs e) //ออกกระดาษ******************************
        {
            Rock.Hide();
            Scissors.Hide();
            SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\pop.wav");
            PictureEnablefalse();
            await Time2second();
            paper.Visible = true;
            if (paper.Visible == true)
            {
                AT1.HideSync(paper);
                this.PlayerC.Load("C:\\Users\\BungK\\source\\repos\\Rock-Paper-Scissors Game\\Picture\\กระดาษ.png");
                SpeakerCute1(@"C:\Users\BungK\source\repos\Rock-Paper-Scissors Game\Music\Sound\pop.wav");
                await Time1second();
                await BOTCLOADING();
                await CountDownStart();
                PG = "Paper";
                //ระบบ RandomNumber
                RandomNumber();
                //ระบบ RandomNumber
                //ตัวตัดสิน Zone ************************
                Calculator();
                //ตัวตัดสิน Zone ************************
            }
        }
        //สร้างระบบเกม****************************************************************************************************
        //โดยที่ 1 = Rock / 2 = Scissors / 3 = Paper //***
        async Task ChackVar() //ทดสอบว่าตัวแปรทำงานหรือไม่?*****************************************
        {
            if (BGF == "Rock")
            {
                Console.Beep();
            }
            if (BGF == "Paper")
            {
                Console.Beep();
                Console.Beep();
            }
            if (BGF == "Scissors")
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }
        }

        private void CountDownCC_Click_1(object sender, EventArgs e)
        {

        }
    }
}
//            if (PG == "Rock" && BGF == "Rock")
//            {
//                MessageBox.Show("Draw");
//            }
//            else if (PG == "Rock" && BGF == "Scissors")
//            {
//                MessageBox.Show("Win");
//            }
//            else if (PG == "Rock" && BGF == "Paper")
//            {
//                MessageBox.Show("Lose");
//            }
//

// นี่จจากบุ๊งเมื่อ 10 ชั่วโมงที่แล้วนะ หวัดดีบุ๊งในอีก 10 ชั่วโมงข้างหน้าพอดีเราแก้ฟังชั่นให้แล้ว
// ทืี่เหลือนายต้องไปทำ ให้ BOT
// เพิ่มคะแนนให้เวลาชนะหรือแพ้นะ จุๆ เดาว่าต้องใช้คำว่า if (POINTNUMBER == 1) แล้วให้เปลี่ยนตัวอักษรคะแนนนะ ไปเล่น Unturned ละ เต็มเท่าไรแล้วแต่นายเลย
// แก้ตรง private void pictureBox1_Click(object sender, EventArgs e) นี้ด้วยยังทำไม่เสร๊จบัคกระจุยเลยนะ