using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWarsExercises;

namespace ConsoleApp.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void XOTest()
        {

            string a = "xxssxoo";

            Assert.IsTrue(true, a);
        }
    }
    [TestClass()]
    public class Exercises
    {
        [TestMethod()]

        public void XOTest()
        {
            string b = "kdss";
            Assert.IsTrue(true, b);

        }

    }
}