using System;

namespace DesignPatterns.BehavioralPatterns
{
    public abstract class State
    {
        public abstract void Handle(StateContext context);
    }

    public class ConcreteStateA : State
    {
        public override void Handle(StateContext context)
        {
            context.State = new ConcreteStateB();
        }
    }

    public class ConcreteStateB : State
    {
        public override void Handle(StateContext context)
        {
            context.State = new ConcreteStateA();
        }
    }

    public class StateContext
    {
        private State _state;

        public StateContext(State state)
        {
            _state = state;
        }        

        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
