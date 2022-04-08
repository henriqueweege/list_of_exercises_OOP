using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.WriteLine("Write the number for the math operations: ");
                double number = Convert.ToDouble(Console.ReadLine());
                if (number == -1)
                {
                    break;
                }
                Calculos_Integer_Positiv calculo = new Calculos_Integer_Positiv();



                var divisors = new List<int>();
                divisors = calculo.Divisors((int)number);
                var fibo = new List<int>();
                fibo = calculo.Fibo((int)number);

                Console.WriteLine(calculo.IsInteger(number));


                Console.WriteLine($"The result of the multiplication of {number}  and {calculo.lastInteger} is " +
                    $"{calculo.MultiplyLastInteger((int)number)}");


                Console.WriteLine($"The factorial of {(int)number} is {calculo.Factorial((int)number)}");


                Console.WriteLine($"The number {(int)number} has {divisors.Count} divisors " +
                    $"and they are");
                foreach (int i in divisors)
                {
                    Console.Write($"{i}; ");
                }
                Console.WriteLine();


                Console.WriteLine($"The Fibonacci series with {(int)number} elements is:");
                foreach (int i in fibo)
                {
                   Console.Write($"{i}; ");
                }
                Console.WriteLine();



                Console.WriteLine($"The result of the first formula is: {calculo.FirstFormula((int)number)}");
                Console.WriteLine($"The result of the second formula is: {calculo.SecondFormula((int)number)}");
                Console.WriteLine($"The result of the third formula is: {calculo.ThirdFormula((int)number)}");
                Console.WriteLine($"The result of the forth formula is: {calculo.ForthFormula((int)number)}");
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
}
