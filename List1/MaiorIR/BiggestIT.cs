namespace Library
{
    public class BiggestIT : Citizens
    {
        static public string nameBiggestIT= "name";
        static public double biggestIT = 0;
        static public void CalculateBiggestIT(string NAME, double IT)
        {
            if (IT > biggestIT)
            {
                biggestIT = IT;
                nameBiggestIT = NAME;
            }
        }
    }
}