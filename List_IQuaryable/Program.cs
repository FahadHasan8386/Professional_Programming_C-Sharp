class Program
{
    static void Main()
    {
        //Save on ram (Memory)
        List<int> numbers = new List<int> { 1 , 2, 3 };

        //IEnumrable
        IEnumerable<int> EvenNumberable = numbers.Where(n => n % 2 == 0);

        //IQueryable
        IQueryable<int> evenNumberQuery =numbers.AsQueryable().Where(n => n % 2 == 0);

        numbers.Add(1);

        Console.WriteLine("IEnumrable Result");
        foreach(var n in EvenNumberable)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("IQueryrable Result");
        foreach (var n in evenNumberQuery)
        {
            Console.WriteLine(n);
        }

    }
}