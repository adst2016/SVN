using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns;
using System.Collections;

namespace DesignPatternsTests.BehavioralPatterns
{
    [TestClass]
    public class InterpreterTests
    {
        [TestMethod]
        public void InterpreterTest()
        {
            Context context = new Context();

            ArrayList list = new ArrayList();

            list.Add(new TerminalExpression());
            list.Add(new NonTerminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression exp in list)
            {
                exp.Inerpret(context);
            }
        }
    }
}
