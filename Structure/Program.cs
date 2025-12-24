using Structure;

class Program
{
    static void Main()
    {
        Student s1 = new Student();

        s1.Roll = 101;
        s1.Name = "Fahad";
        s1.Cgpa = 3.75;

        Console.WriteLine(s1.Roll);
        Console.WriteLine(s1.Name);
        Console.WriteLine(s1.Cgpa);


        Rectangle r1 = new Rectangle();
         
        r1.Length = 10;
        r1.Width = 20;
        Console.WriteLine($"Total Area is : {r1.Area()}");


        //Call with Constructor
        Point p1 = new Point(10 , 222);
        Console.WriteLine("X Axis is : " + p1.X +  " , " + "Y Axis is : " + p1.Y);


        Number n1;
        n1.Value = 1;

        Number n2 = n1; //this is value type not reference
        n2.Value = 2;

        Console.WriteLine(n1.Value);
        Console.WriteLine(n2.Value);
    }
}
