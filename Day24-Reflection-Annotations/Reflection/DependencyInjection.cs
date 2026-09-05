using System;

[AttributeUsage(AttributeTargets.Property)]
class ReflectionInjectAttribute : Attribute
{
}

class MessageService
{
    public void Send()
    {
        Console.WriteLine("Message sent");
    }
}

class NotificationController
{
    [ReflectionInject]
    public MessageService? Service { get; set; }

    public void Run()
    {
        Service?.Send();
    }
}

class DependencyInjection
{
    public void Run()
    {
        NotificationController controller = new NotificationController();

        controller.Service = new MessageService();

        controller.Run();
    }
}