using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class TruncatedCone : Cone
    {
        private double _secondRadius;
        protected double SecondRadius
        {
            get
            {
                return _secondRadius;
            }
            set
            {
                _secondRadius = value;
            }
        }
        public override void SetParametres()
        {
            base.SetParametres();
            Console.Write("Введите второй радиус конуса: ");
            SecondRadius = double.Parse(Console.ReadLine());
        }
        public override void ConeVolume()
        {
            Volume = (Math.PI * Height * (Math.Pow(Radius, 2) + Radius * SecondRadius + Math.Pow(SecondRadius, 2))) / 3;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Первый радиус: {Radius};   Высота конуса: {Height};   Второй радиус конуса: {SecondRadius}\n" +
                $"Объем усеченного конуса: {Volume}\n");
        }
    }
}
