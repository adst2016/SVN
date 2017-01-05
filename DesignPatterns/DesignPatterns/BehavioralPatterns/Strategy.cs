using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns
{
    public abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }

    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyA");
        }
    }

    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyB");
        }
    }

    public class StrategyContext
    {
        private Strategy _strategy;
        public StrategyContext(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface()
        {
            this._strategy.AlgorithmInterface();
        }
    }
}
