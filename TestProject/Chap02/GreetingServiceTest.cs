using TargetProject.Chap02;
namespace TestProject.Chap02;

[TestClass]
public class GreetingServiceTests
{
    private GreetingService? greetingService;

    [TestInitialize]
    public void SetUp()
    {
        greetingService = new GreetingService();
    }

    [TestMethod]
    public void Greet_ShouldReturnGoodMorning_WhenHourIsMorning()
    {
        var greet = greetingService!.Greet(hour: 8);
        Assert.AreEqual("Good Morning", greet);
    }
}
