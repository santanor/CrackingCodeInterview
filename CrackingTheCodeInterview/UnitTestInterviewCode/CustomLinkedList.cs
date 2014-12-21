using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLinkedList;

namespace UnitTestInterviewCode
{
    [TestClass]
    public class CustomLinkedList
    {
        [TestMethod]
        public void TestMethod1()
        {
            LinkedList<int> list = new LinkedList<int>(0);
            for (int i = 0; i < 10; i++)
                list.AddAtTail(i);

            Assert.AreEqual("00123456789", list.ToString());
        }
    }
}
