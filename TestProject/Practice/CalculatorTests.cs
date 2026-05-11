using TargetProject.Practice;
/// <summary>
/// Calculatorクラスに実装されたメソッドの単体テストドライバ
/// </summary>
namespace TestProject.Practice;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Add_ShouldReturnSum_WhenBothHaveValues()
    {
        // Arrange(準備)
        int? x = 1;
        int? y = 2;
        // Act(実行)
        var result = Calculator.Add(x, y);
        // Assert(確認)
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void Add_ShouldReturnNull_WhenXIsNull()
    {
        // Arrange(準備)
        int? x = null;
        int? y = 2;
        // Act(実行)
        var result = Calculator.Add(x, y);
        // Assert(確認)
        Assert.IsNull(result);
    }

    [TestMethod]
    public void Add_ShouldReturnNull_WhenYIsNull()
    {
        // Arrange(準備)
        int? x = 1;
        int? y = null;
        // Act(実行)
        var result = Calculator.Add(x, y);
        // Assert(確認)
        Assert.IsNull(result);
    }

    [TestMethod]
    public void Add_ShouldReturnNull_WhenBothAreNull()
    {
        // Arrange(準備)
        int? x = null;
        int? y = null;
        // Act(実行)
        var result = Calculator.Add(x, y);
        // Assert(確認)
        Assert.IsNull(result);
    }
}
