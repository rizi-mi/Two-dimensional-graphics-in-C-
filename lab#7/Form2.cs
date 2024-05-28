using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Graphics_with_C
{
    public partial class Form2 : Form
    {
        private const int ParagliderSize = 200;
        private const int ParagliderInnerSize = ParagliderSize / 2;
        private bool drawParaglider = false;
        private bool drawInnerParaglider = false;
        private bool fillParaglider = false;
        private bool fillInnerParaglider = false;
        Graphics g; // холст
        GraphicsPath pp; // контур фантома-дырки
        SolidBrush br; // кисть
        public Form2() // конструктор формы
        {
            InitializeComponent();
            g = Graphics.FromHwnd(this.Handle); // холст
            pp = paraplan(450, 130, 20); // положение и размер
            // фантома-дырки
        }
        // метод возвращает контур с центром в точке (x,y)
        // и размером клетки r. Нарисуйте его на бумаге.
        private GraphicsPath paraplan(int x, int y, int r)
        {
            int[,] pts = { { x - 4 * r, y }, { x - 2 * r, y - r }, { x + 2 * r, y - r }, { x + 4 * r, y }, { x + 3 * r, y + r }, { x + r, y }, { x - r, y }, { x - 3 * r, y + r }, { x - 4 * r, y } }; // параплан через массив pts
            Point[] pt = new Point[9]; // массив точек для gp
            byte[] typ = new byte[9]; // массив соединений
            for (int p = 0; p < 9; p++)
            {
                pt[p].X = pts[p, 0];
                pt[p].Y = pts[p, 1];
                typ[p] = (byte)PathPointType.Line;
                //ломаными,
                // PathPointType описан в System.Drawing.Drawing2D;
            };
            GraphicsPath gp = new GraphicsPath(pt, typ);
            return gp; // возвращаем внутренняя часть формы
        }
        // создает фантом-дырку и рисует поверх нее параплан


        private void button1_Click(object sender, EventArgs e)
        {
            drawParaglider = true;
            drawInnerParaglider = false;
            fillParaglider = false;
            fillInnerParaglider = false;
            Invalidate();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            drawParaglider = false;
            drawInnerParaglider = false;
            fillParaglider = true;
            fillInnerParaglider = false;
            Invalidate();
        }

        public Color RandomColor()
        {
            int r, g, b;
            byte[] bytes1 = new byte[3]; // массив 3 цветов
            Random rnd1 = new Random(); // объект класса
            rnd1.NextBytes(bytes1); // генерация массива
            r = Convert.ToInt16(bytes1[0]);
            g = Convert.ToInt16(bytes1[1]);
            b = Convert.ToInt16(bytes1[2]);
            return Color.FromArgb(r, g, b); // цвет через метод
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // Метод обновляет отсеченную область gp
            Region gp = new Region(pp);
            g.ExcludeClip(gp);
            // Рисуем параплан большего размера
            GraphicsPath pp1 = paraplan(450, 180, 80); //контур
            br = new SolidBrush(RandomColor()); //кисть
            g.FillPath(br, pp1); //закраска
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawParaglider = false;
            drawInnerParaglider = true;
            fillParaglider = false;
            fillInnerParaglider = false;
            Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                drawParaglider = false;
                drawInnerParaglider = false;
                fillParaglider = false;
                fillInnerParaglider = true;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (drawParaglider)
            {
                DrawParaglider(e.Graphics, Pens.Black);
            }

            if (drawInnerParaglider)
            {
                DrawParaglider(e.Graphics, Pens.Black);
                DrawParaglider(e.Graphics, Pens.Black, ParagliderSize / 2, ParagliderSize / 2, ParagliderInnerSize);
            }

            if (fillParaglider)
            {
                DrawFilledParaglider(e.Graphics, Brushes.Yellow);
            }

            if (fillInnerParaglider)
            {
                DrawFilledParaglider(e.Graphics, Brushes.Yellow);
                DrawFilledParaglider(e.Graphics, Brushes.LightBlue, ParagliderSize / 2, ParagliderSize / 2, ParagliderInnerSize);
            }

        }

        private void DrawParaglider(Graphics g, Pen pen, int startX = 0, int startY = 0, int size = ParagliderSize)
        {
            g.DrawLine(pen, startX + size / 2, startY, startX + size / 2, startY + size / 2);
            g.DrawLine(pen, startX + size / 2, startY + size / 2, startX, startY + size);
            g.DrawLine(pen, startX + size / 2, startY + size / 2, startX + size, startY + size);
            g.DrawLine(pen, startX, startY + size, startX + size, startY + size);
            g.DrawLine(pen, startX, startY + size, startX + size / 4, startY + size / 4 * 3);
            g.DrawLine(pen, startX + size, startY + size, startX + size / 4 * 3, startY + size / 4 * 3);
        }

        private void DrawFilledParaglider(Graphics g, Brush brush, int startX = 0, int startY = 0, int size = ParagliderSize)
        {
            g.FillPolygon(brush, new Point[]{
                new Point(startX + size / 2, startY),
                new Point(startX + size / 2, startY + size / 2),
                new Point(startX, startY + size),
                new Point(startX + size, startY + size)
            });
            g.DrawLine(Pens.Black, startX + size / 2, startY, startX + size / 2, startY + size / 2);
            g.DrawLine(Pens.Black, startX + size / 2, startY + size / 2, startX, startY + size);
            g.DrawLine(Pens.Black, startX + size / 2, startY + size / 2, startX + size, startY + size);
            g.DrawLine(Pens.Black, startX, startY + size, startX + size, startY + size);
        }

    }
}

