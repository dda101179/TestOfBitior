using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class Rectangle : Shape
    {
        private double Side1 { get; set; }
        private double Side2 { get; set; }
        public override double Area()
        {
            var result = 0d;

            _calculateParams();

            result = Side1 * Side2;

            return result;
        }
        public override double Perimeter()
        {
            var result = 0d;

            _calculateParams();

            result = 2 * (Side1 + Side2);

            return result;
        }
        private void _calculateParams()
        {
            if (ValueParams.Count > 0)
            {
                if (ValueParams.Count == 1)
                {
                    Side1 = ValueParams[0];
                    Side2 = Side1;
                }
                else
                {
                    Side1 = ValueParams[0];
                    Side2 = ValueParams[1];
                }
            }
        }
    }
}
