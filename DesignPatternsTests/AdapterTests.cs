using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns;

namespace DesignPatternsTests
{
    [TestClass]
    public class AdapterTests
    {
        [TestMethod]
        public void AdapterTest_01()
        {
            Target target2 = new Target();
            target2.Request();

            Target targetByAdapter = new Adapter();
            targetByAdapter.Request();
        }
    }
}
