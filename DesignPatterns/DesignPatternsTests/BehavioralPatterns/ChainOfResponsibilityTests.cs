using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns;

namespace DesignPatternsTests.BehavioralPatterns
{
    [TestClass]
    public class ChainOfResponsibilityTests
    {
        [TestMethod]
        public void ChainResponsibilityTest_01()
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSuccesor(h2);
            h2.SetSuccesor(h3);

            int[] requests = { 2, 5, 14, 22, 38, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }
        }
    }
}
