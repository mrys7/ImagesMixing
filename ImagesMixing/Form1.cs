using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagesMixing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(open.FileName);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(open.FileName);
                pictureBox2.Image = image;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);
                    int red = pixelRGB1.R + pixelRGB2.R;
                    int green = pixelRGB1.G + pixelRGB2.G;
                    int blue = pixelRGB1.B + pixelRGB2.B;
                    if (red > 255) red = 255;
                    else if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    else if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    else if (blue < 0) blue = 0;
                    Color newPixelRGB = Color.FromArgb(red, green, blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);
                    int red = pixelRGB1.R + pixelRGB2.R - 255;
                    int green = pixelRGB1.G + pixelRGB2.G - 255;
                    int blue = pixelRGB1.B + pixelRGB2.B - 255;
                    if (red > 255) red = 255;
                    else if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    else if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    else if (blue < 0) blue = 0;
                    Color newPixelRGB = Color.FromArgb(red, green, blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);
                    int red = Math.Abs(pixelRGB1.R - pixelRGB2.R);
                    int green = Math.Abs(pixelRGB1.G - pixelRGB2.G);
                    int blue = Math.Abs(pixelRGB1.B - pixelRGB2.B);
                    if (red > 255) red = 255;
                    else if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    else if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    else if (blue < 0) blue = 0;
                    Color newPixelRGB = Color.FromArgb(red, green, blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);
                    int red = (pixelRGB1.R * pixelRGB2.R)/255;
                    int green = (pixelRGB1.G * pixelRGB2.G)/255;
                    int blue = (pixelRGB1.B * pixelRGB2.B)/255;
                    if (red > 255) red = 255;
                    else if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    else if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    else if (blue < 0) blue = 0;
                    Color newPixelRGB = Color.FromArgb(red, green, blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);
                    double red, green, blue;
                    red = (1 - (1 - (double)pixelRGB1.R / 255) * (1 - (double)pixelRGB2.R / 255)) * 255;
                    green = (1 - (1 - (double)pixelRGB1.G / 255) * (1 - (double)pixelRGB2.G / 255)) * 255;
                    blue = (1 - (1 - (double)pixelRGB1.B / 255) * (1 - (double)pixelRGB2.B / 255)) * 255;
                    

                    if (red > 255) red = 255;
                    else if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    else if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    else if (blue < 0) blue = 0;

                    Color newPixelRGB = Color.FromArgb((int)red, (int)green, (int)blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);
                    double red = (1 - Math.Abs(1 - (double)pixelRGB1.R/255 - (double)pixelRGB2.R/255))*255;
                    double green = (1 - Math.Abs(1 - (double)pixelRGB1.R / 255 - (double)pixelRGB2.R / 255))*255;
                    double blue = (1 - Math.Abs(1 - (double)pixelRGB1.R / 255 - (double)pixelRGB2.R / 255))*255;
                    if (red > 255) red = 255;
                    else if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    else if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    else if (blue < 0) blue = 0;
                    Color newPixelRGB = Color.FromArgb((int)red, (int)green, (int)blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);
                    int red;
                    int green;
                    int blue;
                    if (pixelRGB1.R < pixelRGB2.R) red = pixelRGB1.R;
                    else red = pixelRGB2.R;
                    if (pixelRGB1.G < pixelRGB2.G) green = pixelRGB1.G;
                    else green = pixelRGB2.G;
                    if (pixelRGB1.B < pixelRGB2.B) blue = pixelRGB1.B;
                    else blue = pixelRGB2.B;
                    Color newPixelRGB = Color.FromArgb(red, green, blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);
                    int red;
                    int green;
                    int blue;
                    if (pixelRGB1.R > pixelRGB2.R) red = pixelRGB1.R;
                    else red = pixelRGB2.R;
                    if (pixelRGB1.G > pixelRGB2.G) green = pixelRGB1.G;
                    else green = pixelRGB2.G;
                    if (pixelRGB1.B > pixelRGB2.B) blue = pixelRGB1.B;
                    else blue = pixelRGB2.B;
                    Color newPixelRGB = Color.FromArgb(red, green, blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);
                    double red = (double)pixelRGB1.R + (double)pixelRGB2.R - (2 * (double)pixelRGB1.R * (double)pixelRGB2.R) / 255;
                    double green = (double)pixelRGB1.R + (double)pixelRGB2.R - (2 * (double)pixelRGB1.R * (double)pixelRGB2.R) / 255;
                    double blue = (double)pixelRGB1.R + (double)pixelRGB2.R - (2 * (double)pixelRGB1.R * (double)pixelRGB2.R) / 255;
                    if (red > 255) red = 255;
                    else if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    else if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    else if (blue < 0) blue = 0;
                    Color newPixelRGB = Color.FromArgb((int)red, (int)green, (int)blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);
                    double red;
                    double green;
                    double blue;
                    if ((double)pixelRGB1.R / 255 < 0.5) red = (2 * (double)pixelRGB1.R / 255 * (double)pixelRGB2.R / 255)*255;
                    else red = (1 - 2 * (1 - (double)pixelRGB1.R / 255) * (1 - (double)pixelRGB2.R / 255))*255;
                    if ((double)pixelRGB1.G / 255 < 0.5) green = (2 * (double)pixelRGB1.G / 255 * (double)pixelRGB2.G / 255) * 255;
                    else green = (1 - 2 * (1 - (double)pixelRGB1.G / 255) * (1 - (double)pixelRGB2.G / 255)) * 255;
                    if ((double)pixelRGB1.B / 255 < 0.5) blue = (2 * (double)pixelRGB1.B / 255 * (double)pixelRGB2.B / 255) * 255;
                    else blue = (1 - 2 * (1 - (double)pixelRGB1.B / 255) * (1 - (double)pixelRGB2.B / 255)) * 255;

                    if (red > 255) red = 255;
                    else if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    else if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    else if (blue < 0) blue = 0;
                    Color newPixelRGB = Color.FromArgb((int)red, (int)green, (int)blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);
                    double red;
                    double green;
                    double blue;
                    if ((double)pixelRGB2.R / 255 < 0.5) red = (2 * (double)pixelRGB1.R / 255 * (double)pixelRGB2.R / 255) * 255;
                    else red = (1 - 2 * (1 - (double)pixelRGB1.R / 255) * (1 - (double)pixelRGB2.R / 255)) * 255;
                    if ((double)pixelRGB2.G / 255 < 0.5) green = (2 * (double)pixelRGB1.G / 255 * (double)pixelRGB2.G / 255) * 255;
                    else green = (1 - 2 * (1 - (double)pixelRGB1.G / 255) * (1 - (double)pixelRGB2.G / 255)) * 255;
                    if ((double)pixelRGB2.B / 255 < 0.5) blue = (2 * (double)pixelRGB1.B / 255 * (double)pixelRGB2.B / 255) * 255;
                    else blue = (1 - 2 * (1 - (double)pixelRGB1.B / 255) * (1 - (double)pixelRGB2.B / 255)) * 255;

                    if (red > 255) red = 255;
                    else if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    else if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    else if (blue < 0) blue = 0;
                    Color newPixelRGB = Color.FromArgb((int)red, (int)green, (int)blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);
                    double red;
                    double green;
                    double blue;
                    if ((double)pixelRGB2.R / 255 < 0.5) red = (2 * (double)pixelRGB1.R / 255 * (double)pixelRGB2.R / 255 + (Math.Pow((double)pixelRGB1.R / 255, 2) * (1 - 2 * (double)pixelRGB2.R / 255)))*255;
                    else red = (Math.Sqrt((double)pixelRGB1.R / 255) * (2 * (double)pixelRGB2.R / 255 - 1) + 2 * (double)pixelRGB1.R / 255 * (1 - (double)pixelRGB2.R / 255))*255;
                    if ((double)pixelRGB2.G / 255 < 0.5) green = (2 * (double)pixelRGB1.G / 255 * (double)pixelRGB2.G / 255 + (Math.Pow((double)pixelRGB1.G / 255, 2) * (1 - 2 * (double)pixelRGB2.G / 255))) * 255;
                    else green = (Math.Sqrt((double)pixelRGB1.G / 255) * (2 * (double)pixelRGB2.G / 255 - 1) + 2 * (double)pixelRGB1.G / 255 * (1 - (double)pixelRGB2.G / 255)) * 255;
                    if ((double)pixelRGB2.B / 255 < 0.5) blue = (2 * (double)pixelRGB1.B / 255 * (double)pixelRGB2.B / 255 + (Math.Pow((double)pixelRGB1.B / 255, 2) * (1 - 2 * (double)pixelRGB2.B / 255))) * 255;
                    else blue = (Math.Sqrt((double)pixelRGB1.B / 255) * (2 * (double)pixelRGB2.B / 255 - 1) + 2 * (double)pixelRGB1.B / 255 * (1 - (double)pixelRGB2.B / 255)) * 255;


                    if (red > 255) red = 255;
                    else if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    else if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    else if (blue < 0) blue = 0;
                    Color newPixelRGB = Color.FromArgb((int)red, (int)green, (int)blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    try
                    {
                        Color pixelRGB1 = image1.GetPixel(j, i);
                        Color pixelRGB2 = image2.GetPixel(j, i);
                        double red = (((double)pixelRGB1.R / 255) / (1 - (double)pixelRGB2.R / 255)) * 255;
                        double green = (((double)pixelRGB1.G / 255) / (1 - (double)pixelRGB2.G / 255)) * 255;
                        double blue = (((double)pixelRGB1.B / 255) / (1 - (double)pixelRGB2.B / 255)) * 255;
                        if (red > 255) red = 255;
                        else if (red < 0) red = 0;
                        if (green > 255) green = 255;
                        else if (green < 0) green = 0;
                        if (blue > 255) blue = 255;
                        else if (blue < 0) blue = 0;
                        Color newPixelRGB = Color.FromArgb((int)red, (int)green, (int)blue);
                        image1.SetPixel(j, i, newPixelRGB);
                    }
                    catch(Exception excp)
                    {

                    }
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);
                    double red = (1 - (1 - (double)pixelRGB1.R / 255) / ((double)pixelRGB2.R / 255))*255;
                    double green = (1 - (1 - (double)pixelRGB1.G / 255) / ((double)pixelRGB2.G / 255)) * 255;
                    double blue = (1 - (1 - (double)pixelRGB1.B / 255) / ((double)pixelRGB2.B / 255)) * 255;
                    if (red > 255) red = 255;
                    else if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    else if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    else if (blue < 0) blue = 0;
                    Color newPixelRGB = Color.FromArgb((int)red, (int)green, (int)blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button17_Click(object sender, EventArgs e)
        {
                Bitmap image1 = new Bitmap(pictureBox1.Image);
                Bitmap image2 = new Bitmap(pictureBox2.Image);
                int width;
                int height;
                if (image1.Width > image2.Width) width = image2.Width;
                else width = image1.Width;
                if (image1.Height > image2.Height) height = image2.Height;
                else height = image1.Height;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Color pixelRGB1 = image1.GetPixel(j, i);
                        Color pixelRGB2 = image2.GetPixel(j, i);
                        double red = (Math.Pow((double)pixelRGB1.R / 255, 2) / (1 - (double)pixelRGB2.R / 255)) * 255;
                        double green = (Math.Pow((double)pixelRGB1.G / 255, 2) / (1 - (double)pixelRGB2.G / 255)) * 255;
                        double blue = (Math.Pow((double)pixelRGB1.B / 255, 2) / (1 - (double)pixelRGB2.B / 255)) * 255;
                        if (red > 255 || Double.IsNaN(red)) red = 255;
                        else if (red < 0) red = 0;
                        if (green > 255 || Double.IsNaN(green)) green = 255;
                        else if (green < 0) green = 0;
                        if (blue > 255 || Double.IsNaN(blue)) blue = 255;
                        else if (blue < 0) blue = 0;
                        Color newPixelRGB = Color.FromArgb((int)red, (int)green, (int)blue);
                        image1.SetPixel(j, i, newPixelRGB);
                    }
                }
                pictureBox3.Image = image1;
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap(pictureBox1.Image);
            Bitmap image2 = new Bitmap(pictureBox2.Image);
            int width;
            int height;
            if (image1.Width > image2.Width) width = image2.Width;
            else width = image1.Width;
            if (image1.Height > image2.Height) height = image2.Height;
            else height = image1.Height;
            double alpha;
            try
            {
                alpha = Convert.ToDouble(textBox1.Text);
            }
            catch(Exception excp)
            {
                alpha = 0.5;
            }
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixelRGB1 = image1.GetPixel(j, i);
                    Color pixelRGB2 = image2.GetPixel(j, i);

                    double red = ((1 - alpha) * ((double)pixelRGB2.R / 255) + alpha * ((double)pixelRGB1.R / 255))*255;
                    double green = ((1 - alpha) * ((double)pixelRGB2.G / 255) + alpha * ((double)pixelRGB1.G / 255)) * 255;
                    double blue = ((1 - alpha) * ((double)pixelRGB2.B / 255) + alpha * ((double)pixelRGB1.B / 255)) * 255;
                    if (red > 255) red = 255;
                    else if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    else if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    else if (blue < 0) blue = 0;
                    Color newPixelRGB = Color.FromArgb((int)red, (int)green, (int)blue);
                    image1.SetPixel(j, i, newPixelRGB);
                }
            }
            pictureBox3.Image = image1;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
