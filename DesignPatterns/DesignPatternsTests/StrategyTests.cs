using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns;

namespace DesignPatternsTests
{
    [TestClass]
    public class StrategyTests
    {
        [TestMethod]
        public void StrategyTest_01()
        {
            Context context;

            Strategy strategyA = new ConcreteStrategyA();
            context = new Context(strategyA);
            context.ContextInterface();

            Strategy strategyB = new ConcreteStrategyB();
            context = new Context(strategyB);
            context.ContextInterface();

        }
    }
}
