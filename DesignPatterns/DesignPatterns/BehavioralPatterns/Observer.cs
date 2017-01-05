using System;
using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns
{
    public abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in _observers)
            {
                o.Update();
            }
        }
    }

    public class ConcreteSubject : Subject
    {
        private string _subjectState;

        public string  SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }

    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            _subject = subject;
            _name = name;
        }

        public override void Update()
        {
            _observerState = _subject.SubjectState;

            Console.WriteLine("Observer {0}'s new state is {1}", _name, _observerState);
        }

        public ConcreteSubject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

    }
}
