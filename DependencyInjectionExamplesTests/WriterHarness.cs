using DependencyInjectionExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExamplesTests
{
    class WriterHarness : IWriter
    {
        public string passedMessage { get; private set; }

        private readonly Result _returnResult;
        public WriterHarness(bool success, Exception ex)
        {
            if (success)
            {
                _returnResult = Result.Success();
            } else
            {
                _returnResult = Result.Fail(ex);
            }
        }

        public Result Write(string message)
        {
            passedMessage = message;
            return _returnResult;
        }
    }
}
