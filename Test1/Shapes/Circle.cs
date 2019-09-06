using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class Circle : Shape
    {
        private double Radius { get; set; }
        public override double Area()
        {
            var result = 0d;

            _calculateParams();

            result = Math.PI * Radius * Radius;

            return result;
        }
        public override double Perimeter()
        {
            var result = 0d;

            _calculateParams();

            result = 2 * Math.PI * Radius;

            return result;
        }
        private void _calculateParams()
        {
            if (ValueParams.Count > 0)
            {
                Radius = ValueParams[0];
            }
        }
    }
}
