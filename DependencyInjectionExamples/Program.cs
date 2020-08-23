using Autofac;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Autofac

            using (var scope = RegisterDependencies().BeginLifetimeScope())
            {
                var greeter = scope.Resolve<Greeter>();

                greeter.Greet();
            }

            Console.Read();
        }

        static IContainer RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            var loggerFactory = new LoggerFactory();
            loggerFactory.AddNLog(new NLogProviderOptions { CaptureMessageTemplates = true, CaptureMessageProperties = true });

            builder.RegisterInstance(loggerFactory).As<ILoggerFactory>().SingleInstance();
            builder.RegisterGeneric(typeof(Logger<>)).As(typeof(ILogger<>)).SingleInstance();
            builder.RegisterType<ConsoleWriter>().As<IWriter>();

            builder.RegisterDecorator<LoggedWriter, IWriter>();

            builder.RegisterType<Greeter>();

            return builder.Build();
        }
    }
}
