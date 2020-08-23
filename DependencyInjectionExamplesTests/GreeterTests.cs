using System;
using DependencyInjectionExamples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DependencyInjectionExamplesTests
{
    [TestClass]
    public class GreeterTests
    {

        [TestMethod]
        public void TestGreet()
        {
            // Arrange
            var testWriter = new WriterHarness(true, null);
            var testSubject = new Greeter(testWriter);

            // Act
            testSubject.Greet();

            // Assert
            Assert.AreEqual("Hello fellow developers!", testWriter.passedMessage);
        }
    }
}
