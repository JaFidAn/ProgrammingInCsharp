using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThirteenProgramming
{
    public class SmsService1 : ISmsService
    {
        private string _sender = "Azercell";
        public void SendSms(string phoneNumber, string message)
        {
            Console.WriteLine($"{message} and message has been sended to {phoneNumber} by {_sender}" );
        }
    }

    public class SmsService2 : ISmsService
    {
        private string _sender = "Bakcell";
        public void SendSms(string phoneNumber, string message)
        {
            Console.WriteLine($"{message} and message has been sended to {phoneNumber} by {_sender}");
        }
    }

    public interface ISmsService
    {
        void SendSms(string phoneNumber, string message);
    }
}
