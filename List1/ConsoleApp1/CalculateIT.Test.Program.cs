using Library;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalcularIR.Test
{
    public class CalculaIRTest
    {
        [Fact]
        public void ShouldReturnZero()
        {
            //arrange
            int income = 1;
            var calculateIT = new ITCalculator();

            //act
            var result = calculateIT.CalculateIT(income);


            //assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void ShouldReturn232()
        {
            //arrange
            int income = 4001;
            var calculaIRcalculateIT = new ITCalculator();
            //act
            var result = calculaIRcalculateIT.CalculateIT(income);
            //assert
            Assert.Equal(232.06, result);
        }

        [Fact]
        public void ShouldReturn1315()
        {
            int income = 9001;
            var calculateIT = new ITCalculator();
            //act
            var result = calculateIT.CalculateIT(income);
            //assert
            Assert.Equal(1350.15, result);
        }

        [Fact]
        public void ShouldReturn6875()
        {
            int income = 25001;
            var calculateIT = new ITCalculator();
            //act
            var result = calculateIT.CalculateIT(income);
            //assert
            Assert.Equal(6875.28, result);
        }

        [Fact]
        public void ShouldReturn10500()
        {
            int income = 35001;
            var calculateIT = new ITCalculator();
            //act
            var result = calculateIT.CalculateIT(income);
            //assert
            Assert.Equal(10500.30, result);
        }
    }
}