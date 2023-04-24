using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.GAMES;
using Game.SETTINGS;

namespace Game
{
    public partial class Main : Form
    {
        Random rnd = new Random();
        PrivateFontCollection FONTS = new PrivateFontCollection();
        List<String> ADDRFONTS = new List<string>();
        int step = 0;
        Image BG;
        List<String> BGL = new List<string>();
        public Main()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            BGL = Directory.GetFiles("BG\\BGMMenu", "*.png").ToList();
            ADDRFONTS = Directory.GetFiles("MISC", "*ttf").ToList();
            foreach (string i in ADDRFONTS)
                FONTS.AddFontFile(i);
            this.ONEPLY.Font = new Font(FONTS.Families[3], this.ONEPLY.Font.Size + 30, this.ONEPLY.Font.Style);
            this.TWOPLY.Font = new Font(FONTS.Families[3], this.TWOPLY.Font.Size + 30, this.TWOPLY.Font.Style);
            this.label1.Font = new Font(FONTS.Families[2], this.label1.Font.Size, this.label1.Font.Style);
        }

        private void ONEPLY_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.Enabled = false;
            SETTING1 ps = new SETTING1();
            ps.ShowDialog();
            if (ps.back)
            {
                this.Enabled = true;
                this.timer1.Start();
            }
            else
            {
                this.Enabled = true;
                this.Dispose();
            }
        }

        private void TWOPLY_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.Enabled = false;
            SETTING2 ps = new SETTING2();
            ps.ShowDialog();
            if (ps.back)
            {
                this.Enabled = true;
                this.timer1.Start();
            }
            else
            {
                this.Enabled = true;
                this.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (step > 341)
                step = 0;
            if (step % 4 == 0)
                this.label1.ForeColor = Color.FromArgb(rnd.Next(100,250), rnd.Next(100, 250), rnd.Next(100, 250));
            BG = Image.FromFile(BGL[step]);
            this.BackgroundImage = BG;
            step++;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
