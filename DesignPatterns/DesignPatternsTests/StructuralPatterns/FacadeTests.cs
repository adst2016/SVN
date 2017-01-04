using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.StructuralPatterns;

namespace DesignPatternsTests.StructuralPatterns
{
    [TestClass]
    public class FacadeTests
    {
        [TestMethod]
        public void FacadeTest()
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
            
        }
    }
}
