using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.CreationalPatterns;

namespace DesignPatternsTests.CreationalPatterns
{
    [TestClass]
    public class AbstractFactoryTests
    {
        /// <summary>
        /// Kiedy deklaruję zmienną jako AbstractFactory to zostanie wywołana metoda z klasy AbstractFactory a nie DerivedAbstractFactory mimo, że tworzę 
        /// obiekt typu DerivedAbstractFactory.
        /// </summary>
        [TestMethod]
        public void Test_01()
        {
            AbstractFactory abstractFactory = new ConcreteFactory1();
            var result = abstractFactory.MethodInAbstractClass();

            Assert.AreEqual(-2, result);
        }

        /// <summary>
        /// Kiedy deklaruję zmienną jako var to zostanie wywołana metoda z klasy DerivedAbstractFactory bo kompilator deklaruję zmienną domyślnie jako
        /// obiekt typu DerivedAbstractFactory. I wtedy zostanie wywołana metoda z klasy DerivedAbstractFactory.
        /// </summary>
        [TestMethod]
        public void Test_02()
        {
            var abstractFactory = new ConcreteFactory1();
            var result = abstractFactory.MethodInAbstractClass();

            Assert.AreEqual(-3, result);
        }

        /// <summary>
        /// Kiedy deklaruję zmienną jako var to zostanie wywołana metoda z klasy DerivedAbstractFactory bo kompilator deklaruję zmienną domyślnie jako
        /// obiekt typu DerivedAbstractFactory. I wtedy zostanie wywołana metoda z klasy DerivedAbstractFactory.
        /// </summary>
        [TestMethod]
        public void Test_03()
        {
            ConcreteFactory1 abstractFactory = new ConcreteFactory1();
            var result = abstractFactory.MethodInAbstractClass();

            Assert.AreEqual(-3, result);
        }


        /// <summary>
        /// Główny test abstrakcyjnej fabryki
        /// </summary>
        [TestMethod]
        public void Test_Main_01()
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            AbstractFactory factory2 = new ConcreteFactory2();

            Client client1 = new Client(factory1);
            Client client2 = new Client(factory2);

            client1.Run();
            client2.Run();
        }
    }
}
