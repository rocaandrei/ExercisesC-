using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWarsExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinValueTest.Tests
{
    [TestClass()]
    public class ExercisesTests
    {
        [TestMethod()]
        public void HighAndLowTest()
        {
            string a =  "2 4 54 -9 3 104 8";
            Assert.IsTrue(true, "-9 104", CodeWarsExercises.Exercises.HighAndLow3(a));
        }
    }
}