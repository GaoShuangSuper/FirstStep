using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastelWindsorDemo
{
    public interface IReceiveMessage
    {
        void Receive(string message);
    }
}
