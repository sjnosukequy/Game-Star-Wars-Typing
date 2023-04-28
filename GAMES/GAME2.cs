using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Collections;
using System.Drawing.Text;
using Game.LOSESCREEN;

namespace Game.GAMES
{
    public partial class GAME2 : Form
    {
        //BG image
        //Image BG = Image.FromFile("BG\\BG1.jpg");

        //RANDOM
        Random rnd = new Random(Guid.NewGuid().GetHashCode());

        //CHAR PEDRO
        CHAR Pedro;
        int ANIPED = 1;
        //CHAR STORM
        CHAR Storm;
        int ANISTR = 1;
        //BUTTONS
        BUTTONS BUTTLEFT1;
        BUTTONS BUTTRIGHT1;
        List<string> LBUTTWR = new List<string>();
        List<string> RBUTTWR = new List<string>();
        List<string> LBUTTR = new List<string>();
        List<string> RBUTTR = new List<string>();
        List<int> INPUT1 = new List<int>();
        List<int> INPUT2 = new List<int>();
        List<int> RES1 = new List<int>();
        List<int> RES2 = new List<int>();
        int Correct1 = 0;
        int Correct2 = 0;
        bool FSTEP1 = false;
        bool FSTEP2 = false;
        //LOADING
        LOADING Loading;
        //SETTINGS
        int Mtime = 3000;
        int LoadTime = 0;
        //FIRST
        List<int> FIRST = new List<int>();
        //MISC
        int ReAniTime = 0;
        bool FResult = true;
        //HEALTH
        int MAXHEALTH;
        HEALTH Health1;
        HEALTH Health2;
        bool HIT1 = false;
        bool HIT2 = false;
        int DMG;
        //BULLET
        Image Bullet;
        Image Bullet2;
        Bitmap TheBULL;
        List<Bitmap> Bullets = new List<Bitmap>();

        //PAUSE
        bool PAUSE = true;
        int PAUSEIDX = 3;
        int PAUSECOUNTER = 0;
        bool CONT = true;

        //FONT
        PrivateFontCollection FONTS = new PrivateFontCollection();
        List<String> ADDRFONTS = new List<string>();

        //ENDING
        int ED;

        //MAIN
        private Form MAIN;
        private bool AGAIN = false;
        public GAME2(int HEALTH, int dmg, Form Main)
        {
            InitializeComponent();
            MAXHEALTH = HEALTH;
            DMG = dmg;
            MAIN = Main;
            this.panel1.DBUFFER();
            this.panel2.DBUFFER();
            SetUP();
        }
        private void SetUP()
        {
            //this.BackgroundImage = BG;
            this.EXITBUTT.Hide();
            this.CONTBUTT.Hide();
            Pedro = new CHAR(-100, 40, 200, "CHAR\\PEDRO", "*.png");
            Storm = new CHAR(800, 40, 200, "CHAR\\STORM", "*.png");
            BUTTLEFT1 = new BUTTONS(0, 0, 70, "BUTTONS\\P1 Buttons", "*.png");
            BUTTRIGHT1 = new BUTTONS(690, 0, 70, "BUTTONS\\P2 Buttons", "*.png");
            LBUTTR=Directory.GetFiles("BUTTONS\\P1 green", "*.png").ToList();
            LBUTTWR=Directory.GetFiles("BUTTONS\\P1 red", "*.png").ToList();
            RBUTTR=Directory.GetFiles("BUTTONS\\P2 green", "*.png").ToList();
            RBUTTWR=Directory.GetFiles("BUTTONS\\P2 red", "*.png").ToList();
            Bullet = Image.FromFile("MISC\\bullet.png");
            Bullet2 = Image.FromFile("MISC\\bullet1.png");
            Health1 = new HEALTH(0, 0, MAXHEALTH, Color.LawnGreen);
            Health2 = new HEALTH(0, 0, MAXHEALTH, Color.LawnGreen);
            int n = rnd.Next(3, 10);
            BUTTLEFT1.Setup2(n,ref RES1);
            BUTTRIGHT1.Setup2(n, ref RES2);
            this.ActiveControl = this.label1;
            Loading = new LOADING(0, 0, Mtime, Color.Violet);
            ADDRFONTS = Directory.GetFiles("MISC", "*ttf").ToList();
            foreach (string i in ADDRFONTS)
                FONTS.AddFontFile(i);
            this.COUNTER.Font = new Font(FONTS.Families[1], this.COUNTER.Font.Size, this.COUNTER.Font.Style);
            this.CONTBUTT.Font = new Font(FONTS.Families[1], this.CONTBUTT.Font.Size, this.CONTBUTT.Font.Style);
            this.EXITBUTT.Font = new Font(FONTS.Families[1], this.EXITBUTT.Font.Size, this.EXITBUTT.Font.Style);
        }
        //timer
        private void Timer(object sender, EventArgs e)
        {
            if (PAUSE)
            {
                this.COUNTER.Show();
                if (CONT == true)
                {
                    this.EXITBUTT.Hide();
                    this.CONTBUTT.Hide();
                    this.COUNTER.Refresh();
                }
            }
            else
            {
                ENABLEFOCUS(true);
                CONT = false;
                this.COUNTER.Hide();
                PAUSEIDX = 3;
                PAUSECOUNTER = 0;
                if (!END())
                {
                    this.panel2.Refresh();
                    this.LOADINGBOX.Refresh();
                    this.HEALTHBAR1.Refresh();
                    this.HEALTHBAR2.Refresh();
                    CHECKKEYS1();
                    CHECKKEYS2();
                    if (!Result())
                        LoadTime += 20;
                    BULLET1();
                    this.panel1.Refresh();
                }
                else
                {
                    this.timer1.Stop();
                    this.Hide();
                    AGAIN = true;
                    LOSEGAME2 ps = new LOSEGAME2(ED,MAXHEALTH,DMG,MAIN);
                    ps.ShowDialog();
                    this.Dispose();
                }
            }
        }
        //Refreshes
        private void LOADREF(object sender,PaintEventArgs e)
        {
            Loading.Draw(e, LoadTime);
        }
        private void HEALTHREF1(object sender, PaintEventArgs e)
        {
            if (HIT1 == true)
            {
                Health1.Draw(e, DMG);
                HIT1 = false;
            }
            else
                Health1.Draw(e);
        }
        private void HEALTHREF2(object sender, PaintEventArgs e)
        {
            if (HIT2 == true)
            {
                Health2.Draw(e, DMG);
                HIT2 = false;
            }
            else
                Health2.Draw(e);
        }
        private void PanelREF(object sender,PaintEventArgs e)
        {
            if (Bullets.Count > 0)
            {
                int len = Bullets.Count();
                for (int i = 0; i < len; i++)
                {
                    int l = 0;
                    int k = rnd.Next(140, 750);
                    if (k > 180 && k < 700)
                        l = rnd.Next(-50, 50);
                    else
                        l = rnd.Next(-5, 5);
                    e.Graphics.DrawImage(Bullets[i], k, 60 + l);
                }
            }

            if (ANIPED == 1)
                Pedro.IdleAni(e);
            else if (ANIPED == 2)
                Pedro.Attack(e);
            else if (ANIPED == 3)
                Pedro.DMG(e);

            if (ANISTR == 1)
                Storm.IdleAni(e);
            else if (ANISTR == 2)
                Storm.Attack(e);
            else if (ANISTR == 3)
                Storm.DMG(e);

        }
        private void BUTTREF(object sender,PaintEventArgs e)
        {
            BUTTLEFT1.Draw(e);
            BUTTRIGHT1.Draw(e);
        }
        private void WAIT(object sender,PaintEventArgs e)
        {
            if (PAUSECOUNTER % 1000 == 0)
            {
                this.COUNTER.Text = PAUSEIDX.ToString();
                PAUSEIDX--;
            }
            PAUSECOUNTER += 20;
            if (PAUSEIDX == -1)
                PAUSE = false;
        }
        //KEYS
        private void KEYDW(object sender, PreviewKeyDownEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                {
                    INPUT1.Add(0);
                    FSTEP1 = true;
                    break;
                }
                case Keys.A:
                {
                        FSTEP1 = true;
                        INPUT1.Add(1);
                        break;
                }
                case Keys.S:
                {
                        FSTEP1 = true;
                        INPUT1.Add(2);
                        break;
                }
                case Keys.D:
                {
                        FSTEP1 = true;
                        INPUT1.Add(3);
                        break ;
                }
                case Keys.Up:
                    {
                        FSTEP2 = true;
                        INPUT2.Add(0);
                        break;
                    }
                case Keys.Left:
                    {
                        FSTEP2 = true;
                        INPUT2.Add(1);
                        break;
                    }
                case Keys.Down:
                    {
                        FSTEP2 = true;
                        INPUT2.Add(2);
                        break;
                    }
                case Keys.Right:
                    {
                        FSTEP2 = true;
                        INPUT2.Add(3);
                        break;
                    }
                case Keys.Escape:
                    {
                        PAUSE = true;
                        this.EXITBUTT.Show();
                        this.CONTBUTT.Show();
                        break;
                    }
            }
        }
        private void ENABLEFOCUS(bool flag)
        {
            if (flag)
                this.label1.Focus();
            else
                this.LOADINGBOX.Focus();
        }
        private void CHECKKEYS1()
        {
            if(INPUT1.Count() > RES1.Count())
            {

            }
            else if (INPUT1.Count() > 0 && FSTEP1 == true)
            {
                int idx = INPUT1.Count() - 1;
                if (INPUT1[idx] == RES1[idx])
                {
                    BUTTLEFT1.Buttons[idx] = LBUTTR[RES1[idx]];
                    Correct1++;
                }
                else
                {
                    BUTTLEFT1.Buttons[idx] = LBUTTWR[RES1[idx]];
                }

                if (INPUT1.Count() == RES1.Count())
                    FIRST.Add(1);
                FSTEP1 = false;
            }
        }
        private void CHECKKEYS2()
        {
            if(INPUT2.Count() > RES2.Count())
            {

            }
            else if (INPUT2.Count() > 0 && FSTEP2 == true)
            {
                int idx = INPUT2.Count() - 1;
                if (INPUT2[idx] == RES2[idx])
                {
                    BUTTRIGHT1.Buttons[idx] = RBUTTR[RES2[idx]];
                    Correct2++;
                }
                else
                    BUTTRIGHT1.Buttons[idx] = RBUTTWR[RES2[idx]];

                if (INPUT2.Count() == RES2.Count())
                    FIRST.Add(2);
                FSTEP2 = false;
            }
        }
        //RESULT
        private bool Result()
        {
            ReAniTime += 20;
            if (FIRST.Count() >= 1)
            {
                if (FResult == true)
                {
                    ReAniTime = 0;
                }
                if (ReAniTime != 1000)
                {
                    ENABLEFOCUS(false);
                    if (FIRST[0] == 1 && FResult == true)
                    {
                        if (Correct2 > Correct1)
                        {
                            FIRST[0] = 2;
                            ANIPED = 3;
                            ANISTR = 2;
                            HIT1 = true;
                        }
                        else
                        {
                            ANIPED = 2;
                            ANISTR = 3;
                            HIT2 = true;
                        }
                    }
                    else if ((FIRST[0] == 2 && FResult == true))
                    {
                        if (Correct1 > Correct2)
                        {
                            FIRST[0] = 1;
                            ANIPED = 2;
                            ANISTR = 3;
                            HIT2 = true;
                        }
                        else
                        {
                            ANIPED = 3;
                            ANISTR = 2;
                            HIT1 = true;
                        }
                    }
                    FResult = false;
                }
                else
                {
                    Reset();
                }
                return true;
            }
            else
            {
                if (ReAniTime == Mtime + 1000)
                {
                    HIT2 = true;
                    HIT1 = true;
                    Reset();
                }
                return false;
            }
        }
        private void Reset()
        {
            LoadTime = 0;
            ReAniTime = 0;
            ANIPED = 1;
            ANISTR = 1;
            FIRST.Clear();
            RES1.Clear();
            RES2.Clear();
            INPUT1.Clear();
            INPUT2.Clear();
            int n = rnd.Next(3, 10);
            BUTTLEFT1.Setup2(n, ref RES1);
            BUTTRIGHT1.Setup2(n, ref RES2);
            FResult = true;
            Correct1 = 0;
            Correct2 = 0;
            Bullets.Clear();
            ENABLEFOCUS(true);
        }
        private bool END()
        {
            if (Health1.Health <= 0 && Health2.Health <= 0)
            {
                ED = 3;
                return true;
            }
            else if (Health1.Health <= 0)
            {
                if (ReAniTime == 980)
                {
                    ED = 2;
                    return true;
                }
            }
            else if (Health2.Health <= 0)
            {
                if (ReAniTime == 980)
                {
                    ED = 1;
                    return true;
                }
            }
            return false;
        }
        //BULLET
        private void BULLET1()
        {
            if(FIRST.Count() > 0)
            {
                if(HIT1)
                {
                    TheBULL = new Bitmap(Bullet, 150, 150);
                }
                else if(HIT2)
                {
                    TheBULL = new Bitmap(Bullet2, 150, 150);
                }
                if (Bullets.Count() < 4)
                {
                    int k = rnd.Next(1, 5);
                    for (int i = 0; i < k; i++)
                    {
                        Bullets.Add(TheBULL);
                    }
                }
            }
        }

        private void EXITBUTT_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.MAIN.Show();
            this.MAIN.Enabled = true;
            AGAIN = true;
            this.Dispose();
        }

        private void CONTBUTT_Click(object sender, EventArgs e)
        {
            CONT = true;
        }

        private void GAME2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (AGAIN == false)
                MAIN.Dispose();
        }
    }
}
