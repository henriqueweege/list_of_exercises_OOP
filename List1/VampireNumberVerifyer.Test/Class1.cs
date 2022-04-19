using Library;
using Xunit;

namespace VampireNumberVerifyer.Test
{
    public class VampireNumberVerifyerTest
    {
        [Fact]
        public void FormPairsShouldReturnPairsOfZeros()
        {
            //arrange
            var number = "1020";
            var possibleVampire = new List<int>() { 1, 0, 2, 0 };
            var positions = new List<int>() { 0, 1, 2, 3 };
            var sortPairs = new VampireNumberVerify(number);
            var expected = new List<int>() { 00, 00 };

            //act
            var result = sortPairs.FormPairs(possibleVampire, positions);


            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TransformNumberInListShouldReturnAListOfIntegers()
        {
            //arrange
            var number = "1234";
            var expected = new List<int>() { 1, 2, 3, 4 };
            var transforNumberInList = new VampireNumberVerify(number);

            //act
            var result = transforNumberInList.TransformNumberInList(number);

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IfNumberIsEvenShouldReturnTrue()
        {
            //arrange
            var number = "1234";
            var numberList = new List<int>() { 1, 2, 3, 4 };
            var ifNumberIsEven = new VampireNumberVerify(number);
            var expected = true;

            //act
            var result = ifNumberIsEven.IfNumberIsEven(numberList);

            //assert
            Assert.Equal(expected, result);

        }
        [Fact]
        public void IfNumberIsEvenShouldReturnFalse()
        {
            //arrange
            var number = "12345";
            var numberList = new List<int>() { 1, 2, 3, 4, 5 };
            var ifNumberIsEven = new VampireNumberVerify(number);
            var expected = false;

            //act
            var result = ifNumberIsEven.IfNumberIsEven(numberList);

            //assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void VampirNumberTryShouldReturnTrue()
        {
            //arrange
            var number = "1260";
            var pairs = new List<int>() { 21, 60 };
            var vampireTry = new VampireNumberVerify(number);
            var expected = true;

            //act
            var result = vampireTry.VampireNumberTry(pairs);

            //assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void VampirNumberTryShouldReturnFalse()
        {
            //arrange
            var number = "1260";
            var pairs = new List<int>() { 12, 60 };
            var vampireTry = new VampireNumberVerify(number);
            var expected = false;

            //act
            var result = vampireTry.VampireNumberTry(pairs);

            //assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void SortListShouldReturnListWithTwentyFourItems()
        {
            //arrange
            var number = "1260";
            var possibleVampire = new List<int>() { 1,2,6,0 };
            var sortList = new VampireNumberVerify(number);
            var expected = 24;

            //act
            var result = sortList.SortList(possibleVampire).Count;

            //assert
            Assert.Equal(expected,result);
        }
    }
}
