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
    }
}