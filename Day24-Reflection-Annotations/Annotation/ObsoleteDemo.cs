using System;

class LegacyAPI
{
    [Obsolete("Use NewFeature instead")]
    public void OldFeature()
    {
        Console.WriteLine("Old feature");
    }

    public void NewFeature()
    {
        Console.WriteLine("New feature");
    }
}

class ObsoleteDemo
{
    public void Run()
    {
        LegacyAPI api = new LegacyAPI();

        api.OldFeature();
        api.NewFeature();
    }
}