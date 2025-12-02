///In the name of Allah

string[] parts = Console.ReadLine().Split();

int a = int.Parse(parts[0]);
int b = int.Parse(parts[1]);
int n = int.Parse(parts[2]);

Console.Write(a / b);
Console.Write(".");

int rem =  a % b;

for(int i = 0; i < n;i++)
{
    rem *= 10;
    Console.Write(rem / b);
    rem = rem % b;
}


//string a = Console.ReadLine().Trim();
//string b = Console.ReadLine().Trim();

//for (int i = firstNum.Length; i > 0 ;i--)
//{
//    for(int j = secondNum.Length; j > 0;i--)
//    {
//        int m = int.Parse(firstNum[i]);
//        int nb = int.Parse(secondNum[j]);
//        int sum = m + nb; 
//    }
//    Console.Write(sum)
//}