using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.StructuralPatterns;

namespace DesignPatternsTests.StructuralPatterns
{
    [TestClass]
    public class ProxyTests
    {
        [TestMethod]
        public void ProxyTest()
        {
            Proxy proxy = new Proxy();
            proxy.Request();
        }
    }
}
