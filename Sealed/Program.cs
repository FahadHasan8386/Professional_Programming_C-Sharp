using System.Runtime.CompilerServices;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal Sound");
    }
}

class Cow : Animal
{
    public sealed override void Sound()
    {
        Console.WriteLine("Dog Sound");
    }
}

class Goat : Cow
{

    //Can not override becouse sealed
    public override void Sound()
    {
        Console.WriteLine();
    }
}