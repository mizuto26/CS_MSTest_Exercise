namespace TargetProject.Practice;

public class Calculator
{
    public int? Add(int? x, int? y)
    {
        return x + y;
    }

    public int Div(int x, int y)
    {
        if (y == 0)
        {
            throw new ArgumentException("ゼロ除算はできません。");
        }
        return x / y;
    }
}
