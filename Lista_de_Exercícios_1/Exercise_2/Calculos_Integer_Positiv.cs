using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Calculos_Integer_Positiv
    {
        public int lastInteger = 0;


        public string IsInteger(double num)
        {

            if (num == (int)num)
            {
                lastInteger = (int)num;
                return $"The number {(int)num} is an integer";
            }
            lastInteger = (int)num;
            return $"The number {num} is not an integer";
        }
        public int MultiplyLastInteger(int num)
        {

            int result = num * lastInteger;
            lastInteger = num;
            return result;
        }

        public int Factorial(int num)
        {
            int fat = num;
            int increment = 1;
            for (int i = num; i > 1; i--)
            {
                fat *= num - increment;
                increment++;
            }
            lastInteger = num;
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
            lastInteger = num;
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
            lastInteger = num;
            return listFibo;
        }
        public int FirstFormula(int num)
        {
            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result += 1 / i;
            }
            lastInteger = num;
            return result;
        }
        public int SecondFormula(int num)
        {
            int result = 0;
            int increment = 1;
            for (int i = num; i > 0; i--)
            {
                result += increment / i;
                increment++;
            }
            lastInteger = num;
            return result;
        }
        public int ThirdFormula(int num)
        {
            int result = 0;
            int increment = 1;
            for (int i = 20; i > 0; i--)
            {
                result += (num ^ i) / increment;
                increment++;
            }
            lastInteger = num;
            return result;
        }
        public int ForthFormula(int num)
        {
            float result = 0;
            int numerator = 1;
            int denominator = 2;
            for (int i = num; i > 0; i--)
            {
                result += ((float)numerator / (float)Factorial(denominator)) - ((float)numerator++ / (float)Factorial(denominator * 2));
                numerator += 2;
                denominator += (denominator * 2) + 2;
            }
            lastInteger = num;
            return (int)result;

        }

    }
}
