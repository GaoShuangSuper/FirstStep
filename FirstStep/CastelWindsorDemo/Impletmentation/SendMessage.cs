using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastelWindsorDemo
{
    internal class SendMessage : ISendMessage
    {
        public void Send(string message)
        {
            Console.WriteLine("Send the message:" + message);
        }
    }
}
