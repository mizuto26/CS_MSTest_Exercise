namespace TargetProject.Practice;

public class CalculatorService(ICalculator calculator)
{
    private readonly ICalculator _calculator = calculator;

    public string Execute(int x, int y)
    {
        string result = "";

        try
        {
            var answer = _calculator.Div(x, y);
            result = $"{x} ÷ {y} = {answer}";
        }
        catch (DivideByZeroException e)
        {
            result = $"エラー:{e.Message}";
        }
        return result;
    }
}