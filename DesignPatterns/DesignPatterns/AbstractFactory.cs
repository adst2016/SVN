using System;

namespace DesignPatterns
{
    //Wzorzec Abstract Factory
    public abstract class AbstractFactory
    {
        public int MethodInAbstractClass()
        {
            return -2;
        }

        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProduktB CreateProductB();
    }

    /// <summary>
    /// Abstrakcyjna klasa odpowiadająca produktowi A
    /// </summary>
    public abstract class AbstractProductA
    {
    }

    /// <summary>
    /// Abstrakcyjna klasa odpowiadająca produktowi B
    /// </summary>
    public abstract class AbstractProduktB
    {
        public abstract void Interact(AbstractProductA a);
    }

    public class ProductA1 : AbstractProductA
    {
    }

    public class ProductB1 : AbstractProduktB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
                " interacts with " + a.GetType().Name);
        }
    }

    public class ProductA2 : AbstractProductA
    {
    }

    public class ProductB2 : AbstractProduktB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
                " interacts with " + a.GetType().Name);
        }
    }


    //Nie mogę mieć interfejsu który będzie miał definicję funkcji 
    //- dlatego to się różni od klasy abstrakcyjnej która może być takim interfejsem ale oprócz tego może mieć tego typu metody z implementacją
    //public interface InterfaceFactory
    //{
    //    int MethodInInterface()
    //    {
    //        return -2;
    //    }
    //}

    /// <summary>
    /// Kiedy tworzę klasę która dziedziczy po klasie abstrakcyjnej mogę nadpisać metodę z klasy bazowej używając słowa kluczowego new. 
    /// </summary>
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProduktB CreateProductB()
        {
            return new ProductB1();
        }

        public new int MethodInAbstractClass()
        {
            return -3;
        }
    }

    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProduktB CreateProductB()
        {
            return new ProductB2();
        }
    }

    public class Client
    {
        private AbstractProductA _productA;
        private AbstractProduktB _productB;

        public Client(AbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }

        public void Run()
        {
            _productB.Interact(_productA);
        }
    }
}
