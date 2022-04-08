using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios_1.Exercício_1
{
    public  static class CalculaIR
    {
        public static double CalcularIR(double Salario)
        {
            if (Salario > 0 && Salario < 4001)
            {
                return Salario * 0;
            }
            if (Salario >= 4001 && Salario < 9001)
            {
                return Salario * 0.058;
            }
            if (Salario >= 9001 && Salario < 25001)
            {
                return Salario * 0.15;
            }
            if (Salario >= 25001 && Salario < 35000)
            {
                return Salario * 0.275;
            }
            if (Salario >= 35000)
            {
                return Salario * 0.3;
            }
            return 0;

        }
    }
}
