using TargetProject.Chap02;

namespace TestProject.Chap02;

[TestClass]
public class ScoreServiceTest
{
    [TestMethod]
    public void Score_ShouldReturnTrue_ScoreIsPassed()
    {
        var isPassed = ScoreService.IsPassed(score: 80);
        Assert.AreEqual(true, isPassed);
    }
}
