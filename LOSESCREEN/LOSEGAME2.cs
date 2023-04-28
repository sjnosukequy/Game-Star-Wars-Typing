using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game;
using Game.GAMES;

namespace Game.LOSESCREEN
{
    public partial class LOSEGAME2 : Form
    {
        List<String> BGLIST = new List<String>();
        Image BG;
        int step = 0;
        //ENING
        public int ENDING;
        int HEALTH;
        int DMG;

        //FONT
        PrivateFontCollection FONTS = new PrivateFontCollection();
        List<String> ADDRFONTS = new List<string>();

        private Form MAIN;
        bool AGAIN = false;
        public LOSEGAME2(int ED,int health, int dmg, Form Main)
        {
            InitializeComponent();
            MAIN = Main;
            ENDING = ED;
            HEALTH = health;
            DMG = dmg;
            Setup();
        }
        private void Setup()
        {
            this.AGAINBUTT.Hide();
            this.MENUBUTT.Hide();
            if (ENDING == 1)
                BGLIST = Directory.GetFiles("BG\\BG LOSE\\BGLOSEply2", "*.png").ToList();
            else if(ENDING == 2)
                BGLIST = Directory.GetFiles("BG\\BG LOSE\\BGLOSEply1", "*.png").ToList();
            else if (ENDING == 3)
                BGLIST = Directory.GetFiles("BG\\BG LOSE\\DRAW", "*.png").ToList();
            ADDRFONTS = Directory.GetFiles("MISC", "*ttf").ToList();
            foreach (string i in ADDRFONTS)
                FONTS.AddFontFile(i);
            this.MENUBUTT.Font = new Font(FONTS.Families[1], this.MENUBUTT.Font.Size+10, this.MENUBUTT.Font.Style);
            this.AGAINBUTT.Font = new Font(FONTS.Families[1], this.AGAINBUTT.Font.Size+10, this.AGAINBUTT.Font.Style);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            BG = Image.FromFile(BGLIST[step]);
            this.BackgroundImage = BG;
            step++;
            if (ENDING == 1)
            {
                if (step > 142)
                {
                    this.AGAINBUTT.Show();
                    this.MENUBUTT.Show();
                    step = 137;
                }
            }
            else if (ENDING == 2)
            {
                if (step > 161)
                {
                    this.AGAINBUTT.Show();
                    this.MENUBUTT.Show();
                    step = 153;
                }
            }
            else if (ENDING == 3)
            {
                if (step > 64)
                {
                    this.AGAINBUTT.Show();
                    this.MENUBUTT.Show();
                    step = 56;
                }
            }
        }
        private void AGAINCLICK(object sener,EventArgs e)
        {
            this.Hide();
            AGAIN = true;
            GAME2 ps = new GAME2(HEALTH, DMG, MAIN);
            ps.ShowDialog();
            this.Dispose();
        }
        private void MENUCLICK(object sender,EventArgs e)
        {
            this.Hide();
            AGAIN = true;
            this.MAIN.Show();
            this.MAIN.Enabled = true;
            this.Dispose();
        }

        private void LOSEGAME2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (AGAIN == false)
                this.MAIN.Dispose();
        }
    }
}
