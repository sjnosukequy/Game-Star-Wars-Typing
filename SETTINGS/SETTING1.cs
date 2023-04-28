using Game.GAMES;
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

namespace Game.SETTINGS
{
    public partial class SETTING1 : Form
    {
        public bool back;
        int dif = 11;
        PrivateFontCollection FONTS = new PrivateFontCollection();
        List<String> ADDRFONTS = new List<string>();

        private Form MAIN;
        public SETTING1(Form Main)
        {
            InitializeComponent();
            ADDRFONTS = Directory.GetFiles("MISC", "*ttf").ToList();
            foreach (string i in ADDRFONTS)
                FONTS.AddFontFile(i);
            this.START.Font = new Font(FONTS.Families[3], this.START.Font.Size + 10, this.START.Font.Style);
            this.BACK.Font = new Font(FONTS.Families[3], this.BACK.Font.Size + 10, this.BACK.Font.Style);
            this.DIFF.Font = new Font(FONTS.Families[1], this.DIFF.Font.Size + 10, this.DIFF.Font.Style);
            this.label1.Font = new Font(FONTS.Families[3], this.label1.Font.Size + 5, this.label1.Font.Style);
            MAIN = Main;
        }

        private void DIFF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.DIFF.SelectedItem == "EASY")
                dif = 6;
            else if (this.DIFF.SelectedItem == "NORMAL")
                dif = 11;
            else if (this.DIFF.SelectedItem == "HARD")
                dif = 21;
            this.label1.Focus();
        }

        private void START_Click(object sender, EventArgs e)
        {
            back = false;
            this.Hide();
            GAME1 ps = new GAME1(dif,MAIN);
            ps.ShowDialog();
            this.Dispose();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            back = true;
            this.Dispose();
        }
    }
}
