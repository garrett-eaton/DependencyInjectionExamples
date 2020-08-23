using Autofac;
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

            builder.RegisterType<ConsoleWriter>().As<IWriter>();
            builder.RegisterType<Greeter>();

            return builder.Build();
        }
    }
}
