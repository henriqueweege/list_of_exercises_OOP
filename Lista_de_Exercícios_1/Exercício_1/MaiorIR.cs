using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercícios_1.Exercício_1
{
    internal class MaiorIR : Contribuinte
    {
        static public string nomeMaiorIR;
        static public double maiorIR = 0;
        static public void CalculaMaiorIR(string NOME, double IR)
        {
            if (IR > maiorIR)
            {
                maiorIR = IR;
                nomeMaiorIR = NOME;
            }
        }
    }
}
