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
            // Pure Dependency injection is when manual creation of objects occurs and they are injected manually.
            var writer = new ConsoleWriter();

            var gre = new Greeter(writer);

            gre.Greet();

            Console.Read();
        }
    }
}
