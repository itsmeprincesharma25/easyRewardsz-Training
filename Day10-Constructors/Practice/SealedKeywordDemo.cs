using System;

namespace Practice
{
    class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class");
        }
    }

    class Child : Parent
    {
        public sealed override void Show()
        {
            Console.WriteLine("Child Class");
        }
    }

    class GrandChild : Child
    {
        // This method cannot be overridden because
        // Show() is sealed in Child class.
    }

    sealed class FinalClass
    {
        public void Display()
        {
            Console.WriteLine("This is a sealed class.");
        }
    }
}