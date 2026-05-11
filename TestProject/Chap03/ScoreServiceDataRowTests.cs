using TargetProject.Chap02;
namespace TestProject.Chap03;

[TestClass]
public class ScoreServiceDataRowTests
{
    private ScoreService? scoreService;

    [TestInitialize]
    public void SetUp()
    {
        scoreService = new ScoreService();
    }

    [DataTestMethod]
    [DataRow(80, true, DisplayName = "合格点を大きく上回る場合は true を返す")]

    public void IsPassed_ShouldReturnExpectedResult_WhenScoreIsGiven(int score, bool expected)
    {
        var isPassed = scoreService!.IsPassed(score);
        Assert.AreEqual(expected, isPassed);
    }
}
