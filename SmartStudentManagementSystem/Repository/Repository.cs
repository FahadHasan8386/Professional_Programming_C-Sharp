using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStudentManagementSystem.Repository
{
    public class Repository <T>
    {
        private List<T> items = new List<T>();

        public void Add (T item)
        {
            items.Add(item);
        }

        public List<T>  GetAll()
        {
            return items;
        }

        public void PrintAll<TData>(List<TData> data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
