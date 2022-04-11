using Library;

internal class Program
{
    static void Main(string[] args)
    {
        Calculations calculo = new Calculations();
        while (true)
        {
            Console.WriteLine("Write the number for the math operations: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number == (int)number && number > 0)
            {
                var random = new Random();
                int index = random.Next(1, 10);



                if (index == 1)
                {
                    Console.WriteLine($"Random number is {index} - Is Integer");
                    Console.WriteLine(calculo.IsInt(number));
                }
                if (index == 2)
                {
                    Console.WriteLine($"Random number is {index} - Multiply per Last Integer");
                    Console.WriteLine(calculo.MultiplyLastInteger((int)number));

                }
                if (index == 3)
                {
                    Console.WriteLine($"Random number is {index} - Factorial");
                    Console.WriteLine($"The factorial of {(int)number} is {calculo.Factorial((int)number)}");
                }
                if (index == 4)
                {
                    Console.WriteLine($"Random number is {index} - How much integer divisors the number has, and who they are");
                    var divisors = new List<int>();
                    divisors = calculo.Divisors((int)number);
                    Console.WriteLine($"The number {(int)number} has {divisors.Count} divisors " +
                        $"and they are");
                    foreach (int i in divisors)
                    {
                        Console.Write($"{i}; ");
                    }
                    Console.WriteLine();
                }
                if (index == 5)
                {
                    Console.WriteLine($"Random number is {index} - Fibonacci sequence");
                    var fibo = new List<int>();
                    fibo = calculo.Fibo((int)number);
                    Console.WriteLine($"The Fibonacci series with {(int)number} elements is:");
                    foreach (int i in fibo)
                    {
                        Console.Write($"{i}; ");
                    }
                    Console.WriteLine();
                }
                if (index == 6)
                {
                    Console.WriteLine($"Random number is {index} - First Formula");
                    Console.WriteLine($"The result of the first formula is: {calculo.FirstFormula((int)number)}");
                }
                if (index == 7)
                {
                    Console.WriteLine($"Random number is {index} - Second Formula");
                    Console.WriteLine($"The result of the second formula is: {calculo.SecondFormula((int)number)}");
                }
                if (index == 8)
                {
                    Console.WriteLine($"Random number is {index} - Third Formula");
                    Console.WriteLine($"The result of the third formula is: {calculo.ThirdFormula((int)number)}");
                }
                if (index == 9)
                {
                    Console.WriteLine($"Random number is {index} - Forth Formula");
                    Console.WriteLine($"The result of the forth formula is: {calculo.ForthFormula((int)number)}");
                }
            }
            else
            {
                Console.WriteLine("It is not an integer or it is not positiv");
            }
            string anotherNumber;
            while (true)
            {
                Console.WriteLine("Do you want to do another operation?Y/N ");
                anotherNumber = Console.ReadLine();
                if (anotherNumber == "Y" || anotherNumber == "N")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (anotherNumber == "N")
            {
                break;
            }
            else
            {
                continue;
            }
        }
    }
}
