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
        public void ValidationShouldReturnFalse()
        {

            //arrange
            double num = 1.5;
            var validation = new Calculations();

            //act
            var result = validation.IsInteger(num);

            //assert
            Assert.Equal($"The number {num} is not an integer", result);
        }

        [Fact]
        public void ValidationShouldReturnTrue()
        {

            //arrange
            double num = 1;
            var validation = new Calculations();

            //act
            var result = validation.IsInteger(num);

            //assert
            Assert.Equal($"The number {num} is an integer", result);
        }

        [Fact]
        public void MultiplyLastInputShouldReturn2()
        {
            //arrange
            int num = 2;
            var validation = new Calculations();
            validation.lastInput = 1;

            //act
            var result = validation.MultiplyLastInput(num);

            //assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void FactorialShouldReturn2432902008176640000()
        {
            //arrange
            int num = 20;
            var validation = new Calculations();

            //act
            var result = validation.Factorial(num);

            //assert
            Assert.Equal(2432902008176640000, result);
        }

        [Fact]
        public void DivisorsShouldReturn6_3_2_1()
        {
            //arrange
            int num = 6;
            List<int> expect = new List<int>();
            expect.Add(6);
            expect.Add(3);
            expect.Add(2);
            expect.Add(1);
            var validation = new Calculations();

            //act
            var result = validation.Divisors(num);


            //assert
            Assert.Equal(expect, result);

        }

        [Fact]

        public void FiboShouldReturnSequeceOf5Numbers()
        {
            //arrange
            var num = 5;
            var validation = new Calculations();

            //act
            var result = validation.Fibo(5).Count();

            //assert
            Assert.Equal(num, result);
        }

        [Fact]
        public void FirstFormulaShouldReturn2_28()
        {
            //arrange
            var num = 5;
            var validation = new Calculations();
            var expect = 2.28;

            //act
            var result = validation.FirstFormula(num);

            //assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void SecondFormulaShouldReturn2_28()
        {
            //arrange
            var num = 5;
            var validation = new Calculations();
            var expected = 8.7;

            //act
            var result = validation.SecondFormula(num);


            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ThirdFormulaShouldReturnSOMETHING()
        {
            //arrange
            var num = 5;
            var expect = 0;
            var validation = new Calculations();

            //act
            var result = validation.ThirdFormula(num);

            //assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void ForthFormulaShouldResturn0_42()
        {
            //arrange 
            var num = 1;
            var expect = 0.41;
            var validation = new Calculations();

            //act
            var result = validation.ForthFormula(num);

            //assert
            Assert.Equal(expect, result);
        }

    }
    
}
