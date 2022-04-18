using Library;
using Xunit;

namespace VampireNumberVerifyer.Test
{
    public class VampireNumberVerifyerTest
    {
        [Fact]
        public void SortPairsShouldReturnInvertedNumber()
        {
            //arrange

            var pairs = new List<int>();
            var sortPairs = new VampireNumberVerify();
            var number = "1827";

            //act
            pairs.Add(21);
            pairs.Add(60);
            var result = sortPairs.VampireNumberTry(pairs, number);
            

            //assert
            Assert.Equal(true, result);
        }
    }
}