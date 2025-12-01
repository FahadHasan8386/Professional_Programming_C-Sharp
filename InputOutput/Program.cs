// Input from the console
using System.IO;

string line = Console.ReadLine();

// Split the line by spaces into an array of strings
string[] parts = line.Split();

// Convert the first value to int
int x = int.Parse(parts[0].Trim());

// Convert the second value to int
int y = int.Parse(parts[1].Trim());

// Convert the third value to double
double z = double.Parse(parts[2].Trim());

//Console.ReadLine();
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

// Unlimited Line Input Until Empty Line
while (true)
{
    string sentence = Console.ReadLine();

    // string empty
    if (sentence == string.Empty)
    {
        break;
    }
    else
    {
        Console.WriteLine("You Entered : " + sentence);
    }
}

Console.WriteLine($"value of x : {x}, value of y : {y} ,value of z : {z,10}");