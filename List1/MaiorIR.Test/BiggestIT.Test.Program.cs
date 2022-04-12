using Library;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIR.Test
{
    public class BiggestITTest
    {
        [Fact]
        public void ShouldReturnDefaultName()
        {
            //arrange


            //act
            var name = BiggestIT.nameBiggestIT;

            //assert
            Assert.Equal("name", name);
        }

        [Fact]
        public void ShouldReturnDefaltMaiorIR()
        {
            //arrange
            var it = BiggestIT.biggestIT;

            //act

            //assert
            Assert.Equal((double)0, it);
        }

        [Fact]
        public void ShouldReturnNewName()
        {
            //arrange
            var name = "Henrique";
            var it = 5000;

            //act
            BiggestIT.CalculateBiggestIT(name, it);
            var newName = BiggestIT.nameBiggestIT;


            //assert
            Assert.Equal("Henrique", newName);
        }

        [Fact]
        public void ShouldReturnNewIR()
        {
            //arrange
            var name = "Henrique";
            var it = 5000;

            //act
            Library.BiggestIT.CalculateBiggestIT(name,it);
            var newIT = BiggestIT.biggestIT;

            //assert
            Assert.Equal(5000, newIT);
        }
    }
}