using System;
using System.Collections.Generic;

namespace SortedDictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a sorted dictionary
            SortedDictionary<int, string> names = new SortedDictionary<int, string>();

            //add elements
            names.Add(2, "Mishu");
            names.Add(4, "Rayhan");
            names.Add(3, "Mithila");
            names.Add(1, "Shihab");
        }
    }
}
