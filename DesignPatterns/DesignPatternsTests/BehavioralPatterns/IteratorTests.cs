﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns;
using System.Collections;
using System;

namespace DesignPatternsTests.BehavioralPatterns
{
    [TestClass]
    public class IteratorTests
    {
        [TestMethod]
        public void IteratorTest()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            Iterator i = a.CreateIterator();

            Console.WriteLine("Iterating over collection: ");

            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
        }
    }
}
