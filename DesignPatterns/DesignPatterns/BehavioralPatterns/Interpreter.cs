using System;

namespace DesignPatterns.BehavioralPatterns
{
    public class Context
    {
    }

    public abstract class AbstractExpression
    {
        public abstract void Inerpret(Context context);
    }

    public class TerminalExpression : AbstractExpression
    {
        public override void Inerpret(Context context)
        {
            Console.WriteLine("Called Terminal.Expression()");
        }
    }

    public class NonTerminalExpression : AbstractExpression
    {
        public override void Inerpret(Context context)
        {
            Console.WriteLine("Called NonTerminal.Expression()");
        }
    }
}
