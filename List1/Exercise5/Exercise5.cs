

using ClassExercise5;

public class Exercise5
{

    public static void Main(string[] args)
    {
        
        var phrase = "this is one phrase";
        var manipulator = new StringManipulator();

        foreach(var word in manipulator.TakeSpacesOff(phrase))
        {
            Console.Write(word +" ");
            Console.WriteLine(word.Length);

        }

        
        Console.ReadLine();

    }
}
