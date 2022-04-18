using Library;

public class Exercise7
{
    public static void Main(string [] args)
    {
        var vampireNumber = "2187";
        var verifyVampireNumber = new VampireNumberVerify(vampireNumber);

        var list = verifyVampireNumber.TransformNumberInList(vampireNumber);
        var positions = verifyVampireNumber.SortList(list);
        var count = 0;

            for(int i = 0; i < positions.Count; i++)
            {
                var positionCombinationInTest = verifyVampireNumber.TransformNumberInList(positions[i]);
                var pairs = verifyVampireNumber.FormPairs(list ,positionCombinationInTest);
                count++;
                var validation = verifyVampireNumber.VampireNumberTry(pairs);


                if (validation)
                {
                    Console.WriteLine("It is a vampire");
                    break;
                }
                if(validation == false && count == 24)
                {
                    Console.WriteLine("It is not a vampire");
                    break;
                }
            }

           


       // Console.WriteLine(verifyVampireNumber.VerifyVampireNumber(vampireNumber));

    }
}
