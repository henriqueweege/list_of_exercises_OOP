namespace Library
{
    public  class ITCalculator
    {
        public  double CalculateIT(double Income)
        {
            if (Income > 0 && Income < 4001)
            {
                return Math.Round(Income * 0, 2);
            }
            if (Income >= 4001 && Income < 9001)
            {
                return Math.Round(Income * 0.058, 2);
            }
            if (Income >= 9001 && Income < 25001)
            {
                return Math.Round(Income * 0.15, 2);
            }
            if (Income >= 25001 && Income < 35000)
            {
                return Math.Round(Income * 0.275, 2);
            }
            if (Income >= 35000)
            {
                return Math.Round(Income * 0.3, 2);
            }
            return 0;

        }
    }
}