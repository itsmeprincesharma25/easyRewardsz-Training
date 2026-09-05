using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Value { get; }

    public MaxLengthAttribute(int value)
    {
        Value = value;
    }
}

class ValidatedUser
{
    [MaxLength(10)]
    public string Username;

    public ValidatedUser(string username)
    {
        FieldInfo field = typeof(ValidatedUser)
            .GetField("Username")!;

        MaxLengthAttribute? attribute =
            field.GetCustomAttribute<MaxLengthAttribute>();

        if (attribute != null &&
            username.Length > attribute.Value)
        {
            throw new ArgumentException("Username is too long");
        }

        Username = username;
    }
}

class MaxLengthDemo
{
    public void Run()
    {
        try
        {
            ValidatedUser user = new ValidatedUser("Prince");
            Console.WriteLine("Username: " + user.Username);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}