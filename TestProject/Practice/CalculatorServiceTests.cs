using Moq;
using TargetProject.Practice;
namespace TestProject.Practice;

[TestClass]
public class CalculatorServiceTests
{
    private Mock<ICalculator> _mockCalculator = null!;
    private CalculatorService _service = null!;

    [TestInitialize]
    public void SetUp()
    {
        _mockCalculator = new Mock<ICalculator>();
        _service = new CalculatorService(_mockCalculator.Object);
    }

    [TestMethod("正常な除算結果を文字列で返す")]
    public void Execute_Normal_ReturnsFormattedResult()
    {
        _mockCalculator
            .Setup(calculator => calculator.Div(10, 2))
            .Returns(5);

        var result = _service.Execute(10, 2);
        Assert.AreEqual("10 ÷ 2 = 5", result);
        _mockCalculator.Verify(calculator => calculator.Div(10, 2), Times.Once);
    }

    [TestMethod("ゼロ除算時はエラーメッセージを返す")]
    public void Execute_DivideByZero_ReturnsErrorMessage()
    {
        _mockCalculator
            .Setup(calculator => calculator.Div(10, 0))
            .Throws(new DivideByZeroException("0で割ることはできません"));

        var result = _service.Execute(10, 0);
        Assert.AreEqual("エラー:0で割ることはできません", result);
        _mockCalculator.Verify(calculator => calculator.Div(10, 0), Times.Once);
    }
}