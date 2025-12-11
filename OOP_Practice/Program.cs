
using OOP_Practice;

class Program
{
    static void Main()
    {
        Wallet w = new Wallet(400);
        w.AddBalance(200);

        Console.WriteLine(w.GetBalance());
    }
}