//Задание выполнил : Фролов Арсений Вадимович. Группа 221П.Практическая работа "Геометрические фигуры - 4". 04.06.2022.
using System;
using System.Collections.Generic;
using System.IO;


class Circle : FilledFigure
{
    public int Radius;

    public Circle(Point point, int radius, Pen pen) : base(point, pen)
    {
        Radius = radius;
    }

    public override void Draw(Graphics g)
    {
        g.DrawEllipse(pen, basePoint.X, basePoint.Y, Radius, Radius);
    }

    public override string ToString()
    {
        return $"Circle [{basePoint}, {Radius}, {Stroke.Color}, {Stroke.Width}]";
    }
}