using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class BUTTONS
{
    public string ADDR;
    public List<String> IMGLIST;
    public List<String> Buttons;
    public int X;
    public int IDX;
    public float P1X;
    public float P1Y;
    public int Size;
    public BUTTONS(string addr, int x, int idx)
    {
        ADDR = addr;
        X = x;
        IDX = idx;
    }
    public BUTTONS(float p1X, float p1Y, int size, string location, string format) //format *.png, *.jpg 
    {
        IMGLIST = new List<string>();
        Buttons = new List<string>();
        IMGLIST = Directory.GetFiles(location, format).ToList();
        P1X = p1X;
        P1Y = p1Y;
        Size = size;
    }
    ~BUTTONS()
    {

    }
    public void Setup2(int len, ref List<int> RES)
    {
        if (Buttons.Count > 0)
            Buttons.Clear();
        Random rnd = new Random(Guid.NewGuid().GetHashCode());
        for (int i=0;i<len;i++)
        {
            int k = rnd.Next(0,4);
            Buttons.Add(IMGLIST[k]);
            RES.Add(k);
        }
    }
    public void Draw(PaintEventArgs e)
    {
        int len = Buttons.Count();
        for(int i=0;i<len;i++)
        {
            Image butt = Image.FromFile(Buttons[i]);
            Bitmap bitmap = new Bitmap(butt, Size, Size);
            if (i > 4)
                e.Graphics.DrawImage(bitmap, P1X + (Size + Size / 5) * (i-5), P1Y + (Size + Size / 5));
            else
                e.Graphics.DrawImage(bitmap, P1X + (Size + Size / 5) * i, P1Y);
        }
    }
    public void Clear()
    {
        Buttons.Clear();
    }
}
