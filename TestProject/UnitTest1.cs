using easysimplifiedcalculator;
using System;
using NUnit.Framework;


namespace TestProject
{

    public class Tests
    {
        [TestCase]
        public void Testadd()
        {
            calculation_class calc = new calculation_class();
            double result = calc.add(1, 8);
            Assert.AreEqual(result, 9.0);

        }

        [TestCase]
        public void Testsub()
        {
            calculation_class calc = new calculation_class();
            double result = calc.sub(9, 8);
            Assert.AreEqual(result, 1.0);

        }

        [TestCase]
        public void Testmult()
        {
            calculation_class calc = new calculation_class();
            double result = calc.mult(2, 2);
            Assert.AreEqual(result, 4.0);

        }

        [TestCase]
        public void Testdiv()
        {
            calculation_class calc = new calculation_class();
            double result = calc.div(8, 8);
            Assert.AreEqual(result, 1.0);

        }
    }
}