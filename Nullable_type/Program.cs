
int? x = null;
int? y = null;

//x er null value thakle 
//x.Value;
//x.HasValue
if (x.HasValue)
    Console.WriteLine(x.Value);
else
    Console.WriteLine("x is null");



x ??= 8;//if x == null , x = 8, else x keeps old value