using Library;

internal class Program
{
    public static void Main(string[] args)

    {
        var CalculatorOfIT = new ITCalculator();
        List<Citizens> citizen = new List<Citizens>();
        List<string> Name = new List<string>();
        List<string> SocialSecurity = new List<string>();
        List<string> State = new List<string>();
        List<int> Income= new List<int>();

        while (true)
        {
            Console.WriteLine("Write the citizens name or S to break: ");
            string name = Console.ReadLine();
            if (name == "S")
            {
                break;
            }
            Name.Add(name);
            Console.WriteLine("Write de Social Security number of the citizen: ");
            string socialSecurity = Console.ReadLine();
            SocialSecurity.Add(socialSecurity);
            Console.WriteLine("Write the State where the citizen lives: ");
            string state = Console.ReadLine();
            State.Add(state);
            Console.WriteLine("Write the Income upon which the calculation should be done: ");
            int income = Int32.Parse(Console.ReadLine());
            Income.Add(income);

        }
        for (int i = 0; i < Name.Count; i++)
        {
            citizen.Add(new Citizens { name = Name[i], socialSecurity = SocialSecurity[i], state = State[i], income = Income[i] });
            citizen[i].it = CalculatorOfIT.CalculateIT(citizen[i].income);
            BiggestIT.CalculateBiggestIT(citizen[i].name, citizen[i].it);
        }

        for (int i = 0; i < citizen.Count; i++)
        {
            Console.WriteLine($"nome do contribuinte {citizen[i].name}");
            Console.WriteLine($"salario do contribuinte {citizen[i].income}");
            Console.WriteLine($"ir do contribuinte {citizen[i].it}");
        }
        Console.WriteLine($"O Contribuinte que vai pagar mais IR é {BiggestIT.nameBiggestIT}, no valor de {BiggestIT.biggestIT}");


        Console.ReadLine();
    }
}
