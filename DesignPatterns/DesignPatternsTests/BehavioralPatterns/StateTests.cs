using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns;

namespace DesignPatternsTests.BehavioralPatterns
{
    [TestClass]
    public class StateTests
    {
        [TestMethod]
        public void StateTest()
        {
            StateContext c = new StateContext(new ConcreteStateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();

        }
    }
}
