using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write the number for the math operations: ");
                double number = Convert.ToDouble(Console.ReadLine());

                Calculos_Integer_Positiv calculo = new Calculos_Integer_Positiv();

                if (number == (int)number)
                {
                    Console.WriteLine("Index:");
                    Console.WriteLine("1 - Is Integer");
                    Console.WriteLine("2 - Multiply by last Integer");
                    Console.WriteLine("3 - Factorial");
                    Console.WriteLine("4 - Divisors");
                    Console.WriteLine("5 - Fibonacci");
                    Console.WriteLine("6 - First Formula");
                    Console.WriteLine("7 - Second Formula");
                    Console.WriteLine("8 - Third Formula");
                    Console.WriteLine("9 - Forth Formula");
                    Console.Write("Choose an operation: ");
                    int index = Int32.Parse(Console.ReadLine());
                    var divisors = new List<int>();
                    divisors = calculo.Divisors((int)number);
                    var fibo = new List<int>();
                    fibo = calculo.Fibo((int)number);

                    if (index == 1)
                    {

                        Console.WriteLine(calculo.IsInteger(number));
                    }
                    if (index == 2)
                    {
                        if (calculo.lastInteger == 0)
                        {
                            Console.WriteLine("This is the first number you enter the progrma, or your last number was 0.");
                        }
                        else
                        {
                            Console.WriteLine($"The result of the multiplication of {(int)number}  and {calculo.lastInteger} is " +
                                $"{calculo.MultiplyLastInteger((int)number)}");

                        }
                    }
                    if (index == 3)
                    {
                        Console.WriteLine($"The factorial of {(int)number} is {calculo.Factorial((int)number)}");
                    }
                    if (index == 4)
                    {
                        Console.WriteLine($"The number {(int)number} has {divisors.Count} divisors " +
                            $"and they are");
                        foreach(int i in divisors)
                        {
                            Console.Write($"{i}; ");
                        }
                        Console.WriteLine();
                    }
                    if (index == 5)
                    {
                        Console.WriteLine($"The Fibonacci series with {(int)number} elements is:");
                        foreach(int i in fibo)
                        {
                            Console.Write($"{i}; ");
                        }
                        Console.WriteLine();
                    }
                    if (index == 6)
                    {
                        Console.WriteLine($"The result of the first formula is: {calculo.FirstFormula((int)number)}");
                    }
                    if (index == 7)
                    {
                        Console.WriteLine($"The result of the second formula is: {calculo.SecondFormula((int)number)}");
                    }
                    if (index == 8)
                    {
                        Console.WriteLine($"The result of the third formula is: {calculo.ThirdFormula((int)number)}");
                    }
                    if (index == 9)
                    {
                        Console.WriteLine($"The result of the forth formula is: {calculo.ForthFormula((int)number)}");
                    }
                }
                else
                {
                    Console.WriteLine("It is not an integer");
                }
                string anotherNumber;
                while (true) {
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
                if(anotherNumber == "N")
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
}
