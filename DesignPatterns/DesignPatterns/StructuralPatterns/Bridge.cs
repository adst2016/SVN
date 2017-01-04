using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns
{
    public abstract class Abstraction
    {
        protected Implementator implementator;

        public Implementator Implementator
        {
            set
            {
                implementator = value;
            }
        }

        public virtual void Operation()
        {
            implementator.Operation();
        }
    }

    public abstract class Implementator
    {
        public abstract void Operation();
    }

    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementator.Operation();
        }
    }

    public class ConcretImplementatorA : Implementator
    {
        public override void Operation()
        {
            Console.WriteLine("ConcretImplementatorA Operation");
        }
    }

    public class ConcretImplementatorB : Implementator
    {
        public override void Operation()
        {
            Console.WriteLine("ConcretImplementatorB Operation");
        }
    }

}
