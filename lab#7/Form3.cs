using System;
using System.Drawing;
using System.Drawing.Drawing2D; 
using System.Windows.Forms;

namespace Graphics_with_C
{
    public partial class Form3 : Form
    {
        Graphics g;
        public Form3()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(this.Handle); // холст
            // сглаживание: enum SmoothingMode
            g.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void очисткаЭкранаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);
        }
        private Point[] star5(int x, int y, int r) // звезда
        {
            Point point1 = new Point(x, y - 6 * r);
            Point point2 = new Point(x + 2 * r, y - 3 * r);
            Point point3 = new Point(x + 6 * r, y - 2 * r);
            Point point4 = new Point(x + 3 * r, y + r);
            Point point5 = new Point(x + 4 * r, y + 5 * r);
            Point point6 = new Point(x, y + 3 * r);
            Point point7 = new Point(x - 4 * r, y + 5 * r);
            Point point8 = new Point(x - 3 * r, y + r);
            Point point9 = new Point(x - 6 * r, y - 2 * r);
            Point point10 = new Point(x - 2 * r, y - 3 * r);
            Point[] pm = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };
            return pm;
        }

        private void незамкнутаяЛоманаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen redPen = new Pen(Color.Red, 2f);
            // Задание 10 точек, определяющих незамкнутую ломаную
            Point[] pm = star5(200, 200, 25);
            // Рисование незамкнутой ломаной из отрезков (Line)
            g.DrawLines(redPen, pm); // для замыкания добавьте первую точку
        }

        private void замкнутаяЛоманаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen greenPen = new Pen(Color.Green, 2f);
            // Задание 10 точек, определяющих замкнутую область "звезда"
            Point[] pm = star5(250, 220, 25);
            // Рисование замкнутой ломаной из отрезков
            g.DrawClosedCurve(greenPen, pm, 0f, FillMode.Winding);
            // Упругость: 0f - беск.физ.упругость - прямыми;
        }

        private void замкнутыйСплайнToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(RandomColor(), 2f);
            // Задание точек, определяющих кривую
            Point[] pm = star5(500, 200, 25);
            float elasticity = Convert.ToSingle(textBox1.Text);
            // - упругость
            // Рисование замкнутой кривой через 10 точек сплайном
            //g.DrawClosedCurve(bluePen, pm, elasticity, FillMode.Alternate);
            // Упругость: 0f - беск.физ.упругость - прямыми;
            // 1f - отсутствие физ.упругости, наименьший суммарный изгиб
            // >1 - сдавленный берегами ручей, стремящийся увеличить изгиб своих излучин и течь по более длинному пути.
            g.DrawClosedCurve(pen, pm, elasticity, FillMode.Alternate);

        }

        private void незамкнутыйСплайнToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(RandomColor(), 3f);
            // Задание точек, определяющих кривую
            Point[] pm = star5(400, 200, 25);
            float elasticity =
            Convert.ToSingle(textBox1.Text);
            // Рисование незамкнутой кривой через 10 точек сплайном
            g.DrawCurve(pen, pm, elasticity);
        }
        public Color RandomColor()
        {
            int r, g, b;
            byte[] bytes1 = new byte[3]; // массив 3 цветов
            Random rnd1 = new Random();
            rnd1.NextBytes(bytes1); // генерация в массив
            r = Convert.ToInt16(bytes1[0]);
            g = Convert.ToInt16(bytes1[1]);
            b = Convert.ToInt16(bytes1[2]);
            return Color.FromArgb(r, g, b); // возврат цвета
        }

        private void однаКриваяБезьеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // кривая Безье: 4 точки (x,y) - старт,
            // управление1, управление2, end
            Point start = new Point(500, 100);
            Point control1 = new Point(500, 300);
            Point control2 = new Point(700, 300);
            Point finish = new Point(800, 100);
            g.DrawBezier(new Pen(Color.Black, 3), start,
            control1, control2, finish); // это кривая Безье, дальше - для наглядности
            SolidBrush br = new SolidBrush(Color.Green);
            Pen pen = new Pen(Color.Green, 1);
            g.FillEllipse(br, start.X - 5, start.Y - 5, 11, 11);
            g.FillEllipse(br, control1.X - 5, control1.Y - 5, 11, 11);
            g.FillEllipse(br, control2.X - 5, control2.Y - 5, 11, 11);
            g.FillEllipse(br, finish.X - 5, finish.Y - 5, 11, 11);
            g.DrawLine(pen, start, control1);
            g.DrawLine(pen, finish, control2);

        }

        private void незамкнутаяКриваяБезьеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Зададим точки для 2-х кривых Безье - всего 7.
            Point start = new Point(500, 100);
            Point control1 = new Point(750, 50);
            Point control2 = new Point(510, 310);
            Point end1 = new Point(500, 300);
            Point control3 = new Point(490, 310);
            Point control4 = new Point(240, 50);
            Point end2 = new Point(490, 100);
            Point[] bezierPoints =
            {start, control1, control2, end1, control3, control4, end2};
            // Рисуем
            g.DrawBeziers(new Pen(Color.Red, 3), bezierPoints);
        }

        private void замкнутаяКриваяБезьеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Зададим точки для 2-х кривых Безье - всего 7.
            Point start = new Point(600, 150);
            Point control1 = new Point(850, 100);
            Point control2 = new Point(610, 360);
            Point end1 = new Point(600, 350);
            Point control3 = new Point(590, 360);
            Point control4 = new Point(350, 100);
            Point end2 = start; // первая и третья точкисовпадают
            Point[] bezierPoints ={start, control1, control2, end1, control3,control4, end2};
            // Рисуем
            g.DrawBeziers(new Pen(Color.Orange, 4),
            bezierPoints);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
