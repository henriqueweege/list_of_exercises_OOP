namespace Library
{
    public class MaiorIR : Contribuintes
    {
        static public string nomeMaiorIR= "nome";
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