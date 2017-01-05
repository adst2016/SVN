using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.CreationalPatterns;
using System;

namespace DesignPatternsTests.CreationalPatterns
{
    [TestClass]
    public class FactoryMethodTests
    {
        [TestMethod]
        public void FactoryMethodTest()
        {
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (var creator in creators)
            {
                ProductFactoryMethod product = creator.FactoryMethod();
                Console.WriteLine("Created {0} ",
                    product.GetType().Name);
            }
        }
    }
}
