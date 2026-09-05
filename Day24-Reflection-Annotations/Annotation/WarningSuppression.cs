using System.Collections;

class WarningSuppression
{
    public void Run()
    {
#pragma warning disable CS0618
        ArrayList list = new ArrayList();
#pragma warning restore CS0618

        list.Add("Apple");
        list.Add("Mango");

        System.Console.WriteLine(list[0]);
        System.Console.WriteLine(list[1]);
    }
}