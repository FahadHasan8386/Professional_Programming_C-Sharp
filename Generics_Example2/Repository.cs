using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Example2
{
    public class Repository<T> where T : BaseEntity
    {
        public void Save(T data)
        {
            Console.WriteLine($"{typeof(T).Name } saved with Id{data.Id} at {data.CreatedAt}");
        }
        public void Delete(T data)
        {
            Console.WriteLine($"{typeof(T).Name} with Id {data.Id} deleted");
        }

        //Generics Method
        public void PrintInfo<K> (K info)
        {
            Console.WriteLine("Extra Info : " + info);
        }
    }
}
