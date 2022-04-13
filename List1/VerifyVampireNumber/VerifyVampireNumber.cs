namespace Library
{
    public class VampireNumberVerifyer
    {
        public string VerifyVampireNumber(string NUMBER)
        {
            var number = TransformNumberInList(NUMBER);
            
            if (IfNumberIsEven(number) == false)
            {
                return "The quantity of numbers in a vampire number should be even.";
            }
            while (true)
            {
               
            }
            //fazer o count aqui, pra ver se não está repetindo as combinações
            if ( multiply  == num )
            {
                return "It is a vampire number.";
            }
            else
            {
                return "It is not a vampire number.";
            }


        }
        public List<int> TransformNumberInList(string NUMBER)
        {
            var number = new List<int>();
            foreach (var item in NUMBER)
            {
                int convert = item - '0';
                number.Add(convert);
            }
            return number;
        }

        public List<int> FormPars(List<int> NUMBER)
        {
            var count = 0;
            var numberPars = new List<int>();
            var pairs = "";
            
            while (count <= ((NUMBER.Count / 2) - 1))
            {
              pairs += NUMBER[count];
              count++;
            }
            numberPars.Add(Int32.Parse(pairs));
            while(count > 0)
            {
              pairs += NUMBER[count];
              count++;
            }
            numberPars.Add(Int32.Parse(pairs));
            return numberPars;

        }
        public bool IfNumberIsEven(List<int> NUMBER)
        {
            if(NUMBER.Count%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool VampireNumberTry(List<int> PAIRS, string NUMBER)
        {
            var pairs = PAIRS;
            var firstPair = PAIRS[0];
            var secondPair = PAIRS[1];
            var count = 0;
            while (true)
            {
                if(firstPair == PAIRS[0] && secondPair == PAIRS[1] && count != 0)
                {
                    return false;
                }
                if(firstPair * secondPair == Int32.Parse(NUMBER))
                {
                    return true;
                }
                else
                {
                    pairs = SortPairs(PAIRS);
                    count++;
                }
            }
            
        }
        public List<int> SortPairs(List<int> PAIRS)
        {
            var newPairs = new List<int>();
            var firstPair = PAIRS[0];
            var secondPair = PAIRS[1];
            var sortedPairs = new List<char>();
            var count = PAIRS.Count /2 -1;
            while(count >= 0)
            {
                sortedPairs.Add(' ');
                count--;
            }
            count = PAIRS.Count / 2 - 1;
            foreach (var num in firstPair.ToString())
            {
                sortedPairs[count]=num;
                count--;
            }
            count = PAIRS.Count - 1;
            foreach (var num in secondPair.ToString())
            {
                sortedPairs[count] = num;
                count--;
            }
            foreach(var character in sortedPairs)
            {
                int convert = character - '0';
                newPairs.Add(convert);
            }
            return newPairs;
        }
    }
}