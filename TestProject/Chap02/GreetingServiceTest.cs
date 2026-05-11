using TargetProject.Chap02;

namespace TestProject.Chap02;

[TestClass]
public class GreetingServiceTests
{
    [TestMethod]
    public void Greet_ShouldReturnGoodMorning_WhenHourIsMorning()
    {
        var greet = GreetingService.Greet(hour: 8);
        Assert.AreEqual("Good Morning", greet);
    }
}
