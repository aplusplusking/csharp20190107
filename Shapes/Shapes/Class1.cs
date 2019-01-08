using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle
    {
        double r;
        public Circle()
        {
            r = 0;
        }
        public Circle(double radius)
        {
            this.r = radius;
        }
        public double Area()
        {
            return Math.PI * (r * r);
        }
    }
}
