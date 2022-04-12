using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Calculations
    {
        public int lastInput = 0;


        public string IsInteger(double num)
        {

            if (num == (int)num)
            {
                lastInput = (int)num;
                return $"The number {(int)num} is an integer";
            }
            lastInput = (int)num;
            return $"The number {num} is not an integer";
        }
        public int MultiplyLastInput(int num)
        {
    
            int result = num * lastInput;
            lastInput = num;
            return result;
        }

        public ulong Factorial(int num)
        {
            ulong fat = (ulong)num;
            ulong increment = 1;
            for (int i = num; i > 1; i--)
            {
                fat *= (ulong)num - increment;
                increment++;
            }
            lastInput = num;
            return fat;
        }
        public List<int> Divisors(int num)
        {
            var listDivisors = new List<int>();
            for (int i = num; i > 0; i--)
            {
                if (num % i == 0)
                {
                    listDivisors.Add(i);
                }
            }
            lastInput = num;
            return listDivisors;
        }
        public List<int> Fibo(int num)
        {
            var listFibo = new List<int>();
            listFibo.Add(0);
            listFibo.Add(1);
            if (num == 1)
            {
                listFibo.Clear();
                listFibo.Add(0);
            }
            else
            {
                for (int i = listFibo.Count; i != num; i++)
                {
                    listFibo.Add(listFibo[listFibo.Count - 1] + listFibo[listFibo.Count - 2]);

                }
            }
            lastInput = num;
            return listFibo;
        }
        public double FirstFormula(int num)
        {
            double result = 1;
            for (int i = 2; i <= num; i++)
            {
                result += 1 / (double)i;
            }
            lastInput = num;
            return Math.Round(result, 2);
        }
        public double SecondFormula(int num)
        {
            double result = 0;
            int increment = 1;
            for (int i = num; i > 0; i--)
            {
                result += increment / (double)i;
                increment++;
            }
            lastInput = num;
            return result;
        }
        public double ThirdFormula(int num)
        {
            double result = 0;
            int increment = 1;
            for (int i = 20; i > 1; i--)
            {
                result += Math.Pow(num, i) / Factorial(increment);
                increment++;
            }
            lastInput = num;
            return Math.Round(result, 2);
        }
        public double ForthFormula(int num)
        {
            double result = 0;
            long numerator = 1;
            int denominator = 2;
            for (int i = num; i > 0; i--)
            {

                result += (numerator / (double)Factorial(denominator));
                if (i != 1)
                {
                    result -= (numerator++ / (double)Factorial(denominator + 2));
                    i--;
                }
                  
                numerator ++;
                denominator +=  4;
            }
            lastInput = num;
            return Math.Round(result, 2);

        }

    }
}
