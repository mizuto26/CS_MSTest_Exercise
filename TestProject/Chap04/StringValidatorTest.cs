using TargetProject.Chap04;
namespace TestProject.Chap04;

[TestClass]
public class StringValidatorTest
{
    private StringValidator? stringValidator;

    [TestInitialize]
    public void SetUp()
    {
        stringValidator = new StringValidator();
    }

    [TestMethod]
    public void StringValidator_ShouldReturnAlice()
    {
        stringValidator!.ValidateName("Alice");
    }
}
