//Задание выполнил : Фролов Арсений Вадимович. Группа 221П.Практическая работа "Геометрические фигуры - 4". 04.06.2022.
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

abstract class Figure
{
    protected Point basePoint;
    protected Pen pen;

    public Figure(Point point, Pen pen)
    {
        basePoint = point;
        this.pen = new Pen(pen.Color, pen.Width);
    }

    public Figure(int x = 0, int y = 0)
    {
        basePoint = new Point(x, y);
        pen = new Pen(Color.Black, 3);
    }

    public virtual void Draw(Graphics g) { }

}
