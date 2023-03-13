using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastelWindsorDemo
{
    internal class ReceiveMessage : IReceiveMessage
    {
        public ISendMessage IS { get; set; }
        public void Receive(string message)
        {
            Console.WriteLine("Receive the message:" + message);
            IS.Send(message);
        }
    }
}
