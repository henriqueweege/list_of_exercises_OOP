using Library;
using Xunit;
namespace ArithimeticVerifications.Test
{
    public class ArithimeticVerificationsTest
    {
        [Fact]
        public void ParentesisVerifyShloudReturnParentesisAreRight()
        {
            //arrange
            var parentesis = "(())";
            var expected = "The parentesis are right";
            var verify = new ArithimeticExpresisonsVerifications();

            //act
            var result = verify.ParentesisVerify(parentesis);

            //assert
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void ParentesisVerifyShouldReturnParentesisAreNotRight()
        {
            //arrange
            var parentesis = ")()";
            var expected = "The parentesis aren't right";
            var verify = new ArithimeticExpresisonsVerifications();

            //act
            var result = verify.ParentesisVerify(parentesis);

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DivisionAndMultiplicationCounterShouldReturn2()
        {
            //arrange
            var operators = "**//";
            var expected = "The number of Division in the expression if 2, and the number of multiplication is 2";
            var verify = new ArithimeticExpresisonsVerifications();

            //act
            var result = verify.DivisionAndMultiplicationCounter(operators);

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PositionAndTypeOfFirstOperatorShouldReturn5AndSum()
        {
            //arrange
            var testString = "asedr+fcse";
            var expected = "The first operator is +, and it is in the position 5";
            var verify = new ArithimeticExpresisonsVerifications();

            //act
            var result = verify.PositionAndTypeOfFirstOperator(testString);

            //assert
            Assert.Equal(expected, result);
        }
    }
}