namespace Library
{
    public class ArithimeticExpresisonsVerifications
    {
        public string ParentesisVerify(string EXPRESSION)
        {
            var expression = EXPRESSION;
            var parentesis = new List<char>();
            foreach(var character in expression)
            {
                if (character == ')' && parentesis.Count == 0)
                {
                    return "The parentesis aren't right";
                }
                if (character == '(')
                {
                    parentesis.Add(character);
                }
                else if (character == ')')
                {
                    parentesis.Remove(parentesis[0]);
                }
            }
            return "The parentesis are right";
        }

        public string DivisionAndMultiplicationCounter(string EXPRESSION)
        {
            var division = 0;
            var multiplication = 0;
            foreach(var character in EXPRESSION)
            {
                if (character == '*')
                {
                    multiplication++;
                }
                if (character == '/')
                {
                    division++;
                }
            }
            return $"The number of Division in the expression if {division}, and the number of multiplication is {multiplication}";
        }

        public string PositionAndTypeOfFirstOperator(string EXPRESSION)
        {
            var positionOfOperator = new List<int>(){
                EXPRESSION.IndexOf("+"),
                EXPRESSION.IndexOf("-"),
                EXPRESSION.IndexOf("*"),
                EXPRESSION.IndexOf("/")
                };
            positionOfOperator.Sort();
            return $"The first operator is {EXPRESSION[positionOfOperator[0]]}, and it is in the position {positionOfOperator[0]}";

        }
    }
}