using Microsoft.VisualStudio.TestTools.UnitTesting;
using question1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMakechange1()

        {
            Assert.AreEqual(4, MakeChange.Makechange(135));
        }

        [TestMethod]
        public void TestMakechange2()
        {
            Assert.AreEqual(2, MakeChange.Makechange(120));
        }

        [TestMethod]
        public void TestMakechange3()
        {
            Assert.AreEqual(3, MakeChange.Makechange(121));
        }

        [TestMethod]
        public void TestMakechange4()
        {
            Assert.AreEqual(0, MakeChange.Makechange(0));
        }

        [TestMethod]
        public void TestMakechange5()
        {
            Assert.AreEqual(5, MakeChange.Makechange(14));
        }

        [TestMethod]
        public void TestMakechange6()
        {
            Assert.AreEqual(1, MakeChange.Makechange(1));
        }
    }
}
