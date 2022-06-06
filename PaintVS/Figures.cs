//Задание выполнил : Фролов Арсений Вадимович. Группа 221П.Практическая работа "Геометрические фигуры - 4". 04.06.2022.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

class Figures
{
    private List<Figure> lst;

    public Figures()
    {
        lst = new List<Figure>();
    }

    public void Add(Figure figure)
    {
        lst.Add(figure);
    }

    public void Save(string path)
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            foreach (Figure i in lst)
            {
                sw.WriteLine(i);
            }
        }
    }

    public void Load(string path)
    {
        string? line;
        int[] numbers;

        using (StreamReader sr = new StreamReader(path))
        {
            line = sr.ReadLine();
            while (line != null)
            {
                switch (line[0])
                {
                    case 'L':
                        numbers = highlightingInt(line, 6);
                        lst.Add(new Line(new Point(numbers[0], numbers[1]), new Point(numbers[2], numbers[3]), new Pen(Color.FromArgb(numbers[4]), numbers[5])));
                        break;
                    case 'T':
                        numbers = highlightingInt(line, 8);
                        lst.Add(new Triangle(new Point(numbers[0], numbers[1]), new Point(numbers[2], numbers[3]),
                        new Point(numbers[4], numbers[5]), new Pen(Color.FromArgb(numbers[6]), numbers[7])));
                        break;
                    case 'R':
                        numbers = highlightingInt(line, 6);
                        lst.Add(new Rectangle(new Point(numbers[0], numbers[1]), numbers[2], numbers[3], new Pen(Color.FromArgb(numbers[4]), numbers[5])));
                        break;
                    case 'C':
                        numbers = highlightingInt(line, 5);
                        lst.Add(new Circle(new Point(numbers[0], numbers[1]), numbers[2], new Pen(Color.FromArgb(numbers[3]), numbers[4])));
                        break;
                }
                line = sr.ReadLine();
            }
        }
    }

    public void DrawFigures(Graphics g)
    {
        foreach (Figure i in lst)
        {
            i.Draw(g);
        }
    }

    private int[] highlightingInt(string line, int size)
    {
        int[] nums = new int[size];
        int cnt = 0;
        try
        {
            line = line.Substring(line.IndexOf('[') + 1);
            line = line.Substring(0, line.IndexOf("]"));

            while (true)
            {
                string temp = line.Substring(0, line.IndexOf(','));
                nums[cnt] = int.Parse(temp);
                line = line.Substring(line.IndexOf(',') + 2);

                cnt++;
                if (cnt >= size - 1)
                {
                    nums[cnt] = int.Parse(line);
                    break;
                }
            }
        }
        catch { }

        return nums;
    }

    public int getCount()
    {
        return lst.Count;
    }
}
