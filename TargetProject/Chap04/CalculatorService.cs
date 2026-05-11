namespace TargetProject.Chap04;

public class CalculatorService
{
    public int Div(int x, int y)
    {
        if (x >= 100 || y >= 100)
        {
            throw new ArgumentException("100以上の値は計算できません");
        }

        if (x < 0 || y < 0)
        {
            throw new ArgumentException("負の値は使用できません");
        }

        if (y == 0)
        {
            throw new DivideByZeroException("0 で割ることはできません");
        }

        return x / y;
    }
}