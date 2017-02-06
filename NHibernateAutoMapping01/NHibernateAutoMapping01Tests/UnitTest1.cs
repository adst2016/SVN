using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernateAutoMapping01;

namespace NHibernateAutoMapping01Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            class1.CreateDataBase();

        }
    }
}
