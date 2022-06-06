//Задание выполнил : Фролов Арсений Вадимович. Группа 221П.Практическая работа "Геометрические фигуры - 4". 04.06.2022.
using System;
using System.Collections.Generic;
using System.IO;

class Line : Figure
{
    public Point A
    {
        get { return basePoint; }
        set { basePoint = value; }
    }
    public Point B;

    public StrokeData Stroke;

    public Line(Point a, Point b, Pen pen) : base(a, pen)
    {
        B = b;
        Stroke.Color = pen.Color.ToArgb();
        Stroke.Width = Convert.ToInt32(pen.Width);
    }

    public override void Draw(Graphics g)
    {
        g.DrawLine(pen, A.X, A.Y, B.X, B.Y);
    }

    public override string ToString()
    {
        return $"Line [{A}, {B}, {Stroke.Color}, {Stroke.Width}]";
    }
}
