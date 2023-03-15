// 将所有这个接口中封装的方法都进行统一的包装。
using DispatchProxyDemo;
using System.Reflection;

Console.WriteLine("Hello, Dispatch!" + "\r\n");

IMessage im = DispatchProxy.Create<IMessage, CustomDispatch>();
((CustomDispatch)im).TargetClass= new DemoMessage();
im.Send("Hello");
im.Receive("Hello");
