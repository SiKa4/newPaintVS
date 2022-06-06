//Задание выполнил : Фролов Арсений Вадимович. Группа 221П.Практическая работа "Геометрические фигуры - 4". 04.06.2022.
using System;
using System.Collections.Generic;
using System.IO;

abstract class FilledFigure : Figure
{
    protected FillData Fill;
    protected StrokeData Stroke;

    public FilledFigure(Point point, Pen pen) : base(point, pen)
    {
        Stroke.Color = pen.Color.ToArgb();
        Stroke.Width = Convert.ToInt32(pen.Width);
    }
}

