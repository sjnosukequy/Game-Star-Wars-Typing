using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class LOADING
{
    public float P1X;
    public float P1Y;
    public int Mtime;
    public Color Color;
    public SolidBrush Brush;
    public LOADING(float p1X, float p1Y,  int time, Color color)
    {
        P1X = p1X;
        P1Y = p1Y;
        Mtime = time;
        Color = color;
        Brush = new SolidBrush(Color);
    }
    ~LOADING()
    {

    }
    public void Draw(Graphics e, int idx)
    {
        if (idx <= Mtime)
        {
            float len = 890 * idx / Mtime;
            e.FillRectangle(Brush, P1X, P1Y, P1X + len, 20);
        }
    }
    public void Draw(PaintEventArgs e, int idx)
    {
        if (idx <= Mtime)
        {
            float len = 1000 * idx / Mtime;
            e.Graphics.FillRectangle(Brush, P1X, P1Y, P1X + 1000 - len, 30);
        }
        else
            e.Graphics.FillRectangle(Brush, P1X, P1Y, P1X, 30);
    }
}
