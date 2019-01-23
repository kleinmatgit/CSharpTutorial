using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfaceDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnTof()
        {
            var dev = new Developer();

            Assert.AreEqual("Tof", dev.GetName());
        }
    }
}
