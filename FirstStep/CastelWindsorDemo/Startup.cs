using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastelWindsorDemo
{
    public class Startup
    {
        private IReceiveMessage IR { get; set; }

        public Startup(IReceiveMessage dependency1)
        {
            IR = dependency1;
        }

        public void DoSomething()
        {
            IR.Receive("Test castle!");
        }

    }
}
