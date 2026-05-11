using TargetProject.Practice;
namespace TestProject.Practice;

[TestClass]
public class CalculatorDataRowTests
{
    private Calculator? calculator;

    [TestInitialize]
    public void SetUp()
    {
        calculator = new Calculator();
    }

    [DataTestMethod]
    [DataRow(10, 0, DisplayName = "テストケース5:10 ÷ 0")]
    [DataRow(20, 0, DisplayName = "テストケース6:20 ÷ 0")]

    public void Div_ShouldThrowArgumentException_WhenInvalidInput(int x, int y)
    {
        var exception = Assert.ThrowsException<ArgumentException>(() => calculator!.Div(x, y));
        Assert.AreEqual("ゼロ除算はできません。", exception.Message);
    }
}