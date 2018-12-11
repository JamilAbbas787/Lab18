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
            var test = new LinkedList<int>();
            //foreach (var number in numbers)
            //{
            //    test.AddLast(number);
            //}
            //LinkedList.PrintReverse(test);
            FindDistinctWithDictionary(numbers);
            FindDistinctWithArray(numbers);


            Console.WriteLine("Big-O Estimate: O(N2) for both List and Array algorithm.");
            Console.ReadKey();

        }

        public static Dictionary<int,int> FindDistinctWithDictionary(int[] oldArray)
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

            Console.WriteLine("Using a list:  ");
            foreach (var number in newDictionaryDistinct)
            {
                Console.WriteLine($"[{number.Key}]: {number.Value}");
            }

            Console.ReadKey();

            return newDictionaryDistinct;
        }

        public static void FindDistinctWithArray(int[] oldArray)
        {

            Array.Sort(oldArray);
            var distinctArray = oldArray.Distinct().ToArray();
            int arraySize = distinctArray.Length;
            int[,] newDistinctArray = new int[arraySize, arraySize] ;

            Console.WriteLine("Using a an array:  ");
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


                newDistinctArray[i,0] = distinctArray[i];
                newDistinctArray[i, 1] = k;
                Console.WriteLine($"[{distinctArray[i]}]: {k}");

            }

        }

    }

   

    public static class LinkedList
    {
        public static bool RemoveAt<t> (this LinkedList<t> list, int index)
        {
            LinkedListNode<t> currentNode = list.First;
            if (list.ElementAt(index) != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == index)
                    {
                        list.Remove(currentNode);
                    }
                    currentNode = currentNode.Next;
                }
                                
            }
            return false;
        }


        public static void PrintReverse<t>(this LinkedList<t> list)
        {
            LinkedList<t> listInReverse = new LinkedList<t>();
            foreach (var node in list)
            {
                listInReverse.AddFirst(node);
            }
            foreach (var node in listInReverse)
            {
                Console.WriteLine($"{node}");
            }
        }

        public static bool InsertAt<t> (this LinkedList<t> list , int index, t o)
        {
            LinkedListNode<t> currentNode = list.First;
 
            if (list.Count >= index)
            {
                for (int i = 0; i < list.Count; i++)
                {

                    if (i == index - 1 )
                    {
                        list.AddAfter(currentNode , o);
                    }

                }
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}
