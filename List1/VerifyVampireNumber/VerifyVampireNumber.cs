namespace Library
{
    public class VampireNumberVerify
    {
        //int controlRepetition = 0;
        string vampireInput;
        //List<int> allPossibleVampireTries = new List<int>();
        //Random random = new Random();
        //List<int> newPossibleVampire = new List<int>();
        //int possibleVampireInt;

        public VampireNumberVerify(string Input){

            vampireInput = Input;
        }

        public string VerifyVampireNumber(string NUMBER)
        {
            var listVampireInput = TransformNumberInList(NUMBER);
            var tentativa = SortList(listVampireInput);
            if (IfNumberIsEven(listVampireInput))
            {
                if (tentativa.Count == 1)
                {
                    return "It is not a Vampire";
                }
                return $"Vampiro";
            }
            else
            {
                return "Number should be even.";
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
        public int TransformListInNumber (List<int> LISTA)
        {
            var position = 0;
            string number="";
            while (position <= LISTA.Count-1)
            {
                number = number + LISTA[position].ToString();
                position++;
            }
           
            var numberInt = Int32.Parse(number);
            return numberInt;
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
            pairs += POSSIBLEVAMPIRE[Positions[0]];
            pairs += POSSIBLEVAMPIRE[Positions[1]];
            numberPairs.Add(Int32.Parse(pairs));
            pairs = "";
            pairs += POSSIBLEVAMPIRE[Positions[2]];
            pairs += POSSIBLEVAMPIRE[Positions[3]];
            numberPairs.Add(Int32.Parse(pairs));

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
        //public List<int> SortList(List<int> POSSIBLEVAMPIRE)
        //{
            //var possibleVampire = POSSIBLEVAMPIRE.OrderBy(item => random.Next());
            //newPossibleVampire.Clear();
            //foreach(var item in possibleVampire)
            //{
                //newPossibleVampire.Add(item);
            //}
            //while(newPossibleVampire.Count < POSSIBLEVAMPIRE.Count())
            //{
                //newPossibleVampire.Add(0);
            //}
            //var newPossibleVampireNumber = TransformListInNumber(newPossibleVampire);
            //if (allPossibleVampireTries.Contains(newPossibleVampireNumber) && controlRepetition <= 10){
                //controlRepetition++;
                //SortList(newPossibleVampire);
            //}
            //allPossibleVampireTries.Add(newPossibleVampireNumber);
            //return newPossibleVampire;
           
        //}
    }
}