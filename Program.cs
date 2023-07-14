using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            // Add elements to the ArrayList
            arrayList.Add("apple");
            arrayList.Add("banana");
            arrayList.Add("cherry");
            arrayList.Add("date");
            arrayList.Add("elderberry");

            // Print the total number of elements in the ArrayList
            Console.WriteLine("Total number of elements: " + arrayList.Count);

            // Check if the ArrayList contains the element "date"
            bool containsDate = arrayList.Contains("date");
            Console.WriteLine("ArrayList contains 'date': " + containsDate);

            // Insert the element "fig" at the second position in the ArrayList
            arrayList.Insert(1, "fig");

            // Remove the element "banana" from the ArrayList
            arrayList.Remove("banana");

            // Print all the elements in the ArrayList using a loop
            Console.WriteLine("Elements in the ArrayList:");
            foreach (object element in arrayList)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
