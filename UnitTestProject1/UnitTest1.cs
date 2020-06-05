using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double result = Dasha_OOP_5.Doctor.Number();
            Assert.AreEqual(12.6, result);
        }
    }
}
