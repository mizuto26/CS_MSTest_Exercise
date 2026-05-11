using TargetProject.Chap02;

namespace TestProject.Chap02;

[TestClass]
public class ScoreServiceTest
{
    private ScoreService? scoreService;

    [TestInitialize]
    public void SetUp()
    {
        scoreService = new ScoreService();
    }

    [TestMethod]
    public void Score_ShouldReturnTrue_ScoreIsPassed()
    {
        var isPassed = scoreService!.IsPassed(score: 80);
        Assert.AreEqual(true, isPassed);
    }
}
