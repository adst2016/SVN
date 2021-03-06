﻿using System;

namespace DesignPatterns.BehavioralPatterns
{
    public abstract class Handler
    {
        protected Handler Succesor;

        public void SetSuccesor(Handler succesor)
        {
            this.Succesor = succesor;
        }

        public abstract void HandleRequest(int request);
    }

    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if(request >= 0 && request < 10)
            {
                Console.WriteLine("{0} handled request {1}",
                this.GetType().Name, request);
            }
            else if(Succesor != null)
            {
                this.Succesor.HandleRequest(request);
            }            
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} handled request {1}",
                this.GetType().Name, request);
            }
            else if (Succesor != null)
            {
                this.Succesor.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} handled request {1}",
                this.GetType().Name, request);
            }
            else if (Succesor != null)
            {
                this.Succesor.HandleRequest(request);
            }
        }
    }

}
