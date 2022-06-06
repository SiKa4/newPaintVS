//Задание выполнил : Фролов Арсений Вадимович. Группа 221П.Практическая работа "Геометрические фигуры - 4". 04.06.2022.
using System;
using System.Collections.Generic;
using System.IO;

class Rectangle : FilledFigure
{
    int Height;
    int Width;

    public Rectangle(Point point, int height, int width, Pen pen) : base(point, pen)
    {
        Height = height;
        Width = width;
    }

    public override void Draw(Graphics g)
    {
        g.DrawRectangle(pen, basePoint.X, basePoint.Y, Width, Height);
    }

    public override string ToString()
    {
        return $"Rectangle [{basePoint}, {Height}, {Width}, {Stroke.Color}, {Stroke.Width}]";
    }
}
