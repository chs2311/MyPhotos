using MyPhotos.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotos
{
    public partial class Form1 : Form
    {
        string PPath = "D:\\Desktop\\Image.jpeg";
        float Zoom = 1.00F;
        Bitmap Picture;
        int ImageWidth = 2716;
        int ImageHeight = 1810;
        int XOffset = 0;
        int YOffset = 0;

        public Form1()
        {
            InitializeComponent();
            PicturePanel.MouseWheel += MouseUsedWheel;
            ImageBox.MouseWheel += MouseUsedWheel;

            Picture = new Bitmap(PPath);
            ImageWidth = Picture.Width;
            ImageHeight = Picture.Height;
            ImageBox.Size = new Size(ImageWidth, ImageHeight);
            ImageBox.BackgroundImage = Picture;
            AdjustImage();
        }

        private void ZoomSub_Click(object sender, EventArgs e)
        {
            Zoom -= 0.10F;
            AdjustImage();
        }

        private void ZoomAdd_Click(object sender, EventArgs e)
        {
            Zoom += 0.10F;
            AdjustImage();
        }

        private void AdjustImage()
        {
            if(Zoom < 0.05F)
            {
                Zoom = 0.05F;
            }
            else if(Zoom > 5.00F)
            {
                Zoom = 5.00F;
            }

            ImageBox.Size = new Size((int)(Zoom * ImageWidth), (int)(Zoom * ImageHeight));

            ImageBox.Location = GetCenter(true);
        }

        private Point GetCenter(bool withOffset)
        {
            if(!withOffset)
            {
                return new Point((PicturePanel.Width - ImageBox.Width) / 2,
                    (PicturePanel.Height - ImageBox.Height) / 2);
            }

            return new Point((PicturePanel.Width - ImageBox.Width) / 2 + XOffset,
                (PicturePanel.Height - ImageBox.Height) / 2 + YOffset);
        }
        
        private void MouseMoving(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int x = e.X + ImageBox.Left - PrevMouse.X;
                int y = e.Y + ImageBox.Top - PrevMouse.Y;

                int cx = GetCenter(false).X;
                int cy = GetCenter(false).Y;

                XOffset = x - cx;
                YOffset = y - cy;

                ImageBox.Location = new Point(x, y);
            }
        }

        Point PrevMouse;
        private void MouseUsedWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                Zoom += 0.03F;
            }
            else if (e.Delta < 0)
            {
                Zoom -= 0.03F;
            }

            AdjustImage();
        }

        private void MouseButtonDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                PrevMouse = e.Location;
            }
        }

        private void CenterImg_Click(object sender, EventArgs e)
        {
            Picture = new Bitmap(PPath);
            ImageWidth = Picture.Width;
            ImageHeight = Picture.Height;
            ImageBox.Size = new Size(ImageWidth, ImageHeight);
            ImageBox.BackgroundImage = Picture;
            XOffset = 0;
            YOffset = 0;
            Zoom = 1.00F;
            AdjustImage();
        }

        private void ApplyEffect(PixelFormat form)
        {
            Picture = Picture.Clone(new Rectangle(0, 0, Picture.Width, Picture.Height), form);
            ImageBox.BackgroundImage = Picture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int y = 0; y < Picture.Height; y++)
            {
                for(int x = 0; x < Picture.Width; x++)
                {
                    Color c = Picture.GetPixel(x, y);
                    int nv = (c.R + c.G + c.B) / 3;
                    Picture.SetPixel(x, y, Color.FromArgb(nv, nv, nv));
                }
            }

            ImageBox.BackgroundImage = Picture;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplyEffect(PixelFormat.Format1bppIndexed);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplyEffect(PixelFormat.Format4bppIndexed);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApplyEffect(PixelFormat.Format8bppIndexed);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ApplyEffect(PixelFormat.Format16bppArgb1555);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ApplyEffect(PixelFormat.Format24bppRgb);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ApplyEffect(PixelFormat.Format32bppArgb);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for(int y = 0; y < Picture.Height; y++)
            {
                for(int x = 0; x < Picture.Width; x++)
                {
                    Color col = Picture.GetPixel(x, y);
                    int outputRed   = (int)((col.R * 0.393) + (col.G * 0.769) + (col.B * 0.189));
                    int outputGreen = (int)((col.R * 0.349) + (col.G * 0.686) + (col.B * 0.168));
                    int outputBlue  = (int)((col.R * 0.272) + (col.G * 0.534) + (col.B * 0.131));

                    if(outputRed > 255) 
                    {
                        outputRed = 255;
                    }
                    if(outputGreen > 255) 
                    {
                        outputGreen = 255;
                    }
                    if (outputBlue > 255)
                    {
                        outputBlue = 255;
                    }

                    Picture.SetPixel(x, y, Color.FromArgb(outputRed, outputGreen, outputBlue));
                }
            }

            ImageBox.BackgroundImage = Picture;
        }
    }
}
