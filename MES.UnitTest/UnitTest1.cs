using MES.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MES.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string connStr = Constant.CONNECTION_STRING;
            Assert.IsNotNull(connStr);
        }
    }
}
