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
    public partial class SETTING2 : Form
    {
        int Health = 100;
        int dmg = 10;
        public bool back;
        PrivateFontCollection FONTS = new PrivateFontCollection();
        List<String> ADDRFONTS = new List<string>();
        public SETTING2()
        {
            InitializeComponent();
            ADDRFONTS = Directory.GetFiles("MISC", "*ttf").ToList();
            foreach (string i in ADDRFONTS)
                FONTS.AddFontFile(i);
            this.START.Font = new Font(FONTS.Families[3], this.START.Font.Size + 10, this.START.Font.Style);
            this.BACK.Font = new Font(FONTS.Families[3], this.BACK.Font.Size + 10, this.BACK.Font.Style);
            this.HEALTH.Font = new Font(FONTS.Families[1], this.HEALTH.Font.Size + 10, this.HEALTH.Font.Style);
            this.DMG.Font = new Font(FONTS.Families[1], this.DMG.Font.Size + 10, this.DMG.Font.Style);
            this.label1.Font = new Font(FONTS.Families[3], this.label1.Font.Size + 5, this.label1.Font.Style);
            this.label2.Font = new Font(FONTS.Families[3], this.label2.Font.Size + 5, this.label2.Font.Style);
        }

        private void HEALTH_SelectedIndexChanged(object sender, EventArgs e)
        {
            Health = Convert.ToInt32(HEALTH.SelectedItem);
            this.label1.Focus();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dmg = Convert.ToInt32(DMG.SelectedItem);
            this.label1.Focus();
        }

        private void START_Click(object sender, EventArgs e)
        {
            back = false;
            this.Hide();
            GAME2 ps = new GAME2(Health, dmg);
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
