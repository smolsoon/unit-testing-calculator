using System;
using Xunit;

namespace Calculators.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void add_two_values()
        {
            //Arrange
            var calc = new Calculator();
            //Act
            var result = calc.Adding(2,2);
            //Assert
            Assert.Equal(4,result);
            
        }

        [Fact]
        public void mul_two_values()
        {
            //Arrange
            var calc = new Calculator();
            //Act
            var result = calc.Multiply(3,2);
            //Assert
            Assert.Equal(6,result);
            
        }
    }
}
