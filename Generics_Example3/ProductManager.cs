using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Example3
{
    public class ProductManager<T> where T : Product
    {
        private List<T> _product = new List<T>();

        public void AddProduct(T item)
        {
            _product.Add(item);
            Console.WriteLine($"{item.Name} Added Successfully!");
        }

        public List<T> FilterProduct(Func<T , bool> condition)
        {
            return _product.FindAll(new Predicate<T>(condition));
        }
    }
}
