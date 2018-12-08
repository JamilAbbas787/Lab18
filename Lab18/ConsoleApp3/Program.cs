using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1,2,3,2,2,4,5,5,7,8,4,4,1,0,10};
            var numbersDistinct = FindDistinct(numbers);
            foreach (var number in numbersDistinct)
            {
                Console.WriteLine($"[{number.Key}]: {number.Value}");
            }
                      
            Console.ReadKey();

        }

        public static Dictionary<int,int> FindDistinct(int[] oldArray)
        {
            var newDictionaryDistinct = new Dictionary<int,int>();
            
            Array.Sort(oldArray);
            var distinctArray = oldArray.Distinct().ToArray();

            for (int i = 0; i < distinctArray.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < oldArray.Length; j++)
                {
                    if (oldArray[j] == distinctArray[i])
                    {
                        k++;
                    }                    
                   
                }               
                        
                newDictionaryDistinct.Add(distinctArray[i], k);
                
               
            }

            return newDictionaryDistinct;
        }

    }

   

    public static class LinkedList
    {
        public static bool RemoveAt<t> (this LinkedList<t> list, int index)
        {
            if (list.ElementAt(index) != null)
            {
                list.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PrintReverse<t>(this LinkedList<t> list)
        {
            list.PrintReverse();
        }

        public static bool InsertAt<t> (this LinkedList<t> list , int index, Object o)
        {
            if (list.Count >= index)
            {
                list.InsertAt(index, o);
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}
