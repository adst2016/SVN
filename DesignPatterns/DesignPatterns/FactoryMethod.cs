using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class ProductFactoryMethod
    {
    }

    public class ConcreteProductA : ProductFactoryMethod
    {
    }

    public class ConcreteProductB : ProductFactoryMethod
    {
    }

    public abstract class Creator
    {
        public abstract ProductFactoryMethod FactoryMethod();
    }

    public class ConcreteCreatorA : Creator
    {
        public override ProductFactoryMethod FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override ProductFactoryMethod FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
