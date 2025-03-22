using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KG
{
    public partial class Form4 : Form
    {
        public int xn, yn, xk, yk;
        Bitmap myBitmap;
        Color currentBorderColor;
        Color currentFillColor;
        Graphics g;
        SolidBrush Brush;
        private ColorDialog fillColorDialog = new ColorDialog();

        public Form4()
        {
            InitializeComponent();
            myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(myBitmap);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = myBitmap;
            numericUpDownLineWidth.Minimum = 1; 
            numericUpDownLineWidth.Maximum = 20; 
            numericUpDownLineWidth.Value = 1; 
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                xk = e.X;
                yk = e.Y;
                NesimCDA(xn, yn, xk, yk);
                pictureBox1.Image = myBitmap;
            }
        }

        private void NesimCDA(int xStart, int yStart, int xEnd, int yEnd)
        {
            double xOutput, yOutput, Px, Py;
            xn = xStart;
            yn = yStart;
            xk = xEnd;
            yk = yEnd;
            Px = xk - xn;
            Py = yk - yn;
            xOutput = xn;
            yOutput = yn;
            int lineWidth = (int)numericUpDownLineWidth.Value; // Получаем толщину линии
            Pen myPen = new Pen(currentBorderColor, lineWidth); // Создаем перо с выбранной толщиной
            int Xstep = (xk > xn) ? 1 : (xk < xn) ? -1 : 0;
            int Ystep = (yk > yn) ? 1 : (yk < yn) ? -1 : 0;

            if (Math.Abs(Px) >= Math.Abs(Py))
            {
                while ((Xstep == 1 && xOutput <= xk) || (Xstep == -1 && xOutput >= xk))
                {
                    // Рисуем линию с учетом толщины
                    g.DrawRectangle(myPen, (int)xOutput, (int)yOutput, lineWidth, lineWidth);
                    xOutput += Xstep;
                    yOutput += (Py / Px) * Xstep;
                }
            }
            else if (Math.Abs(Py) > Math.Abs(Px))
            {
                while ((Ystep == 1 && yOutput <= yk) || (Ystep == -1 && yOutput >= yk))
                {
                    // Рисуем линию с учетом толщины
                    g.DrawRectangle(myPen, (int)xOutput, (int)yOutput, lineWidth, lineWidth);
                    xOutput += (Px / Py) * Ystep;
                    yOutput += Ystep;
                }
            }

            pictureBox1.Image = myBitmap; // Обновляем изображение
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void FloodFill(int x, int y, Color newColor)
        {
            Color oldColor = myBitmap.GetPixel(x, y);
            if (oldColor.ToArgb() == newColor.ToArgb())
                return;

            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(x, y));

            while (stack.Count > 0)
            {
                Point current = stack.Pop();
                int x1 = current.X;
                int y1 = current.Y;

                if (x1 < 0 || x1 >= myBitmap.Width || y1 < 0 || y1 >= myBitmap.Height)
                    continue;

                if (myBitmap.GetPixel(x1, y1).ToArgb() != oldColor.ToArgb())
                    continue;

                myBitmap.SetPixel(x1, y1, newColor);

                stack.Push(new Point(x1 + 1, y1));
                stack.Push(new Point(x1 - 1, y1));
                stack.Push(new Point(x1, y1 + 1));
                stack.Push(new Point(x1, y1 - 1));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void _2lab_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                xn = e.X;
                yn = e.Y;
            }
            else if (radioButton2.Checked)
            {
                btnClear.Enabled = false;
                FloodFill(e.X, e.Y, currentFillColor);
                btnClear.Enabled = true;
                pictureBox1.Image = myBitmap;
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = myBitmap;
        }

        private void btnColorLine_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK && radioButton1.Checked)
            {
                currentBorderColor = colorDialog1.Color;
            }
        }

        private void btnColorFill_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = fillColorDialog.ShowDialog(); // Используем отдельный ColorDialog
            if (dialogResult == DialogResult.OK)
            {
                currentFillColor = fillColorDialog.Color; // Сохраняем выбранный цвет заливки
            }
        }

        private void btnCountour_Click(object sender, EventArgs e)
        {
            // Открытие диалогового окна для выбора цвета обхода контура
            DialogResult dialogResult = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Color contourColor = colorDialog1.Color; // Выбранный цвет обхода контура
                                                         // Запуск обхода контура
                ProhodTOContur(contourColor);
            }
        }

        private void ProhodTOContur(Color contourColor)
        {
            // Сначала ищем пиксель, принадлежащий контуру, начиная с верхнего левого угла
            Point startPoint = PoiskTochki();
            if (startPoint == Point.Empty)
            {
                MessageBox.Show("Вы не задали контур");
                return; // Если контур не найден, выходим
            }
            Stack<Point> stack = new Stack<Point>();
            stack.Push(startPoint);

            while (stack.Count > 0)
            {
                Point current = stack.Pop();
                // Проверяем, является ли текущий пиксель частью контура
                if (myBitmap.GetPixel(current.X, current.Y).ToArgb() == currentBorderColor.ToArgb())
                {
                    // Меняем цвет пикселя на цвет обхода
                    myBitmap.SetPixel(current.X, current.Y, contourColor);
                    pictureBox1.Image = myBitmap; // Обновляем изображение

                    // Позволяем UI обновляться
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(0); // Задержка для визуализации

                    // Добавляем соседние пиксели в стек
                    ProverkaThochki(current, stack);
                }
            }
        }

        private Point PoiskTochki()
        {
            for (int y = 0; y < myBitmap.Height; y++)
            {
                for (int x = 0; x < myBitmap.Width; x++)
                {
                    if (myBitmap.GetPixel(x, y).ToArgb() == currentBorderColor.ToArgb())
                    {
                        return new Point(x, y); // Возвращаем первый найденный пиксель контура
                    }
                }
            }
            return Point.Empty; // Контур не найден
        }

        private void ProverkaThochki(Point point, Stack<Point> stack)
        {
            // Проверяем 4 соседних пикселя (вверх, вниз, влево, вправо)
            Point[] neighbors =
            {
            new Point(point.X + 1, point.Y),
            new Point(point.X - 1, point.Y),
            new Point(point.X, point.Y + 1),
            new Point(point.X, point.Y - 1)
            };

            foreach (Point neighbor in neighbors)
            {
                // Проверяем, что сосед находится в пределах границ
                if (neighbor.X >= 0 && neighbor.X < myBitmap.Width &&
                    neighbor.Y >= 0 && neighbor.Y < myBitmap.Height)
                {
                    // Проверяем, является ли это пиксель частью контура
                    if (myBitmap.GetPixel(neighbor.X, neighbor.Y).ToArgb() == currentBorderColor.ToArgb())
                    {
                        stack.Push(neighbor);
                    }
                }
            }
        }
    }
}