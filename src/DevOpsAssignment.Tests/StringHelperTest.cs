using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsAssignment.Tests
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void HelloWorldStringTest()
        {
            string expected = "Hello World";
            Assert.AreEqual(expected, StringHelper.HelloWorldString());
        }
    }
}
