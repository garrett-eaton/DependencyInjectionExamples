using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExamples
{
    public class ConsoleWriter : IWriter
    {
        public Result Write(string message)
        {
            try
            {
                Console.WriteLine(message);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Fail( ex );
            }            
        }
    }
}
