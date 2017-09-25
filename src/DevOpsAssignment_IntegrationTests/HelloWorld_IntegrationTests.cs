using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOpsAssignment;

namespace DevOpsAssignment_IntegrationTests
{
    [TestClass]
    public class HelloWorld_IntegrationTests
    {
        [TestMethod]
        public void HelloWorld_CreatesOutput()
        {
            var filepath = @"c:\temp\DevOpsTest\HelloWorld.txt";
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
            OutputString os = new OutputString(filepath);
            os.Save("Hello World");
            Assert.IsTrue(File.Exists(filepath));
        }
    }
}
