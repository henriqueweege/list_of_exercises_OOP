using Library;

public class Exercise7
{
    public static void Main(string [] args)
    {
        var vampireNumber = "1260";
        var verifyVampireNumber = new VampireNumberVerifyer();

        Console.WriteLine(verifyVampireNumber.VerifyVampireNumber(vampireNumber));

    }
}
