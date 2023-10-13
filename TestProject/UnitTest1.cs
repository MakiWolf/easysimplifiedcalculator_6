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
    }
}