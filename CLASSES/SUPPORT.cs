using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public static class SUPPORT
    {
        //public static void tempBUTTSHOW(bool Buttflag)
        //{
        //    if (Buttflag)
        //    {
        //        Image buttons;
        //        int len = rnd.Next(3, 11);
        //        int width = 750;
        //        P1BUTTONS.Clear();
        //        bonus = 100 * len;
        //        for (int i = 0; i < len; i++)
        //        {
        //            int rand = rnd.Next(0, 13);
        //            BUTTONS a = new BUTTONS(IMGBUTTONS[rand], width, rand);
        //            P1BUTTONS.Add(a);
        //            if (i == 4)
        //                width = 750;
        //            else
        //                width += 100;
        //        }
        //        for (int i = 0; i < len; i++)
        //        {
        //            buttons = Image.FromFile(P1BUTTONS[i].ADDR);
        //            if (i <= 4)
        //                DB.DrawImage(buttons, P1BUTTONS[i].X, 100, 70, 70);
        //            else
        //                DB.DrawImage(buttons, P1BUTTONS[i].X, 190, 70, 70);
        //            DECODE.Add(P1BUTTONS[i].IDX);
        //        }
        //        //DEBUG DECODE;
        //        //for (int i = 0; i < len; i++)
        //        //    Console.WriteLine(P1BUTTONS[i].IDX);
        //        BUTTFLAG = false;
        //    }
        //    else
        //    {
        //        Image buttons;
        //        int len = P1BUTTONS.Count();
        //        for (int i = 0; i < len; i++)
        //        {
        //            buttons = Image.FromFile(P1BUTTONS[i].ADDR);
        //            if (i <= 4)
        //                DB.DrawImage(buttons, P1BUTTONS[i].X, 100, 70, 70);
        //            else
        //                DB.DrawImage(buttons, P1BUTTONS[i].X, 190, 70, 70);
        //        }
        //    }
        //}
        //private void BUTTCHANGE()
        //{
        //    try
        //    {
        //        for (int i = 0; i < 13; i++)
        //        {

        //            // Load the image
        //            Image image = Image.FromFile(IMGBUTTONS[i]);

        //            // Create a ColorMatrix object and set the Hue value
        //            ColorMatrix colorMatrix = new ColorMatrix(
        //                new float[][]{
        //                new float[] {1, 0, 0, 0, 0},
        //                new float[] {0, 1, 0, 0, 0},
        //                new float[] {0, 0, 1, 0, 0},
        //                new float[] {0, 0, 0, 1, 0},
        //                new float[] {-1, 1, -1, 0, 1}
        //                });

        //            // Create an ImageAttributes object and set the ColorMatrix property
        //            ImageAttributes imageAttributes = new ImageAttributes();
        //            imageAttributes.SetColorMatrix(colorMatrix);

        //            // Create a new bitmap with the same size as the original image
        //            Bitmap newImage = new Bitmap(image.Width, image.Height);

        //            // Draw the original image onto the new bitmap using the ImageAttributes object
        //            Graphics graphics = Graphics.FromImage(newImage);
        //            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);

        //            // OPTIONS
        //            //newImage.Save(IMGBUTTONS[i] + "1", ImageFormat.Png);
        //            //this.BackgroundImage = newImage;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any errors that might occur
        //        MessageBox.Show("An error occurred: " + ex.Message);

        //    }
        //}
        //private void BGCHANGECOLOR()
        //{
        //    try
        //    {
        //        //change step
        //        if (imageflag)
        //            imagestep += (float)0.3;
        //        else
        //            imagestep -= (float)0.3;
        //        //setting flag
        //        if (imagestep > 1)
        //            imageflag = false;
        //        else if (imagestep < -1)
        //            imageflag = true;
        //        // Load the image
        //        //Image image = Image.FromFile("D:\\project hoc\\Win Programing\\MIDTERM\\Game\\bin\\Debug\\net6.0-windows\\BG\\BG.jpg");

        //        // Create a ColorMatrix object and set the Hue value
        //        ColorMatrix colorMatrix = new ColorMatrix(
        //            new float[][]{
        //                new float[] {1, 0, 0, 0, 0},
        //                new float[] {0, 1, 0, 0, 0},
        //                new float[] {0, 0, 1, 0, 0},
        //                new float[] {0, 0, 0, 1, 0},
        //                new float[] {imagestep, imagestep, 0, 0, 1}
        //            });

        //        // Create an ImageAttributes object and set the ColorMatrix property
        //        ImageAttributes imageAttributes = new ImageAttributes();
        //        imageAttributes.SetColorMatrix(colorMatrix);

        //        // Create a new bitmap with the same size as the original image
        //        Bitmap newImage = new Bitmap(image.Width, image.Height);

        //        // Draw the original image onto the new bitmap using the ImageAttributes object
        //        Graphics graphics = Graphics.FromImage(newImage);
        //        //graphics.TranslateTransform((float)newImage.Width / 2, (float)newImage.Height / 2);
        //        //graphics.RotateTransform(40);
        //        //graphics.TranslateTransform(-(float)newImage.Width / 2, -(float)newImage.Height / 2);

        //        //set the InterpolationMode to HighQualityBicubic so to ensure a high
        //        //quality image once it is transformed to the specified size
        //        //graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //        graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);

        //        // Set the modified image as the background image
        //        this.BackgroundImage = newImage;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any errors that might occur
        //        MessageBox.Show("An error occurred: " + ex.Message);
        //    }
        //}
    }
}
