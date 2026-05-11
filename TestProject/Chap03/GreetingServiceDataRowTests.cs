using TargetProject.Chap02;
namespace TestProject.Chap03;

[TestClass]
public class GreetingServiceDataRowTests
{
    private GreetingService? greetingService;

    [TestInitialize]
    public void SetUp()
    {
        greetingService = new GreetingService();
    }

    [DataTestMethod]
    [DataRow(8, "Good Morning", DisplayName = "朝の時間帯(代表値)ではGood Morningを返す")]

    public void Greet_ShouldReturnGoodMorning_WhenHourIsMorning(int hour, string expected)
    {
        var greet = greetingService!.Greet(hour);
        Assert.AreEqual(expected, greet);
    }
}
