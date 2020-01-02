using MyFirstAzureWebApp;
using System;
using Xunit;

namespace calculation.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calculation = new Add(10,10);
            var result = calculation.Calculate();
            Assert.Equal(20, result);
        }
        [Fact]
        public void Test2()
        {
            var calculation = new Subtraction(10, 10);
            var result = calculation.Calculate();
            Assert.Equal(0, result);
        }
        [Fact]
        public void Test3()
        {
            var calculation = new Multiplication(10, 10);
            var result = calculation.Calculate();
            Assert.Equal(100, result);
        }
        [Fact]
        public void Test4()
        {
            var calculation = new Division(10, 5);
            var result = calculation.Calculate();
            Assert.Equal(2, result);
        }
    }
}
