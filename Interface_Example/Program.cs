using Interface_Example;

class Program
{
    static void Main()
    {
        Bicycle bicycle = new Bicycle();
        bicycle.SpeedUp(5);
        bicycle.SpeedUp(10);
        bicycle.SpeedUp(5);

        Console.WriteLine("Bicycle present state : ");
        bicycle.CheckSpeed();


        Bike bike = new Bike();
        bike.SpeedUp(15);

        Console.WriteLine("Bike present state : ");
        bike.CheckSpeed();
    }
}