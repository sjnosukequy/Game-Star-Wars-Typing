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

namespace Game.LOSESCREEN
{
    public partial class LOSE : Form
    {
        List<string> BG = new List<string>();
        int step = 0;
        Image bg;
        bool end =false;
        PrivateFontCollection FONTS = new PrivateFontCollection();
        List<String> ADDRFONTS = new List<string>();
        int dif;

        public LOSE(int dif)
        {
            InitializeComponent();
            setup();
            this.dif = dif;
        }
        private void setup()
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            BG = Directory.GetFiles("BG\\BG LOSE\\VADERDEATH", "*.png").ToList();
            ADDRFONTS = Directory.GetFiles("MISC", "*ttf").ToList();
            foreach (string i in ADDRFONTS)
                FONTS.AddFontFile(i);
            this.button1.Font = new Font(FONTS.Families[3], this.button1.Font.Size + 30, this.button1.Font.Style);
            this.button2.Font = new Font(FONTS.Families[1], this.button2.Font.Size + 25, this.button2.Font.Style);
        }
        private void LOSE_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GAME1 sp = new GAME1(dif);
            sp.ShowDialog();
            this.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ps = new Main();
            ps.ShowDialog();
            this.Dispose();
        }
        private void Timer(object sender, EventArgs e)
        {
            bg = Image.FromFile(BG[step]);
            if (step > 55)
            {
                this.button1.Show();
                this.button2.Show();
                step = 48;
            }
            step++;
            this.BackgroundImage = bg;
        }

    }
}
