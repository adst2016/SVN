using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate01;


namespace NHibernate01Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 client = new Class1();
            client.GetID();
        }
    }
}
