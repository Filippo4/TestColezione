using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestColezione
{
    [TestClass]
    public class TestCollezioni
    {
        [TestMethod]
        public void TestCollezione1()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int[] b = new int[] { 1, 2, 3, 4, 5 };
            CollectionAssert.AreEquivalent(a, b);
        }

        [TestMethod]
        public void TestCollezione2()
        {
            int[] a = new int[] { 1, 2, 3, 4, 3  };
            int[] b = new int[] { 1, 2, 3, 4, 5 };
            CollectionAssert.AreEquivalent(a, b);
        }

        [TestMethod]
        public void TestCollezione3()
        {
            string[] a = new string[] {"cane","banana","elefante","coccodrillo"};
            string[] b = new string[] { "cane", "banana", "elefante", "coccodrillo" };
            CollectionAssert.AreEquivalent(a, b);
        }

        [TestMethod]
        public void TestCollezione4()
        {
            string[] a = new string[] { "cane", "banana", "elefante", "coccodrillo" };
            string[] b = new string[] { "cane", "lupo", "elefante", "mangiatoia" };
            CollectionAssert.AreEquivalent(a, b);
        }

        [TestMethod]
        public void TestCollezione5()
        {
            List<int> a = new List<int>(4);
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            List<int> b = new List<int>(4);
            b.Add(1);
            b.Add(2);
            b.Add(3);
            b.Add(4);
            CollectionAssert.AreEquivalent(a, b);
        }
        [TestMethod]
        public void TestCollezione6()
        {
            List<int> a = new List<int>(4);
            a.Add(5);
            a.Add(2);
            a.Add(6);
            a.Add(4);
            List<int> b = new List<int>(4);
            b.Add(1);
            b.Add(2);
            b.Add(3);
            b.Add(4);
            CollectionAssert.AreEquivalent(a, b);
        }
    }
}
