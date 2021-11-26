using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cone cone = new Cone();
            TruncatedCone truncatedCone = new TruncatedCone();
            cone.SetParametres(); //Устанавливаем параметры конуса
            cone.AreaBaseCone(); //Расчёт площади основания
            cone.ConeVolume(); //Расчёт объема конуса
            cone.GetInfo(); //Вывод на экран

            Console.WriteLine("\n------------ -----------\n");

            truncatedCone.SetParametres();
            truncatedCone.ConeVolume();
            truncatedCone.GetInfo();
            Console.ReadLine();
        }
    }
}
