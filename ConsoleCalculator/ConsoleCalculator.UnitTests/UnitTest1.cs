using NUnit.Framework;
using ConsoleCalculator;

namespace ConsoleCalculator.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase (10, 2, 12)]
        [TestCase(-14, 8, -6)]
        [TestCase(0, 3, 3)]
        [TestCase(1, 1, 2)]
        public void AddTest(double firstArgument, double secondArgument, double expectedResult) //атрибут
        {
            double actualResult = Calc.Add(firstArgument, secondArgument);
            Assert.Pass();
        }

        [TestCase(10, 2, 8)]   
        [TestCase(0, 0, 0)]
        [TestCase(8, 4, 4)]
        public void SubtractTest(double firstArgument, double secondArgument, double expectedResult) //атрибут
        {
            double actualResult = Calc.Subtract(firstArgument, secondArgument);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestCase(5, 2, 10)]
        [TestCase(-10, 5, -50)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 0)]
        public void MultiplyTest(double firstArgument, double secondArgument, double expectedResult) //атрибут
        {
            double actualResult = Calc.Multiply(firstArgument, secondArgument);
            Assert.Pass();
        }

        [TestCase(10, 2, 5)]
        [TestCase(8, 2, 4)]
        [TestCase(10, 0, 0)]        
        public void DivideTest(double firstArgument, double secondArgument, double expectedResult) //атрибут
        {
            double actualResult = Calc.Divide(firstArgument, secondArgument);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestCase(10, 2, 0)]
        [TestCase(10, 3, 1)]           
        public void RestOfDivideTest(double firstArgument, double secondArgument, double expectedResult) //атрибут
        {
            double actualResult = Calc.RestOfDivide(firstArgument, secondArgument);
            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestCase(3, 6)]
        [TestCase(6, 720)]
        [TestCase(13, 6227020800)]
        [TestCase(0, 1)]
        public void FactorialTest(double firstArgument, double expectedResult)
        {
            double actualResult = Calc.Factorial(firstArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(6, 3, 216)]
        [TestCase(2, 13, 8192)]
        [TestCase(3, 8, 6561)]
        [TestCase(3, 5, 243)]        
        public void DegreeTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = Calc.Stepen(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(12, 3, 4)]
        [TestCase(666, 0, 0)]
        public void PositiveDivisionCheck(double num1, double num2, double expResult)
        {
            double actual = Calc.Divide(num1, num2);
            Assert.AreEqual(expResult, actual);
        }       
    }
}