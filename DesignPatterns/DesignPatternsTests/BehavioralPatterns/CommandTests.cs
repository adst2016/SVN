using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns;

namespace DesignPatternsTests.BehavioralPatterns
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void CommandTest()
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
