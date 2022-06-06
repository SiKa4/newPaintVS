//Задание выполнил : Фролов Арсений Вадимович. Группа 221П.Практическая работа "Геометрические фигуры - 4". 04.06.2022.
using System.Runtime.Serialization.Formatters.Binary;

namespace PaintVS
{
    public partial class FormPaint : Form
    {
        Bitmap bmp;
        Figures figures;
        Pen pen;
        int x, y, x2, y2;
        bool clearOK;
        int selectedFig;
        Point[] pntTrngl;
        int cntTriangle;
        bool drawClick;

        public FormPaint()
        {
            InitializeComponent();
            bmp = new Bitmap(PicBox.ClientSize.Width, PicBox.ClientSize.Height);
            pen = new Pen(Color.Black, 3);

            figures = new Figures();
            picBoxColor.BackColor = Color.Black;
            clearOK = false;
            selectedFig = 0;
            pntTrngl = new Point[3];
            cntTriangle = 0;
            drawClick = false;
        }

        private void FormPaint_Resize(object sender, EventArgs e)
        {
            if (PicBox.ClientSize.Width > bmp.Width || PicBox.ClientSize.Height > bmp.Height)
            {
                bmp = new Bitmap(PicBox.ClientSize.Width, PicBox.ClientSize.Height);

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    figures.DrawFigures(g);
                }

                PicBox.Image = bmp;
            }
        }

        private void DrawingShapes(Figure figure)
        {
            figures.Add(figure);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                figure.Draw(g);
            }

            PicBox.Image = bmp;
        }

        private void Bin_Click(object sender, EventArgs e)
        {
            if (figures.getCount() != 0)
            {
                PicBox.Visible = false;
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear all the information without saving it?",
                "Are you sure?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    figures = new Figures();
                    bmp = new Bitmap(PicBox.ClientSize.Width, PicBox.ClientSize.Height);
                    PicBox.Image = null;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

                PicBox.Visible = true;
            }
            clearOK = true;
        }

        private void PicBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (drawClick)
            {
                switch (selectedFig)
                {
                    case 1:
                        g.DrawLine(pen, x, y, x2, y2);
                        break;

                    case 2:
                        g.DrawEllipse(pen, x, y, y2 - y, y2 - y);
                        break;

                    case 3:
                        g.DrawRectangle(pen, x, y, x2 - x, y2 - y);
                        break;

                    case 4:
                        if (cntTriangle == 1)
                        {
                            g.DrawLine(pen, pntTrngl[0].X, pntTrngl[0].Y, x2, y2);
                        }
                        else if (cntTriangle > 1)
                        {
                            g.DrawLine(pen, pntTrngl[0].X, pntTrngl[0].Y, pntTrngl[1].X, pntTrngl[1].Y);
                            g.DrawLine(pen, pntTrngl[0].X, pntTrngl[0].Y, x2, y2);
                            g.DrawLine(pen, pntTrngl[1].X, pntTrngl[1].Y, x2, y2);
                        }
                        break;
                }
            }
            PicBox.Image = bmp;
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            selectedFig = 1;
            cntTriangle = 0;
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            selectedFig = 2;
            cntTriangle = 0;
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            selectedFig = 3;
            cntTriangle = 0;
        }

        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            selectedFig = 4;
        }

        private void PicBox_MouseMove(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;

            if (selectedFig == 4)
            {
                if (cntTriangle == 2)
                {
                    pntTrngl[2].X = x2;
                    pntTrngl[2].Y = y2;
                }
            }
        }

        private void PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            drawClick = true;
            x = e.X;
            y = e.Y;

            if (selectedFig == 4)
            {
                if (cntTriangle == 0)
                {
                    pntTrngl[0].X = x;
                    pntTrngl[0].Y = y;
                    cntTriangle++;
                }
            }
        }
        private void PicBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawClick)
            {
                if (x != x2 && y != y2)
                {
                    switch (selectedFig)
                    {
                        case 1:
                            Line line = new Line(new Point(x, y), new Point(x2, y2), pen);
                            DrawingShapes(line);
                            break;

                        case 2:
                            Circle circle = new Circle(new Point(x, y), y2 - y, pen);
                            DrawingShapes(circle);
                            break;

                        case 3:
                            Rectangle rectangle = new Rectangle(new Point(x, y), y2 - y, x2 - x, pen);
                            DrawingShapes(rectangle);
                            break;
                        case 4:
                            if (cntTriangle == 1)
                            {
                                pntTrngl[1].X = x2;
                                pntTrngl[1].Y = y2;
                                cntTriangle++;
                            }

                            else if (cntTriangle == 2)
                            {
                                Triangle triangle = new Triangle(new Point(pntTrngl[0].X, pntTrngl[0].Y), 
                                    new Point(pntTrngl[1].X, pntTrngl[1].Y), new Point(pntTrngl[2].X, pntTrngl[2].Y), pen);
                                DrawingShapes(triangle);
                                cntTriangle = 0;
                            }
                            break;
                    }
                }
                drawClick = false;
            }
        }

        private void picBoxColor_Click(object sender, EventArgs e)
        {
            PicBox.Visible = false;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                picBoxColor.BackColor = colorDialog.Color;
                pen.Color = colorDialog.Color;
            }
            PicBox.Visible = true;
        }

        private void sizeBar_Scroll(object sender, EventArgs e)
        {
            pen.Width = sizeBar.Value;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (figures.getCount() != 0)
                {
                    figures.Save(saveFile.FileName);
                }
                else
                {
                    MessageBox.Show("The file was not saved because there is no information about the figures.", "Error");
                }
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Bin_Click(sender, e);

                if (clearOK)
                {
                    figures.Load(openFile.FileName);

                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        figures.DrawFigures(g);
                    }

                    PicBox.Image = bmp;
                }
            }
            clearOK = false;
        }
    }
}