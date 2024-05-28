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
            
        }

        private void Formtest1_Load(object sender, EventArgs e)
        {
           
                // Создаем новый объект Bitmap с размерами pictureBox
                Bitmap landscapeBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                // Создаем новый объект Graphics из Bitmap
                Graphics landscapeGraphics = Graphics.FromImage(landscapeBitmap);

                // Задаем фоновый цвет пейзажа
                landscapeGraphics.Clear(Color.LightBlue);

                // Рисуем облака
                DrawClouds(landscapeGraphics);

                // Рисуем солнце
                DrawSun(landscapeGraphics);

                // Рисуем деревья
                DrawTrees(landscapeGraphics);

                // Отображаем нарисованный пейзаж на pictureBox
                pictureBox1.Image = landscapeBitmap;
        }

            private void DrawClouds(Graphics graphics)
            {
                // Задаем параметры для рисования облаков
                int cloudCount = 5;
                int cloudWidth = pictureBox1.Width / cloudCount;
                int cloudHeight = pictureBox1.Height / 10;
                int cloudY = pictureBox1.Height / 3;

                // Рисуем каждое облако
                for (int i = 0; i < cloudCount; i++)
                {
                    int cloudX = i * cloudWidth;
                    Rectangle cloudRect = new Rectangle(cloudX, cloudY, cloudWidth, cloudHeight);
                    graphics.FillEllipse(Brushes.White, cloudRect);
                }
            }

            private void DrawSun(Graphics graphics)
            {
                // Задаем параметры для рисования солнца
                int sunRadius = 50;
                int sunX = pictureBox1.Width - (sunRadius * 2);
                int sunY = 50;
                Rectangle sunRect = new Rectangle(sunX, sunY, sunRadius * 2, sunRadius * 2);

                // Рисуем солнце как овал желтого цвета
                graphics.FillEllipse(Brushes.Yellow, sunRect);
            }

            

            private void DrawTrees(Graphics graphics)
            {
                // Задаем параметры для рисования деревьев
                int treeCount = 5;
                int treeWidth = pictureBox1.Width / treeCount;

                // Рисуем каждое дерево
                for (int i = 0; i < treeCount; i++)
                {
                    int treeX = i * treeWidth;
                    graphics.FillRectangle(Brushes.Brown, treeX, pictureBox1.Height - (treeWidth * 3), treeWidth / 3, treeWidth * 3);
                    graphics.FillEllipse(Brushes.Green, treeX - (treeWidth / 2), pictureBox1.Height - (treeWidth * 4), treeWidth * 2, treeWidth * 2);
                }
            }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
    

