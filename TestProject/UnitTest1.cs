using easysimplifiedcalculator;
using System;
using NUnit.Framework;


namespace TestProject
{
    
    public class Tests
    {
        [TestCase]
        public void Test2()
        {
            calculation_class a = new calculation_class();
            double b = a.add(1, 8);
            Assert.AreEqual(b, 9.0);

        }
    }
}