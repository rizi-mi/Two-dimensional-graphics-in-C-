using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphics_with_C
{
    public partial class Formtest1 : Form
    {
        public Formtest1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Объявляем объект "g" класса Graphics и предоставляем
            // ему возможность рисования на pictureBox1:
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            // Создаем объекты-кисти для закрашивания фигур
            SolidBrush myWeed = new SolidBrush(Color.DarkGreen);
            //Выбираем перо myPen желтого цвета толщиной в 2 пикселя:
            SolidBrush mySun = new SolidBrush(Color.Gold);
            // Закрашиваем фигуры
            g.FillEllipse(mySun, 0, 0, 100, 100); // солнышко(прямоугольник)
            // Море - 12 секторов-полуокружностей
            int x = 50;
            int Radius = 50;
            while (x <= pictureBox1.Width - Radius)
            {
                g.FillPie(myWeed, 0 + x, 375, 50, 50, 0, -180);
                x += 50;
            }
        }
    }
}
