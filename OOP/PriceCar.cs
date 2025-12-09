using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class PriceCar
    {
        public int Price;
        public int Vat;

        //Constructor with 2 Parameter
        public PriceCar(int price, int vat)
        {
            this.Price = price;
            this.Vat = vat;

        }
        public int TotalPrice => Price + Vat;

        public void ShowTotalPrice()
        {
            Console.WriteLine("Total Price : " + TotalPrice);
        }
    }
}
