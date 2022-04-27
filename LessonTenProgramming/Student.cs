using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTenProgramming
{
    internal class Student
    {
        private int _iq;
        public void SetIq(int iq)
        {
            if (iq <= 200)
            {
                _iq = iq;
            }
            else
            {
                throw new Exception("IQ can not be more than 200");
            }
            
        }
        public int GetIq()
        {
            return _iq;
        }
    }
}
