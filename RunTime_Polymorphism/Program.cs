class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Aniaml makes a sound");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("Dog  makes a sound");
    }
}


class Program
{
    static void Main()
    {
        Animal a = new Dog();
        a.Sound();
    }
}
