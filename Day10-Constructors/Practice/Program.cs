using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== this Keyword =====");
            ThisKeywordDemo obj1 = new ThisKeywordDemo("Prince", 21);
            obj1.Display();

            Console.WriteLine();

            Console.WriteLine("===== static Keyword =====");
            StaticKeywordDemo obj2 = new StaticKeywordDemo("Prince");
            StaticKeywordDemo obj3 = new StaticKeywordDemo("Rahul");

            obj2.Display();
            obj3.Display();
            StaticKeywordDemo.DisplayCount();

            Console.WriteLine();

            Console.WriteLine("===== sealed Keyword =====");
            Child child = new Child();
            child.Show();

            FinalClass finalClass = new FinalClass();
            finalClass.Display();

            Console.WriteLine();

            Console.WriteLine("===== is Operator =====");
            IsOperatorDemo demo = new IsOperatorDemo();
            demo.CheckType();
        }
    }
}