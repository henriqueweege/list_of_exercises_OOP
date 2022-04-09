using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public class Calculos_Integer_Positiv
    {
        private const double V = 1.0000;
        public int lastInt;
        public double num;
        public int resultMultiplyLastInt;



        public string IsInt(double Num)
        {

            if (Num == (int)Num)
            {
                lastInt = (int)Num;
                return $"The number {(int)Num} is an integer";
            }

            return $"The number {Num} is not an integer";
        }
        public string MultiplyLastInteger(int Num)
        {
            if (lastInt == 0)
            {
                lastInt = Num;
                return "This is the first number you enter the progrma, or your last number was 0.";
            }
            else
            {
                resultMultiplyLastInt = Num * lastInt;
                string message = $"The result of the multiplication of {Num}  and {lastInt} is " +
                                $"{resultMultiplyLastInt}";
                lastInt = Num;
                return message;
            }
        }

        public int Factorial(int num)
        {
            int fat = num;
            int increment = 1;
            for (int i = num; i > 0; i--)
            {
                fat *= num - increment;
                increment++;
            }
            lastInt = num;
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
            lastInt = num;
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
            lastInt = num;
            return listFibo;
        }
        public double FirstFormula(int num)
        {
            double result = 1.00;
            for (int i = 2; i <= num; i++)
            {
                double division = 1 / (float)i;
                result += division;
            }
            lastInt = num;
            return result;
        }
        public double SecondFormula(int num)
        {
            double result = 0;
            int increment = 1;
            for (int i = num; i > 0; i--)
            {
                result += increment / (float)i;
                increment++;
            }
            lastInt = num;
            return result;
        }
        public double ThirdFormula(int num)
        {
            double result = 0;
            int increment = 1;
            for (int i = 20; i > 0; i--)
            {
                result += (num ^ i) / (double)increment;
                increment++;
            }
            lastInt = num;
            return result;
        }
        public double ForthFormula(int num)
        {
            double result = 0;
            int numerator = 1;
            int denominator = 2;
            for (int i = num; i > 0; i--)
            {
                result += (double)numerator / (double)Factorial(denominator) - (double)numerator++ / (double)Factorial(denominator * 2);
                numerator += 2;
                denominator += (denominator * 2) + 2;
            }
            lastInt = num;
            return result;

        }


    }
}
