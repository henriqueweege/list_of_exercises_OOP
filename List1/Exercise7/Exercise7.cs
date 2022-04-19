using Library;

public class Exercise7
{
    public static void Main(string [] args)
    {
        var vampireNumber = "2080";
        var verifyVampireNumber = new VampireNumberVerify(vampireNumber);
        var list = verifyVampireNumber.TransformNumberInList(vampireNumber);
        var isEven = verifyVampireNumber.IfNumberIsEven(list);
        var positions = verifyVampireNumber.SortList(list);
        var count = 0;

        if (isEven)
        {
            for (int i = 0; i < positions.Count; i++)
            {
                var positionCombinationInTest = verifyVampireNumber.TransformNumberInList(positions[i]);
                var pairs = verifyVampireNumber.FormPairs(list, positionCombinationInTest);
                count++;
                var validation = verifyVampireNumber.VampireNumberTry(pairs);


                if (validation)
                {
                    Console.WriteLine("It is a vampire");
                    break;
                }
                if (validation == false && count == 24)
                {
                    Console.WriteLine("It is not a vampire");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("The number is not even");
        }

           


       // Console.WriteLine(verifyVampireNumber.VerifyVampireNumber(vampireNumber));

    }
}
