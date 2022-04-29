using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonFourteeenProgramming
{
    public class OperationRestictedException : Exception
    {
        public OperationRestictedException(string message) : base(message)
        {

        }
        public OperationRestictedException(string message, Exception innerException) : base(message, innerException)
        {

        }
        
    }
}
