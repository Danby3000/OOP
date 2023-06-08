using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList

{
    public class Person
    {
        public Person (string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            this.age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var Numbers = new List<int>(); 
            Random r = new Random(); 
            for (int x = 0; x < 10; x++)
            {
                int num = r.Next(0,100);
                Numbers.Add(num);
            }

            foreach (var number in Numbers) 
            { 
                Console.Write(number + " ");
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Average of random numbers is: {0}", Numbers.Average());
            Numbers.Insert(10, 0);
            var index = Numbers.IndexOf(0);
            Console.WriteLine("index of pos 0 is : {0}", index);

            var count = Numbers.Count();
            Console.WriteLine("count is : {0}", count);
            Console.WriteLine("-------------");

            Console.WriteLine("Collections using List of Objects");
            var Student = new List<Person>
            {
                new Person("Joe", "Bloggs", 23),
                new Person("Steve", "May", 22),
                new Person("Jack", "Jones", 24),
                new Person("Tom", "Jones", 23)
            };

            Console.WriteLine("Number of objects is : {0}", Student.Count());
            foreach(var student in Student)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
                Console.WriteLine(student.age);
                Console.WriteLine("-------------");
            }
          

            var objs = new List<object>();
            objs.Add(2.5d);
            objs.Add(2.0d);
            objs.Add(3);
            objs.Add(2);
            objs.Add("Hello ");
            objs.Add("World");

            var doubles = new List<double>();
            var ints = new List<int>();
            var strs = new List<string>();

            foreach(var obj in objs)
            {
                if(obj is double)
                {
                    Console.WriteLine(obj.GetType().ToString());
                    doubles.Add((double)obj);
                }

                if(obj is int)
                {
                    Console.WriteLine(obj.GetType().ToString());
                    ints.Add(((int)obj));
                }

                if (obj is string)
                {
                    Console.WriteLine(obj.GetType().ToString());
                    strs.Add(obj.ToString());
                }
            }

            int intSum = 0;
            foreach (var i in ints)
            {
                intSum = intSum + i;
            }
            Console.WriteLine("sum of ints : {0}", intSum.ToString());

            double doubleSum = 0;
            foreach(var d in doubles)
            {
                doubleSum = doubleSum + d;
            }
            Console.WriteLine("sum of doubles : {0}", doubleSum.ToString());

            String strSum = "";
            foreach (var s in strs)
            {
                strSum = strSum + s;
            }
            Console.WriteLine("sum of ints : {0}", strSum);
            Console.ReadLine();
        }
    }
}
