namespace Library
{
    public class MaiorIR : Contribuinte
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