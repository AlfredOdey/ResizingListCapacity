using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizingListCapacity
{
    internal class Program
    {
        /*
        Question 2: Resizing a List Capacity
        Create a list of integers and set an
        initial capacity of 100.
        Add 10 integers to the list.
        Print the capacity and count of the list.
        */
        static void Main(string[] args)
        {
            List<int> listOfIntegers = new List<int>(100);

            // Using a For Loop to add 10 integers to the list.	
            for (int x = 0; x < 10; x++)
            {
                listOfIntegers.Add(x);
            }

            Console.WriteLine($"Capacity of list: {listOfIntegers.Capacity}");

            Console.WriteLine($"Count of list: {listOfIntegers.Count}");
        }
    }
}
