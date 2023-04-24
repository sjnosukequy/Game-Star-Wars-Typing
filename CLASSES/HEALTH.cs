using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class HEALTH
{
    public int P1X;
    public int P1Y;
    public int MHealth;
    public int Health;
    private SolidBrush Brush;
    public HEALTH(int p1X, int p1Y, int mHealth, Color color)
    {
        P1X = p1X;
        P1Y = p1Y;
        MHealth = mHealth;
        Health = mHealth;
        Brush = new SolidBrush(color);
    }
    public void Draw(PaintEventArgs e,int Dmg)
    {
        Health -= Dmg;
        e.Graphics.FillRectangle(Brush, P1X, P1Y, 185 - (MHealth - Health) * 185 / MHealth, 35);
    }
    public void Draw(PaintEventArgs e)
    {
        if (Health < MHealth*30/100)
            Brush = new SolidBrush(Color.Red);
        else if (Health < MHealth*70/100)
            Brush = new SolidBrush(Color.YellowGreen);
        e.Graphics.FillRectangle(Brush, P1X, P1Y, 185 - (MHealth - Health) * 185 / MHealth, 35);
    }
}
