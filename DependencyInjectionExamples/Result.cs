using System;
using System.Diagnostics.Contracts;

namespace DependencyInjectionExamples
{
    public class Result
    {
        public bool IsSuccessful { get; private set; }
        public Exception Exception { get; private set; }
        public static Result Fail()
        {
            return new Result { IsSuccessful = false };
        }

        public static Result Fail(Exception ex)
        {
            return new Result { IsSuccessful = false , Exception = ex};
        }

        public static Result Success()
        {
            return new Result { IsSuccessful = true };
        }
    }
}