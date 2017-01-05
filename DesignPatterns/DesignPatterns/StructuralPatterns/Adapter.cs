using System;

namespace DesignPatterns.StructuralPatterns
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }

    public class Adaptee
    {
        public void SpecificRequest(string additionalText)
        {
            Console.WriteLine("SpecificRequest() {0}", additionalText);
        }
    }

    public class Adapter : Target
    {
        Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            adaptee.SpecificRequest("additional text");
        }
    }
}
