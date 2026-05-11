using TargetProject.Chap04;
namespace TestProject.Chap04;

[TestClass]
public class CalculatorServiceTest
{
    private CalculatorService? calculatorService;

    [TestInitialize]
    public void SetUp()
    {
        calculatorService = new CalculatorService();
    }

    [DataTestMethod]
    [DataRow(10, 2, DisplayName = "テストケース:10 ÷ 2")]

    public void Div_Test(int x, int y)
    {
        var result = calculatorService!.Div(x, y);
        Assert.AreEqual(5, result);
    }
}