using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Names = new List<string>(); 
            Names.Add("Joe"); 
            Names.Add("Bob"); 
            Names.Add("Jack"); 
            Names.Add("Steve");// Iterate through the list.
            foreach (var name in Names){Console.WriteLine(name);}
            Console.WriteLine("--------------------");
            var Numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach(var num in Numbers){if(num%2 == 0){// print out even
               Console.WriteLine(num);
                }
            }Console.ReadLine();
        }
    }
}
