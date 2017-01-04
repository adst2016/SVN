using System;

namespace DesignPatterns.StructuralPatterns
{
    public abstract class DecoratorComponent
    {
        public abstract void Operation();
    }

    public class ConcretComponent : DecoratorComponent
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }

    public abstract class Decorator : DecoratorComponent
    {
        protected DecoratorComponent component;

        public void SetComponent(DecoratorComponent component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (this.component != null)
                this.component.Operation();
        }
    }
    
    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        private void AddedBehavior()
        {
            Console.WriteLine("ConcreteDecoratorB.AddedBehavior()");
        }
    }

}
