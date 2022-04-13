using Library;
using Xunit;

namespace StringManipulator.Tests
{
    public class StringManipulatorTests
    {
        [Fact]
        public void TakeSpacesOffTest()
        {
            //arrange
            var phrase = "           this      is one         phrase    ";
            var expected = new List<string> { "this", "is", "one", "phrase"};
            var takeSpacesOff = new StringScissor();

            //act
            var result = takeSpacesOff.TakeSpacesOff(phrase);

            //assert
            Assert.Equal(expected, result);
        }
    }
}