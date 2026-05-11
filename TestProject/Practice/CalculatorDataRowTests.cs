using TargetProject.Practice;
namespace TestProject.Practice;

[TestClass]
public class CalculatorDataRowTests
{
    private Calculator? calculator;

    public void SetUp()
    {
        calculator = new Calculator();
    }

    [Ignore("テストがスキップされることを確認する")]
    [DataTestMethod]
    [DataRow(1, 2, 3, DisplayName = "テストケース1:両方に値がある場合")]
    [DataRow(null, 2, null, DisplayName = "テストケース2:引数xがnullの場合")]
    [DataRow(1, null, null, DisplayName = "テストケース3:引数yがnull の場合")]
    [DataRow(null, null, null, DisplayName = "テストケース4:両方の引数がnullの場合")]

    public void Add_ReturnsExpectedResult(int? x, int? y, int? expected)
    {
        var result = calculator!.Add(x, y);
        Assert.AreEqual(expected, result);
    }
}