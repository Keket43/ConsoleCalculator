using NUnit.Framework;
using ConsoleCalculator;

namespace NegativeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(13, 0, 0)]
        public void NegativeDivisionCheck(double num1, double num2)
        {
            bool flag = false;
            try
            {
                Calc.Divide(num1, num2);
            }
            catch (System.DivideByZeroException)
            {
                flag = true;
            }
            Assert.IsTrue(flag);

            // Or more beautifull variant: 
            Assert.Throws<System.DivideByZeroException>(delegate { Calc.Divide(num1, num2); });
        }
    }
}