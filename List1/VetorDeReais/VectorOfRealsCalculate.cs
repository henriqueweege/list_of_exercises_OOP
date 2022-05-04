namespace Library
{
    public class VectorOfRealsCalculate
    {
        public List<double> _vector;
        public VectorOfRealsCalculate(List<double> vector)
        {
            _vector = vector;
        }

        public List<double> MultiplyVectors(List<double> anotherVector)
        {
            var resultOfMultiply = new List<double>();
            for (int i = 0; i < _vector.Count; i++)
            {
                resultOfMultiply.Add(_vector[i]*anotherVector[(anotherVector.Count-1) - i]);
                Console.WriteLine($"{_vector[i]}, {anotherVector[(anotherVector.Count - 1) - i]}");
            }
            return resultOfMultiply;
            
        }

        public VectorOfRealsCalculate CreateNewObject(List<double> anotherVector)
        {
            var resultOfDivision = new List<double>();
            for (int i = 0; i < _vector.Count; i++)
            {
                resultOfDivision.Add(_vector[i] / anotherVector[i]);
                Console.WriteLine($"{_vector[i]}, {anotherVector[i]}");
            }
            return new VectorOfRealsCalculate(resultOfDivision);
        }

        public int EvenNumbersCounter(List<double> vectorToCount)
        {
            int quantityOfEven = 0;
            for(int i =0; i < vectorToCount.Count; i++)
            {
                if((int)vectorToCount[i] %2 == 0)
                {
                    quantityOfEven++;
                }
            }
            return quantityOfEven;
        }
        
        public List<double> VectorInversor(List<double> vectorToInvert)
        {
            var vectorInverted = new List<double>();
            for(int i = vectorToInvert.Count -1; i >= 0; i--) { 
                vectorInverted.Add(vectorToInvert[i]);
            }
            return vectorInverted;
        }

        public double BiggestDifferenceBetweenElements(List<double> vectorToCheck)
        {
            double difference = 0;
            for (int i = 0; i < vectorToCheck.Count -1; i++)
            {
                if ((vectorToCheck[i] < vectorToCheck[i + 1]))
                {
                    if ((vectorToCheck[i +1] - vectorToCheck[i]) > difference)
                        difference = vectorToCheck[i +1] - vectorToCheck[i];
                }
                else
                {
                    if ((vectorToCheck[i] - vectorToCheck[i +1]) > difference)
                        difference = vectorToCheck[i] - vectorToCheck[i +1];
                }

            }
            if (difference < 0)
                return difference * -1;
            return difference;
        }
    }
}