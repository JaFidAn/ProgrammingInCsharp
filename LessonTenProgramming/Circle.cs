using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTenProgramming
{
    internal class Circle : Shapes
    {
        double radius = 10.1;
        const double pi = 3.14;
        
        public override double AreaOfShape()
        {
            double areaofCircle = 2 * pi * radius * radius;
            return areaofCircle;
        }
        public override double PerimetrOfShape()
        {
            return 2*pi * radius;
        }
    }
}
