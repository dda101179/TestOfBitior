using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class CircleCreator : ShapeCreator
    {
        public override Shape CreateShape() { return new Circle(); }
    }
}
