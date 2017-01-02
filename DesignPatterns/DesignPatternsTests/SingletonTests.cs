using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns;

namespace DesignPatternsTests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void SingletonTest()
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
                Console.WriteLine("Objects are the same instance");
        }
    }
}
