// See https://aka.ms/new-console-template for more information
using CastelWindsorDemo;
using Castle.Windsor;

Console.WriteLine("Hello, World!");

var container = new WindsorContainer();
container.Register(Castle.MicroKernel.Registration.Component.For<Startup>());
container.Register(Castle.MicroKernel.Registration.Component.For<ISendMessage>().ImplementedBy<SendMessage>());
container.Register(Castle.MicroKernel.Registration.Component.For<IReceiveMessage>().ImplementedBy<ReceiveMessage>());

//通过依赖注入容器解析类 `Main`，并调用方法
var mainThing = container.Resolve<Startup>();
mainThing.DoSomething();
Console.ReadKey();