using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispatchProxyDemo
{
    internal class DemoMessage : IMessage
    {
        public void Receive(string content)
        {
            Console.WriteLine(content);
        }

        public void Send(string content)
        {
            Console.WriteLine(content);
        }
    }
    interface IMessage
    {
        void Send(string content);
        void Receive(string content);
    }
}
