using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTenProgramming
{
    internal class Rectangle : Shapes
    {
        double side1=5;
        double side2=10;

        public override double AreaOfShape()
        {
            return side1*side2;
        }
        public override double PerimetrOfShape()
        {
            return 2*(side1+side2);
        }
    }
}
