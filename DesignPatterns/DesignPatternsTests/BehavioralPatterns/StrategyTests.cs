using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns;

namespace DesignPatternsTests.BehavioralPatterns
{
    [TestClass]
    public class StrategyTests
    {
        [TestMethod]
        public void StrategyTest_01()
        {
            StrategyContext context;

            Strategy strategyA = new ConcreteStrategyA();
            context = new StrategyContext(strategyA);
            context.ContextInterface();

            Strategy strategyB = new ConcreteStrategyB();
            context = new StrategyContext(strategyB);
            context.ContextInterface();

        }
    }
}
