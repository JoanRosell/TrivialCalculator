using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Tests
{
    [TestClass()]
    public class CalculatorTests 
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(5, calc.Add(3, 2));
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(1, calc.Subtract(3, 2));
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(6, calc.Multiply(3, 2));
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(3, calc.Divide(6, 2));
        }
    }
}