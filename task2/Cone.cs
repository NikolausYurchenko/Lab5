using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    class Cone
    {
        private double _radius;
        private double _height;
        private double _area;
        private double _volume;

        protected double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
        protected double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        protected double Area
        {
            get
            {
                return _area;
            }
            set
            {
                _area = value;
            }
        }
        protected double Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
            }
        }
        public virtual void SetParametres()
        {
            Console.Write("Введите радиус конуса: ");
            Radius = double.Parse(Console.ReadLine());

            Console.Write("Введите высоту конуса: ");
            Height = double.Parse(Console.ReadLine());
        }
        public void AreaBaseCone()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
        }
        public virtual void ConeVolume()
        {
            Volume = (Math.PI * Math.Pow(Radius, 2) * Height) / 3;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Радиус конуса: {Radius};   Высота: {Height}\n" +
                $"Площадь основания: {Area};  Объем конуса: {Volume}\n");
        }
    }       
}
