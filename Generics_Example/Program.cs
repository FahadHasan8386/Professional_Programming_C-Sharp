using Generics_Example;

class Program
{
    static void Main()
    {
        Holder<int> number = new Holder<int>();
        number.Data = 34;
        number.ShowData();

        Holder<string> text = new Holder<string>();
        text.Data = "Fahad Hasan";
        text.ShowData();
    }
}