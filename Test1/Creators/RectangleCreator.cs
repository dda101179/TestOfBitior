using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class RectangleCreator : ShapeCreator
    {
        public override Shape CreateShape() { return new Rectangle(); }
    }
}
