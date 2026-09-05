using System;

interface IReflectionGreeting
{
    void SayHello();
}

class ReflectionGreeting : IReflectionGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello from greeting service");
    }
}

class LoggingProxy
{
    public void Run()
    {
        IReflectionGreeting greeting = new ReflectionGreeting();

        Console.WriteLine("Calling method: SayHello");
        greeting.SayHello();
    }
}