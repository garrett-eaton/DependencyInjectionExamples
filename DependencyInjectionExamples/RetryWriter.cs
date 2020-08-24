namespace DependencyInjectionExamples
{
    public class RetryWriter : IWriter
    {
        private readonly IWriter _writer;
        public RetryWriter(IWriter writer)
        {
            _writer = writer;
        }

        public Result Write(string message)
        {
            Result returnResult = Result.Fail();
            for(int i = 0; i < 3; i++)
            {
                returnResult = _writer.Write(message);
                if (returnResult.IsSuccessful)
                {
                    break;
                }
            }
            return returnResult;
        }
    }
}