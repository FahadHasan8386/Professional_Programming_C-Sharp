using dynamic;

dynamic person = new { Name = "Fahad", Age = 44 };

Console.WriteLine(person.Name);

Console.WriteLine(person.Name2);


dynamic product = new Product { Brand = "Camera", Price = 100 };

//compile time e kichu hobe nh ,Run time e error dibe shob 
Console.WriteLine(product.Rating);
product.CalculateDiscountPrice(); 


//limited case e use hoi ,runtime ,r c# Compile type 

//like this use case 

object MyMethod(int x)
{

}
//amra just jni obeject er vitor akta name property ase 
dynamic myMethod = MyMethod(4);
string name = myMethod.Name;