using Microsoft.Extensions.Logging;

namespace DependencyInjectionExamples
{
    class LoggedWriter : IWriter
    {
        public readonly IWriter _nestedWriter;
        public readonly ILogger<LoggedWriter> _logger;
        public LoggedWriter(IWriter writer, ILogger<LoggedWriter> logger)
        {
            _nestedWriter = writer;
            _logger = logger;
        }

        public Result Write(string message)
        {
            var result = _nestedWriter.Write(message);

            if (result.IsSuccessful)
            {
                _logger.LogDebug($"The user wrote this:{message}");
            }
            else
            {
                _logger.LogError(result.Exception, $"Exception while writing message:{message}");
            }

            return result;
        }
    }
}
