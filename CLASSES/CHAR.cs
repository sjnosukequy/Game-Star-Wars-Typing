using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class CHAR
{
    public List<string> Sprites;
    public float P1X;
    public float P1Y;
    public int step;
    public int Size;
    public Image Char;
    public bool Pivot = true;
    private float OFFSET;
    private float P2X;

    public CHAR( float p1X, float p1Y, int size,string location, string format) //format *.png, *.jpg 
    {
        Sprites = new List<string>();
        Sprites = Directory.GetFiles(location, format).ToList();
        P1X = p1X;
        P1Y = p1Y;
        step = -1;
        Size = size;
        P2X = 10000;
    }
    ~ CHAR()
    {

    }
    public void IdleAni(PaintEventArgs e)
    {
        if (step < 0 || step > 14)
            step = 0;
        Char = Image.FromFile(Sprites[step]);
        Bitmap bitmap = new Bitmap(Char, 2*Size, Size);
        e.Graphics.DrawImage(bitmap, P1X, P1Y);
        step++;
    }
    public void Attack(PaintEventArgs e, int health)
    {
        if (P1X > P2X)
        {
            if (step < 24 || step > 32)
                step = 24;
        }
        else
            if (step < 15 || step > 23)
            step = 15;

        Char = Image.FromFile(Sprites[step]);
        Bitmap bitmap = new Bitmap(Char, 2 * Size, Size);
        //Console.WriteLine(health);
        if (Pivot)
        {
            float maxl = (100 - health) * (650) / 100;
            if (P1X > maxl)
                maxl = P1X;
            P2X = maxl - P1X;
            //Console.WriteLine(maxl);
            OFFSET = (P2X * 20) / 1000;
            P2X = maxl;
            //Console.WriteLine(OFFSET);
            Pivot = false;
        }

        else if (P1X <= P2X)
        {
            P1X += OFFSET;
        }

        e.Graphics.DrawImage(bitmap, P1X, P1Y);
        step++;

    }
    public void Attack(PaintEventArgs e)
    {
        if (step < 15 || step > 23)
            step = 15;
        Char = Image.FromFile(Sprites[step]);
        Bitmap bitmap = new Bitmap(Char, 2 * Size, Size);
        e.Graphics.DrawImage(bitmap, P1X, P1Y);
        step++;
    }
    public void DMG(PaintEventArgs e)
    {
        if (step < 33 || step > 41)
            step = 33;
        Char = Image.FromFile(Sprites[step]);
        Bitmap bitmap = new Bitmap(Char, 2 * Size, Size);
        e.Graphics.DrawImage(bitmap, P1X, P1Y);
        step++;
    }

}
