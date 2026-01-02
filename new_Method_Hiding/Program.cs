
class Animal()
{
    public void Sound()
    {
        Console.WriteLine("Animal Sound ");
    }
}

class Cat : Animal
{
    public new void Sound()
    {
        Console.WriteLine("Cat Meows");
    }
}



class Program
{
    static void Main()
    {
        Animal a = new Cat();
        a.Sound();   // Animal sound ❌

        Cat c = new Cat();
        c.Sound();   // Cat meows ✅

    }
}