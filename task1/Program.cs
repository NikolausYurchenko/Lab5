using System;

namespace task1
{
    class Program
    {   //Вращение квадрата происходит некоректно!
        //Перемещение коректно!
        static void Main(string[] args)
        {
            MoveSquare moveSquare = new MoveSquare();
            moveSquare.Set();
            moveSquare.GetInfo();
            Console.WriteLine("Если Вы хотите перемещать квадрат, нажмите 1;\n" +
                "Если хотите вращать - нажмите 2");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if(keyInfo.Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine("\nИсользуйте 'стрелку вправо' для перемещения квадрата на единицу вправо';\n" +
                    "Используйте 'стрелку влево' для перемещения квадрата на единицу влево\n");
                while (true)
                {
                    moveSquare.Move();
                    moveSquare.GetInfo();
                }
            }
            if (keyInfo.Key == ConsoleKey.NumPad2)
            {
                Console.WriteLine("\nИсользуйте 'стрелку вправо' для вращения квадрата на единицу вправо';\n" +
                    "Используйте 'стрелку влево' для вращения квадрата на единицу влево\n" +
                    "Квадрат вращается...\n");
                RotateSquare rotateSquare = new RotateSquare(moveSquare);
                    while (true)
                    {
                        rotateSquare.Move();
                        rotateSquare.GetInfo();
                    }
            }
        }
    }
}
