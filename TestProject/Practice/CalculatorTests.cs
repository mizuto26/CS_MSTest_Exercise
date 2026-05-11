using TargetProject.Practice;
namespace TestProject.Practice;

[TestClass]
public class CalculatorTests
{
    private Calculator? calculator;

    [TestInitialize]
    public void SetUp()
    {
        calculator = new Calculator();
    }

    [TestMethod]
    public void Add_ShouldReturnSum_WhenBothHaveValues()
    {
        int? x = 1;
        int? y = 2;
        var result = calculator!.Add(x, y);
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void Add_ShouldReturnNull_WhenXIsNull()
    {
        int? x = null;
        int? y = 2;
        var result = calculator!.Add(x, y);
        Assert.IsNull(result);
    }

    [TestMethod]
    public void Add_ShouldReturnNull_WhenYIsNull()
    {
        int? x = 1;
        int? y = null;
        var result = calculator!.Add(x, y);
        Assert.IsNull(result);
    }

    [TestMethod]
    public void Add_ShouldReturnNull_WhenBothAreNull()
    {
        int? x = null;
        int? y = null;
        var result = calculator!.Add(x, y);
        Assert.IsNull(result);
    }
}
