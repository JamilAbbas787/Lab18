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
