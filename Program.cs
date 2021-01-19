using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsProgram
{

    public class GenericClass<T> where T: struct
    {
        private List<T> list = new List<T>();    

        public void Add( T item)
        {
            list.Add(item);
        }

        public T GetItem(int index)
        {
            return list.ElementAt(index);
        }

        public List<T> GetSortedList()
        {
            list.Sort();
            return list;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> intClass = new GenericClass<int>();
            intClass.Add(4);
            intClass.Add(1);
            intClass.Add(6);
            Console.WriteLine("item 2: {0}", intClass.GetItem(2));
            List<int> sortedList = intClass.GetSortedList().OrderByDescending(x => x).ToList();
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
