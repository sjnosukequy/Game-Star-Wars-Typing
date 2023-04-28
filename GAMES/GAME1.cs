using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;
using System.Reflection.Emit;
using Game.LOSESCREEN;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Game.GAMES
{
    public partial class GAME1 : Form
    {
        //WAIT
        bool Iswait = true;
        int waitimer = 0;
        int countDown = 3;
        bool CONT = true;

        //IS OVER
        bool ISOVER = false;

        //random
        Random rnd = new Random();

        //BG
        Image image = Image.FromFile("BG\\BG1.jpg");

        //P1Buttons
        List<string> IMGBUTTONS = new List<string>();
        List<string> IMGBUTTONSRIGHT = new List<string>();
        List<string> IMGBUTTONSWRONG = new List<string>();
        Graphics DB;
        List<BUTTONS> P1BUTTONS = new List<BUTTONS>();
        bool BUTTFLAG = true;

        //POINTS
        float points = 0;
        int bonus = 0;
        int correct = 0;
        float bstep = 0;
        bool PEnd = false;
        bool isbonus = true;
        //Timer
        int timer;
        int CKtimer = 0;
        int Mtime = 3000;

        //keyboard inputs
        List<int> INPUTS = new List<int>();
        int NUINPUTS = 0;

        //DECODE
        List<int> DECODE = new List<int>();

        //STEP
        int FSTEP = 0;

        //LOADING
        LOADING Loading;

        //CHAR
        CHAR DARTH;
        CHAR STORM;
        int Health = 100;
        bool HIT = false;
        int DMG = 10;
        int VAniType = 0;
        int SAniType = 0;
        bool IsVder = false;
        bool ISstorm = true;
        Image bullet = Image.FromFile("MISC\\bullet.png");
        bool IShoot = false;
        float distance = 130;
        float height = 0;

        //FONT
        PrivateFontCollection FONTS = new PrivateFontCollection ();
        List<String> ADDRFONTS = new List<string>();

        //DIFFICULTY
        int dif;

        //MAIN FROM
        private Form MAIN;
        bool AGAIN = false;
        public GAME1(int dif, Form Main)
        {
            InitializeComponent();
            setup();
            this.dif = dif;
            this.MAIN = Main;
        }
        private void setup()
        {
            this.EXITBUTT.Hide();
            this.CONTBUTT.Hide();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = image;
            IMGBUTTONS = Directory.GetFiles("BUTTONS\\P1 Buttons", "*.png").ToList();
            IMGBUTTONSWRONG = Directory.GetFiles("BUTTONS\\P1 red", "*.png").ToList();
            IMGBUTTONSRIGHT = Directory.GetFiles("BUTTONS\\P1 green", "*.png").ToList();
            DARTH = new CHAR(30, 380, 200, "CHAR\\VADER", "*.png");
            STORM = new CHAR(770, 383, 200, "CHAR\\STORM", "*.png");
            DB = this.CreateGraphics();
            Loading = new LOADING(80, 50, Mtime, Color.Violet);
            //BUTTCHANGE();
            ADDRFONTS = Directory.GetFiles("MISC", "*ttf").ToList();
            foreach (string i in ADDRFONTS)
                FONTS.AddFontFile(i);
            this.POINTS.Font = new Font(FONTS.Families[3], this.POINTS.Font.Size + 10, this.POINTS.Font.Style);
            this.BONUS.Font = new Font(FONTS.Families[1], this.BONUS.Font.Size + 15, this.BONUS.Font.Style);
            this.Waitlabel.Font = new Font(FONTS.Families[1], this.Waitlabel.Font.Size, this.Waitlabel.Font.Style);
            this.CONTBUTT.Font = new Font(FONTS.Families[1], this.CONTBUTT.Font.Size, this.CONTBUTT.Font.Style);
            this.EXITBUTT.Font = new Font(FONTS.Families[1], this.EXITBUTT.Font.Size, this.EXITBUTT.Font.Style);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Iswait == true)
            {
                this.Waitlabel.Show();
                if (CONT)
                {
                    this.EXITBUTT.Hide();
                    this.CONTBUTT.Hide();
                    if (waitimer % 600 == 0)
                    {
                        this.Waitlabel.Text = countDown.ToString();
                        countDown--;
                    }
                    if (countDown == -1)
                    {
                        Iswait = false;
                        this.Waitlabel.Hide();
                    }
                    waitimer += 20;
                }
            }
            else
            {
                waitimer = 0;
                countDown = 3;
                this.Waitlabel.Text = Convert.ToString(3);
                CONT = false;
                ISOVER = END();
                if (!ISOVER)
                {
                    BUTTSHOW(BUTTFLAG);
                    if (CKtimer == Mtime)
                    {
                        PEnd = true;
                        if (INPUTS.Count() == 0)
                        {
                            HIT = true;
                            NUINPUTS++;
                        }
                        else if (INPUTS.Count() < DECODE.Count() && INPUTS.Count() > 0)
                        {
                            HIT = true;
                            NUINPUTS++;
                        }
                        if (NUINPUTS == 1)
                        {
                            Health -= DMG * (DECODE.Count() - INPUTS.Count());
                            Console.WriteLine("HEALTH " + Health);
                        }
                        RESULT();
                    }
                    else
                    {
                        if (INPUTS.Count() == DECODE.Count())
                        {
                            PEnd = true;
                            RESULT();
                        }
                        else
                        {
                            EnableBUT(true);
                            VAniType = 0;
                            SAniType = 0;

                            ISstorm = true;
                            RectangleF b = new RectangleF(STORM.P1X, STORM.P1Y, 2 * STORM.Size, STORM.Size);
                            this.Invalidate(Rectangle.Round(b));

                            IsVder = true;
                            RectangleF a = new RectangleF(DARTH.P1X, DARTH.P1Y, 2 * DARTH.Size, DARTH.Size);
                            this.Invalidate(Rectangle.Round(a));

                            CKtimer += 20;
                            Loading.Draw(DB, CKtimer);
                        }
                    }
                    RIGHTORWRONG(PEnd);
                }
                else
                {
                    this.timer1.Stop();
                    this.Hide();
                    AGAIN = true;
                    LOSE SP = new LOSE(dif, MAIN);
                    SP.ShowDialog();
                    this.Dispose();
                }
            }
        }

        //BUTTONS FUNC
        private void BUTTSHOW(bool Buttflag)
        {
            if(Buttflag)
            {
                Image buttons;
                int len = rnd.Next(3, dif);
                int width = 80;
                P1BUTTONS.Clear();
                for (int i = 0; i < len; i++)
                {
                    int rand = rnd.Next(0, 13);
                    BUTTONS a = new BUTTONS(IMGBUTTONS[rand], width, rand);
                    P1BUTTONS.Add(a);
                    //width += 100;
                    if (i == 9)
                        width = 80;
                    else
                        width += 100;

                }
                for (int i = 0; i < len; i++)
                {
                    buttons = Image.FromFile(P1BUTTONS[i].ADDR);
                    //DB.DrawImage(buttons, P1BUTTONS[i].X, 100, 70, 70);
                    if (i <= 9)
                        DB.DrawImage(buttons, P1BUTTONS[i].X, 80, 70, 70);
                    else
                        DB.DrawImage(buttons, P1BUTTONS[i].X, 190, 70, 70);
                    DECODE.Add(P1BUTTONS[i].IDX);
                }
                //DEBUG DECODE;
                //for (int i = 0; i < len; i++)
                //    Console.WriteLine(P1BUTTONS[i].IDX);
                BUTTFLAG = false;
            }
            else 
            {
                Image buttons;
                int len = P1BUTTONS.Count();
                for (int i = 0; i < len; i++)
                {
                    buttons = Image.FromFile(P1BUTTONS[i].ADDR);
                    //DB.DrawImage(buttons, P1BUTTONS[i].X, 100, 70, 70);
                    if (i <= 9)
                        DB.DrawImage(buttons, P1BUTTONS[i].X, 80, 70, 70);
                    else
                        DB.DrawImage(buttons, P1BUTTONS[i].X, 190, 70, 70);
                }
            }
        }

        //Wait
        private void Wait()
        {
            int countDown = 3;
            for (int i = 0; i <= 3000; i++)
            {
                if (i % 1000 == 0)
                {
                    this.Waitlabel.Text = countDown.ToString();
                    countDown--;
                }
                this.Waitlabel.Refresh();
            }
            Iswait = false;
        }

        //KEYBOARD
        private void EnableBUT(bool flag)
        {
            if(flag)
                this.POINTS.Focus();
            else
                this.BONUS.Focus();
        }
        private void KeyDW(object sender, PreviewKeyDownEventArgs e)
        {
           switch(e.KeyCode)
           {
                case Keys.Escape:
                    {
                        //this.Refresh();
                        //DECODE.Clear();
                        //INPUTS.Clear();
                        //BUTTFLAG = true;
                        Iswait = true;
                        this.EXITBUTT.Show();
                        this.CONTBUTT.Show();
                        break;
                    }
                case Keys.Q:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(5);
                        break;
                    }
                case Keys.W:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(0);
                        break;
                    }
                case Keys.E:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(4);
                        break;
                    }
                case Keys.A:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(1);
                        break;
                    }
                case Keys.S:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(2);
                        break;
                    }
                case Keys.D:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(3);
                        break;
                    }
                case Keys.Z:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(6);
                        break;
                    }
                case Keys.X:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(7);
                        break;
                    }
                case Keys.C:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(8);
                        break;
                    }
                case Keys.F:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(9);
                        break;
                    }
                case Keys.J:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(10);
                        break;
                    }
                case Keys.K:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(11);
                        break;
                    }
                case Keys.L:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(12);
                        break;
                    }
                default:
                    {
                        FSTEP = 0;
                        if (INPUTS.Count < DECODE.Count)
                            INPUTS.Add(-1);
                        break;
                    }
            }
        }

        //CHECKING
        bool CHECK(int idx)
        {
            if (INPUTS[idx] == DECODE[idx])
                return true;
            return false;
        }
        void RIGHTORWRONG(bool PEnd)
        {
            int idx = INPUTS.Count() - 1;
            if (INPUTS.Count > 0)
            {
                if(FSTEP == 0)
                {
                    Console.WriteLine("FSTEP");
                    if (CHECK(idx))
                    {
                        bonus += 100;
                        P1BUTTONS[idx].ADDR = IMGBUTTONSRIGHT[P1BUTTONS[idx].IDX];
                    }
                    else
                    {
                        Health -= DMG;
                        HIT = true;
                        Console.WriteLine(Health);
                        P1BUTTONS[idx].ADDR = IMGBUTTONSWRONG[P1BUTTONS[idx].IDX];
                    }
                }
            }
            if (!PEnd)
                if (bonus - 50 > 0)
                    bonus -= 1;
            FSTEP = 1;
        }

        //CLEARING
        private void CLEAR()
        {
            //RectangleF a = new RectangleF(0, 0, ClientSize.Width, 500);
            //this.Invalidate(Rectangle.Round(a));
            BONUS.Visible = false;
            PEnd = false;
            DECODE.Clear();
            INPUTS.Clear();
            timer = 0;
            CKtimer = 0;
            bonus = 0;
            NUINPUTS = 0;
            BUTTFLAG = true;
            HIT = false;
            STORM.Pivot = true;
            DARTH.Pivot = true;
            IsVder = false;
            ISstorm = false;
            distance = 100;
            height = 0;
            isbonus = true;
            this.Refresh();
            Console.WriteLine("RESET");
        }

        //RESULT
        private void RESULT()
        {
            BONUS.Visible = true;
            EnableBUT(false);
            if (timer != 1000)
            {
                timer += 20;
                bstep += (float)bonus * 20 / 1000;
                points = (int)bstep;
                if(HIT == true)
                {
                    correct = 0;
                    VAniType = 1;
                    SAniType = 1;
                    //this.Refresh();
                    RectangleF b = new RectangleF(STORM.P1X, STORM.P1Y, 2 * STORM.Size, STORM.Size);
                    this.Invalidate(Rectangle.Round(b));
                    RectangleF a = new RectangleF(DARTH.P1X, DARTH.P1Y, 2 * DARTH.Size, DARTH.Size);
                    this.Invalidate(Rectangle.Round(a));

                    RectangleF c = new RectangleF(STORM.P1X - distance, STORM.P1Y, 200, 200);
                    this.Invalidate(Rectangle.Round(c));

                }
                else 
                {
                    correct++;
                    SAniType = 1;
                    RectangleF b = new RectangleF(STORM.P1X, STORM.P1Y, 2 * STORM.Size, STORM.Size);
                    this.Invalidate(Rectangle.Round(b));

                    RectangleF c = new RectangleF(STORM.P1X - distance, STORM.P1Y, 200, 200);
                    this.Invalidate(Rectangle.Round(c));

                    VAniType = 2;
                    RectangleF a = new RectangleF(DARTH.P1X, DARTH.P1Y, 2 * DARTH.Size, DARTH.Size);
                    this.Invalidate(Rectangle.Round(a));

                }

                this.BONUS.Refresh();
                this.POINTS.Refresh();

            }
            else
            {
                CLEAR();
            }
        }

        //REFRESH
        private void REFRESH(object sender, PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (SAniType == 0 && ISstorm == true)
            { 
                STORM.IdleAni(e);
            }
            else if (SAniType == 1 && ISstorm == true)
            {
                if (HIT == true)
                {
                    int min = Math.Min(130, (int)(STORM.P1X - 50 - DARTH.P1X - 130));
                    int max = Math.Max(130, (int)(STORM.P1X - 50 - DARTH.P1X - 130));
                    distance = rnd.Next(min, max);
                    height = rnd.Next(-80, 80);
                    e.Graphics.DrawImage(bullet, STORM.P1X - distance, STORM.P1Y + height, 200, 200);
                }
                else
                {
                    if (IShoot == false)
                    {
                        e.Graphics.DrawImage(bullet, STORM.P1X - distance, STORM.P1Y, 200, 200);
                        distance = (STORM.P1X - 50 - DARTH.P1X - 130);
                        IShoot = true;
                    }
                    else
                    {
                        int min = Math.Min(130, (int)(STORM.P1X - 50 - DARTH.P1X - 130));
                        int max = Math.Max(130, (int)(STORM.P1X - 50 - DARTH.P1X - 130));
                        distance = rnd.Next(min, max);
                        e.Graphics.DrawImage(bullet, STORM.P1X - distance, STORM.P1Y, 200, 200);
                        IShoot = false;
                    }
                }

                STORM.Attack(e, 0);
            }

            if (VAniType == 0 && IsVder == true)
                DARTH.IdleAni(e);
            else if (VAniType == 1 && IsVder == true)
                DARTH.Attack(e, Health);
            else if (VAniType == 2 && IsVder == true)
                DARTH.DMG(e);

        }
        private void BOREF(object sener, PaintEventArgs e)
        {
            if (correct / 50 >= 15)
            {
                if (isbonus)
                {
                    bonus += 1000;
                    isbonus = false;
                }
                Font font = new Font(FONTS.Families[1], this.BONUS.Font.Size, this.BONUS.Font.Style);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 30, 50), Color.Gold, Color.WhiteSmoke, LinearGradientMode.Vertical);
                SolidBrush brush1 = new SolidBrush(Color.Black);

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                Rectangle centered = e.ClipRectangle;
                centered.Offset(-2, (int)(e.ClipRectangle.Height - e.Graphics.MeasureString(this.BONUS.Text, font).Height) / 2 + 4);
                e.Graphics.DrawString(this.BONUS.Text, font, brush1, centered, sf);
                e.Graphics.DrawString(this.BONUS.Text, font, brush, centered, sf);
                this.BONUS.Text = "Smoking\nSexy\nStyle!!!\n" + bonus;
            }
            else if (correct / 50 >= 10)
            {
                if (isbonus)
                {
                    bonus += 700;
                    isbonus = false;
                }
                Font font = new Font(FONTS.Families[1], this.BONUS.Font.Size, this.BONUS.Font.Style);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 40, 60), Color.Crimson, Color.WhiteSmoke, LinearGradientMode.Vertical);
                SolidBrush brush1 = new SolidBrush(Color.Black);

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                Rectangle centered = e.ClipRectangle;
                centered.Offset(-2, (int)(e.ClipRectangle.Height - e.Graphics.MeasureString(this.BONUS.Text, font).Height) / 2 + 4);
                e.Graphics.DrawString(this.BONUS.Text, font, brush1, centered, sf);
                e.Graphics.DrawString(this.BONUS.Text, font, brush, centered, sf);
                this.BONUS.Text = "Sick\nSkill!!\n" + bonus;
            }
            else if (correct / 50 >= 7)
            {
                if (isbonus)
                {
                    bonus += 400;
                    isbonus = false;
                }
                Font font = new Font(FONTS.Families[1], this.BONUS.Font.Size, this.BONUS.Font.Style);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 30, 60), Color.LimeGreen, Color.WhiteSmoke, LinearGradientMode.Vertical);
                SolidBrush brush1 = new SolidBrush(Color.Black);

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                Rectangle centered = e.ClipRectangle;
                centered.Offset(-2, (int)(e.ClipRectangle.Height - e.Graphics.MeasureString(this.BONUS.Text, font).Height) / 2 + 4);
                e.Graphics.DrawString(this.BONUS.Text, font, brush1, centered, sf);
                e.Graphics.DrawString(this.BONUS.Text, font, brush, centered, sf);
                this.BONUS.Text = "Savage!\n" + bonus;
            }
            else if (correct / 50 >= 5)
            {
                if (isbonus)
                {
                    bonus += 200;
                    isbonus = false;
                }
                Font font = new Font(FONTS.Families[1], this.BONUS.Font.Size, this.BONUS.Font.Style);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 30, 60), Color.BlueViolet, Color.WhiteSmoke, LinearGradientMode.Vertical);
                SolidBrush brush1 = new SolidBrush(Color.Black);

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                Rectangle centered = e.ClipRectangle;
                centered.Offset(-2, (int)(e.ClipRectangle.Height - e.Graphics.MeasureString(this.BONUS.Text, font).Height) / 2 + 4);
                e.Graphics.DrawString(this.BONUS.Text, font, brush1, centered, sf);
                e.Graphics.DrawString(this.BONUS.Text, font, brush, centered, sf);
                this.BONUS.Text = "Apocalyptic\n" + bonus;

            }
            else if (correct / 50 >= 3)
            {
                if (isbonus)
                {
                    bonus += 100;
                    isbonus = false;
                }

                Font font = new Font(FONTS.Families[1], this.BONUS.Font.Size, this.BONUS.Font.Style);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 30, 50), Color.MidnightBlue, Color.White, LinearGradientMode.Vertical);
                SolidBrush brush1 = new SolidBrush(Color.Black);

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                Rectangle centered = e.ClipRectangle;
                centered.Offset(-2, (int)(e.ClipRectangle.Height - e.Graphics.MeasureString(this.BONUS.Text, font).Height) / 2 + 4);
                e.Graphics.DrawString(this.BONUS.Text, font, brush1, centered, sf);
                e.Graphics.DrawString(this.BONUS.Text, font, brush, centered, sf);
                this.BONUS.Text = "Badass\n" + bonus;
            }
            else if (correct / 50 >= 0)
            {
                Font font = new Font(FONTS.Families[1], this.BONUS.Font.Size, this.BONUS.Font.Style);
                SolidBrush brush = new SolidBrush(Color.White);
                SolidBrush brush1 = new SolidBrush(Color.Black);

                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                Rectangle centered = e.ClipRectangle;
                centered.Offset(-2, (int)(e.ClipRectangle.Height - e.Graphics.MeasureString(this.BONUS.Text, font).Height) / 2 + 4);
                e.Graphics.DrawString(this.BONUS.Text, font, brush1, centered, sf);
                e.Graphics.DrawString(this.BONUS.Text, font, brush, centered, sf);
                this.BONUS.Text = "Dismal\n" + bonus;
            }
        }
        private void POREF(object sender, PaintEventArgs e)
        {
            if (points > 100000)
            {
                Font font = new Font(FONTS.Families[3], this.POINTS.Font.Size + 0.45f, this.POINTS.Font.Style);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 30, 50), Color.Gold, Color.WhiteSmoke, LinearGradientMode.Vertical);
                SolidBrush brush1 = new SolidBrush(Color.Black);
                e.Graphics.DrawString(this.POINTS.Text, font, brush1, -0.8f, 0);
                e.Graphics.DrawString(this.POINTS.Text, font, brush, 0, 0);
            }
            else if (points > 80000)
            {
                Font font = new Font(FONTS.Families[3], this.POINTS.Font.Size + 0.45f, this.POINTS.Font.Style);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 30, 50), Color.Crimson, Color.WhiteSmoke, LinearGradientMode.Vertical);
                SolidBrush brush1 = new SolidBrush(Color.Black);
                e.Graphics.DrawString(this.POINTS.Text, font, brush1, -0.8f, 0);
                e.Graphics.DrawString(this.POINTS.Text, font, brush, 0, 0);
            }
            else if (points > 50000)
            {
                Font font = new Font(FONTS.Families[3], this.POINTS.Font.Size + 0.45f, this.POINTS.Font.Style);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 30, 50), Color.SeaGreen, Color.WhiteSmoke, LinearGradientMode.Vertical);
                SolidBrush brush1 = new SolidBrush(Color.Black);
                e.Graphics.DrawString(this.POINTS.Text, font, brush1, -0.8f, 0);
                e.Graphics.DrawString(this.POINTS.Text, font, brush, 0, 0);
            }
            else if (points > 20000)
            {
                Font font = new Font(FONTS.Families[3], this.POINTS.Font.Size + 0.45f, this.POINTS.Font.Style);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 30, 50), Color.LightCoral, Color.WhiteSmoke, LinearGradientMode.Vertical);
                SolidBrush brush1 = new SolidBrush(Color.Black);
                e.Graphics.DrawString(this.POINTS.Text, font, brush1, -0.8f, 0);
                e.Graphics.DrawString(this.POINTS.Text, font, brush, 0, 0);
            }
            else if (points > 10000)
            {
                Font font = new Font(FONTS.Families[3], this.POINTS.Font.Size + 0.45f, this.POINTS.Font.Style);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 30, 50), Color.LightCoral, Color.WhiteSmoke, LinearGradientMode.Vertical);
                SolidBrush brush1 = new SolidBrush(Color.Black);
                e.Graphics.DrawString(this.POINTS.Text, font, brush1, -0.8f, 0);
                e.Graphics.DrawString(this.POINTS.Text, font, brush, 0, 0);
            }
            else if (points > 5000)
            {
                Font font = new Font(FONTS.Families[3], this.POINTS.Font.Size + 0.45f, this.POINTS.Font.Style);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 30, 50), Color.MediumPurple, Color.WhiteSmoke, LinearGradientMode.Vertical);
                SolidBrush brush1 = new SolidBrush(Color.Black);
                e.Graphics.DrawString(this.POINTS.Text, font, brush1, -0.8f, 0);
                e.Graphics.DrawString(this.POINTS.Text, font, brush, 0, 0);
            }
            else if (points > 1000)
            {
                Font font = new Font(FONTS.Families[3], this.POINTS.Font.Size + 0.45f, this.POINTS.Font.Style);
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, 50, 50), Color.PowderBlue, Color.WhiteSmoke, LinearGradientMode.Vertical);
                SolidBrush brush1 = new SolidBrush(Color.Black);
                e.Graphics.DrawString(this.POINTS.Text, font, brush1, -0.8f, 0);
                e.Graphics.DrawString(this.POINTS.Text, font, brush, 0, 0);
            }

            this.POINTS.Text = "POINTS " + points;
            if(this.POINTS.Text.Length > 12)
            {
                this.POINTS.Location = new Point(1008 - 16 * (this.POINTS.Text.Length - 12), 3);
            }
        }
        //GAMEOVER
        private bool END()
        {
            if (Health <= 0)
                if (DARTH.P1X >= 650)
                    return true;
            return false;
        }

        private void CONTBUTT_Click(object sender, EventArgs e)
        {
            CONT = true;
        }
        private void EXITBUTT_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.MAIN.Show();
            this.MAIN.Enabled = true;
            AGAIN = true;
            this.Dispose();
        }

        private void GAME1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (AGAIN == false)
                MAIN.Dispose();
        }

        //public void RESET()
        //{
        //    this.Health = 100;
        //    ISOVER = false;
        //    this.points = 0;
        //}
    }
}