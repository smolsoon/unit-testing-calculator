using System;
using Xunit;

namespace Calculators.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var calc = new Calculator();
            //Act
            var result = calc.Adding(2,2);
            //Assert
            Assert.Equal(4,result);
            
        }
    }
}
