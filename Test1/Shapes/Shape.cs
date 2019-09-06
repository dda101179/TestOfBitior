using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public abstract class Shape
    {
        // Параметр ValueParams задан списком, т.к. заранее неизвестна размерность объекта
        // Для круга - одна размерность - радиус
        // Для квадрата - одна размерность - длина стороны
        // Для прямоугольника - две размерности - длина, ширина сторон
        // Для куба - три размерности - длина, ширина, высота сторон
        public List<double> ValueParams { get; set; } = new List<double>();
        public abstract double Area();
        public abstract double Perimeter();
    }
}
