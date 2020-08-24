using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExamples
{
    public class NullWriter : IWriter
    {
        public Result Write(string message)
        {
            return Result.Success();
        }
    }
}
