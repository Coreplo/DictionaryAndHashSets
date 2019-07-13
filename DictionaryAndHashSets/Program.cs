using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAndHashSets
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dictionary");
            /*
             very similar to SortedList
             it is a collection of unique pairs key/value
             Generic Dictionary<K,V> requires all keys and values are respectively of the same type K and V
             */

            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("uno",1);
            d.Add("uan", 1);
            d.Add("one", 1);
            Console.Write("Dictionary d: ");
            foreach(string s in d.Keys)
            {
                Console.Write(" "+ s);
            }
            Console.WriteLine();
            Console.WriteLine("Count: " + d.Count);


            Console.WriteLine("HashSets");
            /*
             list of unique falues where duplicates are not allowed
             Generic HashSet<T>  are high performance: fast add, lookup and remove but they only have values and cannot be sorted
             some Props:
             Count
             some Methods
             Add(T t): Adds an element
             IsSubsetOf(Icollection c): true if hashSet is a subset of a given collection c
             Remove(T t) Removes the value (t) from the hash set.
             Clear() Removes all the elements form the hash set.
             Contains(T t) Returns true when a value (t) is present in the hash set.
             ToString() Creates a string from the hash set.
             IsSupersetOf(ICollection c) Returns true if the hash set is a superset of the specified collection.
             UnionWith(ICollection c) Applies set union operation on the hash set and the specified collection (c).
             IntersectWith(ICollection c) Applies set intersection operation on the hash set and the specified collection (c).
             ExceptWith(ICollection c) Applies set difference operation on the hash set and the specified collection (c).

             */
            HashSet<int> hs = new HashSet<int>();

            hs.Add(5);
            hs.Add(51);
            hs.Add(20);
            hs.Add(15);
            hs.Add(30);

            Console.Write("\nHashSet: ");
            foreach (int i in hs)
                Console.Write(i + " "); 
            Console.Write("\nCount: " + hs.Count);  

            HashSet<int> hs2 = new HashSet<int>();
            hs2.Add(15);
            hs2.Add(20);
            Console.Write("\n{15, 20} is a subset of hs1: " + hs2.IsSubsetOf(hs));  


            Console.ReadKey();


        }
    }
}
