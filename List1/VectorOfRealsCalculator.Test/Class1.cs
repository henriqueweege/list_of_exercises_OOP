using Xunit;
using Library;

namespace VectorOfRealsCalculator.Test
{
    public class VectorOfRealsCalculatorTest
    {
        [Fact]
        public void MultiplyVectorsShouldReturn146()
        {
            //arrange
            var vectorTest = new List<double>() { 1.5, 2.5, 3.5 };
            var testObject = new VectorOfRealsCalculate(vectorTest);
            var expected = new List<double>() { 5.25, 6.25, 5.25 };
            
            //act
            var result = testObject.MultiplyVectors(vectorTest);

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CreateNewObjectShouldReturnNewObjectWith_Vector111()
        {
            //arrange
            var vectorTest = new List<double>() { 1, 2, 3 };
            var testObject = new VectorOfRealsCalculate(vectorTest);
            var expected = new List<double>() { 1, 1, 1 };

            //act
            var result = testObject.CreateNewObject(vectorTest);


            //assert
            Assert.Equal(expected, result._vector);

        }

        [Fact]
        public void CounterOfEvenNumberShouldReturn1()
        {
            //arrange
            var vectorTest = new List<double>() { 1, 2, 3 };
            var testObject = new VectorOfRealsCalculate(vectorTest);
            var expected = 1;

            //act
            var result = testObject.EvenNumbersCounter(vectorTest);

            //assert
            Assert.Equal(expected, result);        
        }

        [Fact]
        public void VectorInversorShouldReturn_vector321()
        {
            //arrange
            var vectorTest = new List<double>() { 1, 2, 3 };
            var testObject = new VectorOfRealsCalculate(vectorTest);
            var expected = new List<double>() { 3, 2, 1 };

            //act
            var result = testObject.VectorInversor(vectorTest);

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BiggestDifferenceBetweenElementsShouldReturn3()
        {
            //arrange
            var vectorTest = new List<double>() { 1, 4, 3 };
            var testObject = new VectorOfRealsCalculate(vectorTest);
            var expected = 3;

            //act
            var result = testObject.BiggestDifferenceBetweenElements(vectorTest);

            //assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void BiggestDifferenceBetweenElementsShouldReturn5()
        {
            //arrange
            var vectorTest = new List<double>() { 1, -4 };
            var testObject = new VectorOfRealsCalculate(vectorTest);
            var expected = 5;

            //act
            var result = testObject.BiggestDifferenceBetweenElements(vectorTest);

            //assert
            Assert.Equal(expected, result);
        }
    }
}