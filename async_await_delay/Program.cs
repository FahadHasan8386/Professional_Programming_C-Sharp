class Program
{
    static async Task Main()
    {
        Console.WriteLine("Program Started");

        await DoWorkAsync();

        Console.WriteLine("Program Ended");
    }

    static  async Task DoWorkAsync()
    {
        Console.WriteLine("Work Started");

        await Task.Delay(3000);

        Console.WriteLine("Word Ended");
    }
}