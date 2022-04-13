using Library;

public class Exercise6
{
    public static void Main(string [] args)
    {
        var expressionCheck = new ArithimeticExpresisonsVerifications();
        var arithimeticExpression = "(a + 10) / (23 * (10.5 - b) - 2.59 / (b * a))";
        var isParentesisRight = expressionCheck.ParentesisVerify(arithimeticExpression);
        var quantityOfDivisionsAndMultiplications = expressionCheck.DivisionAndMultiplicationCounter(arithimeticExpression);
        var positionAndTypeOfFirstOperator = expressionCheck.PositionAndTypeOfFirstOperator(arithimeticExpression);

        Console.WriteLine(isParentesisRight);
        Console.WriteLine(quantityOfDivisionsAndMultiplications);
        Console.WriteLine(positionAndTypeOfFirstOperator);
    }
}
