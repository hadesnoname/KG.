using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class _2lab : Form
    {
        public int xn, yn, xk, yk;
        Bitmap myBitmap;
        Color currentBorderColor;
        Color currentFillColor;
        Graphics g;

        public _2lab()
        {
            InitializeComponent();
            myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(myBitmap);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = myBitmap;
            numericUpDownLineWidth.Minimum = 1;
            numericUpDownLineWidth.Maximum = 10;
            numericUpDownLineWidth.Value = 1;
        }
            
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                int index, numberNodes;
                double xOutput, yOutput, dx, dy;
                int lineWidth = (int)numericUpDownLineWidth.Value;
                Pen myPen = new Pen(currentBorderColor, lineWidth);
                xk = e.X;
                yk = e.Y;
                dx = xk - xn;
                dy = yk - yn;
                numberNodes = 200;
                xOutput = xn;
                yOutput = yn;
                for (index = 1; index <= numberNodes; index++)
                {
                    g.DrawRectangle(myPen, (int)xOutput, (int)yOutput, 2, 2);
                    xOutput = xOutput + dx / numberNodes;
                    yOutput = yOutput + dy / numberNodes;
                }

                pictureBox1.Image = myBitmap;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = myBitmap;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK && radioButton1.Checked)
            {
                currentBorderColor = colorDialog1.Color;
            }

        }

        private void FloodFill(int x1, int y1)
        {
            Color oldPixelColor = myBitmap.GetPixel(x1, y1);
            if ((oldPixelColor.ToArgb() != currentBorderColor.ToArgb())
           && (oldPixelColor.ToArgb() != currentFillColor.ToArgb()))
            {
                myBitmap.SetPixel(x1, y1, currentFillColor);
                FloodFill(x1 + 1, y1);
                FloodFill(x1 - 1, y1);
                FloodFill(x1, y1 + 1);
                FloodFill(x1, y1 - 1);
            }
            else
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            if (radioButton1.Checked == true)
            {
                CDA(10, 10, 10, 110);
                CDA(10, 10, 110, 10);
                CDA(10, 110, 110, 110);
                CDA(110, 10, 110, 110);

                CDA(150, 10, 150, 200);
                CDA(250, 50, 150, 200);
                CDA(150, 10, 250, 150);
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    xn = 160;
                    yn = 40;
                    FloodFill(xn, yn);
                }
            }
            pictureBox1.Image = myBitmap;
            button1.Enabled = true;
            button2.Enabled = true;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void _2lab_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                xn = e.X;
                yn = e.Y;
            }

            else
            {
                button1.Enabled = false;
                button2.Enabled = false;

                FloodFill(e.X, e.Y);

                button1.Enabled = true;
                button2.Enabled = true;
                pictureBox1.Image = myBitmap;
            }

        }
        private void CDA(int xStart, int yStart, int xEnd, int yEnd)
        {
            int index, numberNodes;
            double xOutput, yOutput, dx, dy;
            int lineWidth = (int)numericUpDownLineWidth.Value;
            Pen myPen = new Pen(currentBorderColor, lineWidth);

            xn = xStart;
            yn = yStart;
            xk = xEnd;
            yk = yEnd;
            dx = xk - xn;
            dy = yk - yn;
            numberNodes = 200;
            xOutput = xn;
            yOutput = yn;
            for (index = 1; index <= numberNodes; index++)
            {
                g.DrawRectangle(myPen, (int)xOutput, (int)yOutput, 2, 2);
                xOutput = xOutput + dx / numberNodes;
                yOutput = yOutput + dy / numberNodes;
            }

            pictureBox1.Image = myBitmap;
            pictureBox1.Image = myBitmap;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                currentFillColor = colorDialog1.Color; 
            }
        }
    }
}

