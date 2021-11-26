using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class RotateSquare : MoveSquare
    {
        public RotateSquare(MoveSquare moveSquare)
        {
            point1 = moveSquare.point1;
            point2 = moveSquare.point2;
            point3 = moveSquare.point3;
            point4 = moveSquare.point4;
        }

        private double _grad = 90;
        public override void Move()
        {
            double rad = (_grad * Math.PI) / 180;
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                point1[0] = point1[0] * Math.Cos(rad) - point1[1] * Math.Sin(rad);
                point1[1] = point1[0] * Math.Sin(rad) + point1[1] * Math.Cos(rad);

                point2[0] = point2[0] * Math.Cos(rad) - point2[1] * Math.Sin(rad);
                point2[1] = point2[0] * Math.Sin(rad) + point2[1] * Math.Cos(rad);

                point3[0] = point3[0] * Math.Cos(rad) - point3[1] * Math.Sin(rad);
                point3[1] = point3[0] * Math.Sin(rad) + point3[1] * Math.Cos(rad);

                point4[0] = point4[0] * Math.Cos(rad) - point4[1] * Math.Sin(rad);
                point4[1] = point4[0] * Math.Sin(rad) + point4[1] * Math.Cos(rad);
            }
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                rad = -_grad / 180 * Math.PI;
                point1[0] = point1[0] * Math.Cos(rad) - point1[1] * Math.Sin(rad);
                point1[1] = point1[0] * Math.Sin(rad) + point1[1] * Math.Cos(rad);

                point2[0] = point2[0] * Math.Cos(rad) - point2[1] * Math.Sin(rad);
                point2[1] = point2[0] * Math.Sin(rad) + point2[1] * Math.Cos(rad);

                point3[0] = point3[0] * Math.Cos(rad) - point3[1] * Math.Sin(rad);
                point3[1] = point3[0] * Math.Sin(rad) + point3[1] * Math.Cos(rad);

                point4[0] = point4[0] * Math.Cos(rad) - point4[1] * Math.Sin(rad);
                point4[1] = point4[0] * Math.Sin(rad) + point4[1] * Math.Cos(rad);
            }
        }
    }
}
