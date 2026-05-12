namespace TargetProject.Chap06;

public class NotificationService(IEmailSender emailSender)
{
    private readonly IEmailSender _emailSender = emailSender;

    public void Notify(string userEmail)
    {
        _emailSender.Send(userEmail, "通知があります");
    }
}