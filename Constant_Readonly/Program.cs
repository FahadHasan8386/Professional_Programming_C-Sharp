using Constant_Readonly;

class Program
{
    static void Main(string[] args)
    {
        // const usage
        Console.WriteLine("Const Num: " + Example.Num);

        // static readonly usage
        Console.WriteLine("Readonly Name: " + Example2.Name);

        // static readonly with constructor
        Console.WriteLine("App Start Time: " + Config.AppStartTime);

        Console.ReadKey();
    }
}