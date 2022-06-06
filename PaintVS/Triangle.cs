//Задание выполнил : Фролов Арсений Вадимович. Группа 221П.Практическая работа "Геометрические фигуры - 4". 04.06.2022.
using System;
using System.Collections.Generic;
using System.IO;

class Triangle : FilledFigure
{
    public Point A
    {
        get { return basePoint; }
        set { basePoint = value; }
    }
    public Point B;
    public Point C;

    public Triangle(Point a, Point b, Point c, Pen pen) : base(a, pen)
    {
        B = b;
        C = c;
    }


    public override void Draw(Graphics g)
    {
        System.Drawing.Point[] points = new System.Drawing.Point[3];
        points[0].X = A.X; points[0].Y = A.Y;
        points[1].X = B.X; points[1].Y = B.Y;
        points[2].X = C.X; points[2].Y = C.Y;

        g.DrawPolygon(pen, points);
    }

    public override string ToString()
    {
        return $"Triangle [{A}, {B}, {C}, {Stroke.Color}, {Stroke.Width}] ";
    }
}
