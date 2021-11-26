using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows;

namespace task1
{
    class MoveSquare 
    {
        public double[] point1 = new double[2];
        public double[] point2 = new double[2];
        public double[] point3 = new double[2];
        public double[] point4 = new double[2];
        public int Side { get; set; }
        public void Set()
        {
            string text;
            Console.Write("Ввод параметров\n" +
                "Введите значения координат верхнего левого угла квадрата и 1 стороны\n" +
                "(Вводите целые числа)\n" +
                "x: ");
            text = Console.ReadLine();
            point1[0] = double.Parse(text);

            Console.Write("y: ");
            text = Console.ReadLine();
            point1[1] = double.Parse(text);

            Console.WriteLine("Сторона: ");
            text = Console.ReadLine();
            Side = Int32.Parse(text);

            point2[0] = point1[0] + Side;
            point2[1] = point1[1];

            point3[0] = point2[0];
            point3[1] = point2[1] - Side;

            point4[0] = point3[0] - Side;
            point4[1] = point3[1];
        }
        public void GetInfo()
        {
            Console.WriteLine($"Координаты вершин:\n" +
                $"A({point1[0]}, {point1[1]});   B({point2[0]}, {point2[1]});\n\n" +
                $"D({point4[0]}, {point4[1]});   C({point3[0]}, {point3[1]});\n");
        }
        public virtual void Move()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                point1[0]--;
                point2[0]--;
                point3[0]--;
                point4[0]--;
            }
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                point1[0]++;
                point2[0]++;
                point3[0]++;
                point4[0]++;
            }
        }
       
    }
}
