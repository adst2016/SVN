using System;

namespace DesignPatterns.BehavioralPatterns
{
    public class Originator
    {
        private string _state;

        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State = " + _state);
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }

    }

    public class Memento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string State
        {
            get { return _state; }
        }
    }

    public class Caretaker
    {
        private Memento _memento;        

        public Memento Memento
        {
            get { return _memento; }
            set { _memento = value; }
        }

    }
}
