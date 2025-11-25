// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var x = 6;
x--;///Decrement
x++;///Increment

int m = x += 5;
Console.WriteLine(m);

var score = 0b1110;

Console.WriteLine(score);
///Ultai  dibe
var t = ~score;

Console.WriteLine(Convert.ToString(t , toBase: 2));


int score1 = 0b_10100;///Binary Value dissi Output decimal Value
Console.WriteLine(score1);

int p = 0b_100;
int q = 0b_111; 

int w = q & p;
Console.WriteLine(w);//0b_101

int r = p | q;
Console.WriteLine(r); //0b111