using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

class AdminOperations
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser()
    {
        Console.WriteLine("User deleted");
    }
}

class RoleAllowedDemo
{
    public void Run()
    {
        string currentRole = "USER";

        MethodInfo method =
            typeof(AdminOperations).GetMethod("DeleteUser")!;

        RoleAllowedAttribute? attribute =
            method.GetCustomAttribute<RoleAllowedAttribute>();

        if (attribute?.Role != currentRole)
        {
            Console.WriteLine("Access Denied!");
            return;
        }

        method.Invoke(new AdminOperations(), null);
    }
}