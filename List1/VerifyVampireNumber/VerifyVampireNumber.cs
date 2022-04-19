namespace Library
{
    public class VampireNumberVerify
    {
         string vampireInput;

        public VampireNumberVerify(string Input){

            vampireInput = Input;
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

        public bool IfNumberIsEven(List<int> NUMBER)
        {
            if (NUMBER.Count % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<int> FormPairs(List<int> POSSIBLEVAMPIRE, List<int> Positions)
        {

            var numberPairs = new List<int>();
            var pairs = "";
            var count = POSSIBLEVAMPIRE.Count;
            var countHalf = POSSIBLEVAMPIRE.Count / 2;
            var position = 0;
            var countZeros = 0;
            while(count > 0){
                while (countHalf > 0)
                {
                    if(POSSIBLEVAMPIRE[Positions[position]] == 0 && countHalf == 1)
                    {
                        countZeros++;
                    }
                    pairs += POSSIBLEVAMPIRE[Positions[position]];
                    count--;
                    countHalf--;
                    position++;
                }
                numberPairs.Add(Int32.Parse(pairs));
                pairs = "";
                countHalf = POSSIBLEVAMPIRE.Count / 2;
            }
            if(countZeros == 2)
            {
                numberPairs.Clear();
                numberPairs.Add(00);
                numberPairs.Add(00);
                return numberPairs;
            }
            return numberPairs;

        }

        public bool VampireNumberTry(List<int> PAIRS)
        {

            var firstPair = PAIRS[0];
            var secondPair = PAIRS[1];

            while (true)
            {
                if((firstPair * secondPair) == Int32.Parse(vampireInput))
                {
                    return true;
                }
                return false;
            }
            
        }
        public List<string> SortList(List<int> POSSIBLEVAMPIRE)
        {
           List<string> positions = new List<string>();
            var number = "";
           if(POSSIBLEVAMPIRE.Count == 4)
            {
                for(int i = 0; i < POSSIBLEVAMPIRE.Count; i++)
                    for(int j = 0; j < POSSIBLEVAMPIRE.Count; j++)
                        for(int k = 0; k < POSSIBLEVAMPIRE.Count; k++)
                            for(int l = 0; l < POSSIBLEVAMPIRE.Count; l++)
                            {
                                if (i != j &&
                                    i != k &&
                                    i != l &&
                                    j != k &&
                                    j != l &&
                                    k != l)
                                {
                                    number += i.ToString();
                                    number += j.ToString();
                                    number += k.ToString();
                                    number += l.ToString();

                                    positions.Add(number);

                                    number = "";
                                }

                            }
                

            }
            return positions;
        }
    }
}