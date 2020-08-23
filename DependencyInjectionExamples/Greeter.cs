using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExamples
{
    public class Greeter
    {
        private readonly IWriter _writer;
        private readonly string _greeting = "Hello fellow developers!";
        public Greeter(IWriter writer)
        {
            _writer = writer;
        }

        public void Greet()
        {
            _writer.Write(_greeting);
        }
    }
}
