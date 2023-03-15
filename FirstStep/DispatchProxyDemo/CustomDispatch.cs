using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DispatchProxyDemo
{
    internal class CustomDispatch : DispatchProxy
    {
        public object TargetClass { get; set; }
        protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
        {
            Write("Begin the invoke");
            var result = targetMethod.Invoke(TargetClass, args);
            Write("End the invoke" + "\r\n");
            return result;
        }
        private void Write(string content)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
            Console.ResetColor();
        }
    }
}
