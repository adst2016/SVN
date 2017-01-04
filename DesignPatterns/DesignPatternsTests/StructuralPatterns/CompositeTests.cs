using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.StructuralPatterns;

namespace DesignPatternsTests.StructuralPatterns
{
    [TestClass]
    public class CompositeTests
    {
        [TestMethod]
        public void CompositeTest()
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);
        }
    }
}
