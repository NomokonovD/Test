using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Circle: Figure
    {
        private double Radius;

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double Area()
        {
            return 2 * 3.14 * Radius;
        }
    }
}
