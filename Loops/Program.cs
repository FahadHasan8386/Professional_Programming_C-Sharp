// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for(int i  = 0;i < 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine();


var x = 5;
while(x > 0)
{
    Console.WriteLine(x);
    x--;
}
Console.WriteLine();
do
{

}while(x > 0);


int[] ages = [22, 34, 42];

var sumofAges = 0;

foreach(int age in ages)
{
    sumofAges += age;
}
Console.WriteLine(sumofAges);