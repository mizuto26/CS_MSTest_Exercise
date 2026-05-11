namespace TargetProject.Chap02;

public class GreetingService
{
    public string Greet(int hour)
    {
        if (hour > 6 && hour < 12)
        {
            return "Good Morning";
        }
        else if (hour >= 12 && hour < 18)
        {
            return "Hello";
        }
        else if (hour >= 18 && hour < 21)
        {
            return "Good Evening";
        }
        else
        {
            return "Good Night";
        }
    }
}
