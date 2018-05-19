using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Brightness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(pictureBox1.Image);
            int r, g, b;
            Color c;
            int val = (int)Convert.ToInt16(textBox1.Text);
            Cursor = Cursors.WaitCursor;
            for(int i=0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    r = c.R + val;
                    g = c.G + val;
                    b = c.B + val;
                    if (r > 255) r = 255;
                    if (g > 255) g = 255;
                    if (b > 255) b = 255;
                    if (r < 0) r = 0;
                    if (g < 0) g = 0;
                    if (b < 0) b = 0;
                    bmp2.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Image = bmp2;
            Cursor = Cursors.Default;
        }
    }
}
