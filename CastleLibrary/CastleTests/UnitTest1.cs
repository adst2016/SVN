using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CastleLibrary;

namespace CastleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            InversionOfControl ioc = new InversionOfControl();

            ioc.ExecuteIoc();
        }
    }
}
