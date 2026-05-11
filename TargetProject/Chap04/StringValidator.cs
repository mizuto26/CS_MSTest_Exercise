namespace TargetProject.Chap04;

public class StringValidator
{
    public void ValidateName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("名前を入力してください");
        }

        if (name.Length > 20)
        {
            throw new ArgumentException("名前は20文字以内で入力してください");
        }
    }
}