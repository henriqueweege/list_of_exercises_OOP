using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Library;

namespace Math.Tests
{
    public class CalculationsTests
    {
        [Fact]
        public void DivideShouldReturnDivision()
        {

            //arrange
            int firstParameter = 1;
            int secondParameter = 2;
            var calculosIntegerPositiv = new Calculations();

            //act
            var result = calculosIntegerPositiv.Divide(firstParameter, secondParameter);

            //assert
            Assert.Equal(0.5, result);
        }

        [Fact]
        public void DivideShouldThrowExceptionWhenSecondParameterIsZero()
        {
            
            //arrange
            int firstParameter = 1;
            int secondParameter = 0;
            var calculosIntegerPositiv = new Calculations();

            //act
            var exception = Assert.Throws<DivideByZeroException>(() =>
            {
                calculosIntegerPositiv.Divide(firstParameter, secondParameter);
            });

            //assert
            Assert.Equal("Attempted to divide by zero.", exception.Message);
        }
    }
}
