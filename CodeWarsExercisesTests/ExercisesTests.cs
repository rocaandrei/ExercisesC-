using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWarsExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsExercises.Tests
{
    [TestClass()]
    public class ExercisesTests
    {
        [TestMethod()]
        public void XOTestCodeWars()
        {
            string a = "12323";
            Assert.IsFalse(true, a);
        }
    }
}