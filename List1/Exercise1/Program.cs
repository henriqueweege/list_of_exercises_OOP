using Library;

internal class Program
{
    public static void Main(string[] args)

    {

        List<Contribuintes> contribuinte = new List<Contribuintes>();
        List<string> Nome = new List<string>();
        List<string> Cpf = new List<string>();
        List<string> Uf = new List<string>();
        List<int> Salario = new List<int>();

        while (true)
        {
            Console.WriteLine("Escreva o nome do contribuinte ou S para sair: ");
            string nome = Console.ReadLine();
            if (nome == "S")
            {
                break;
            }
            Nome.Add(nome);
            Console.WriteLine("Escreva o CPF do contribuinte : ");
            string cpf = Console.ReadLine();
            Cpf.Add(cpf);
            Console.WriteLine("Escreva o UF do contribuinte : ");
            string uf = Console.ReadLine();
            Uf.Add(uf);
            Console.WriteLine("Escreva o Salario do contribuinte : ");
            int salario = Int32.Parse(Console.ReadLine());
            Salario.Add(salario);

        }
        for (int i = 0; i < Nome.Count; i++)
        {
            contribuinte.Add(new Contribuintes { nome = Nome[i], cpf = Cpf[i], uf = Uf[i], salario = Salario[i] });
            contribuinte[i].ir = CalcularIR.CalculaIR(contribuinte[i].salario);
            MaiorIR.CalculaMaiorIR(contribuinte[i].nome, contribuinte[i].ir);
        }

        for (int i = 0; i < contribuinte.Count; i++)
        {
            Console.WriteLine($"nome do contribuinte {contribuinte[i].nome}");
            Console.WriteLine($"salario do contribuinte {contribuinte[i].salario}");
            Console.WriteLine($"ir do contribuinte {contribuinte[i].ir}");
        }
        Console.WriteLine($"O Contribuinte que vai pagar mais IR é {MaiorIR.nomeMaiorIR}, no valor de {MaiorIR.maiorIR}");


        Console.ReadLine();
    }
}
