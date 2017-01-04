using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.StructuralPatterns;

namespace DesignPatternsTests.StructuralPatterns
{
    [TestClass]
    public class BridgeTests
    {
        [TestMethod]
        public void BridgeTest()
        {
            Abstraction ab = new RefinedAbstraction();

            ab.Implementator = new ConcretImplementatorA();
            ab.Operation();

            ab.Implementator = new ConcretImplementatorB();
            ab.Operation();

        }
    }
}
