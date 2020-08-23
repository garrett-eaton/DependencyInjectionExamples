using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInterface.IO;

namespace DependencyInjectionExamples
{
    public class FileWriter : IWriter
    {
        public readonly IFile _fileWrapper;
        public readonly string _filePath = @"C:\Temp\test.txt";

        public FileWriter(IFile fileWrapper)
        {
            _fileWrapper = fileWrapper;
        }

        public Result Write(string message)
        {
            try
            {
                _fileWrapper.WriteAllText(_filePath, message);

                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Fail(ex);
            }
        }
    }
}
