

using Library;

public class Exercise5
{

    public static void Main(string[] args)
    {
        
        var phrase = "           this      is one         phrase    ";
        var manipulator = new StringScissor();
        var count = 1;

        foreach(var word in manipulator.TakeSpacesOff(phrase))
        {
            Console.WriteLine($"The {count}º word is {word}, and it contains {word.Length} characters.");
            count++;

        }

        
        Console.ReadLine();

    }
}
