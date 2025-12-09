using OOP;

class Program
{
    static void Main()
    {
        Brand b = new Brand();
        b.Name = "Tesla";
        b.Country = "USA";

        ElectricCar ec = new ElectricCar();
        ec.Model = "1XXX00";          //Inherited From Car
        ec.Year = 2022;               //Inherited From Car
        ec.CarBrand = b;              //Car er Brand b ,Has e Relationship
        ec.BattaryCapacity = 10;

        ec.ShowCarInfo();
        ec.Charge();
    }
}