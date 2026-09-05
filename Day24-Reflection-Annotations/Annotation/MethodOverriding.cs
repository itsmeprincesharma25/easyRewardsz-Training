using System;

class AnnotationAnimal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class AnnotationDog : AnnotationAnimal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says Woof");
    }
}

class MethodOverriding
{
    public void Run()
    {
        AnnotationAnimal animal = new AnnotationDog();
        animal.MakeSound();
    }
}