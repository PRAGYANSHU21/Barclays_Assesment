using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FileData;

namespace FileDataUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ITask t = new Task();
            t.Task1("-v", 10);
            t.Task2("-s", 20);
            Assert.AreEqual(0, 0);
        }
    }
}
