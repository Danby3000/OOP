using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, int> numberNames = new Dictionary<string, int>();
            numberNames.Add("Joe", 22);
            numberNames.Add("Jack", 23);
            numberNames.Add("Tom", 24);

            foreach(KeyValuePair<string, int> pair in numberNames)
            {
                Console.WriteLine("Key:{0}, Value:{1}", pair.Key, pair.Value);
            }

            IDictionary<string, string> objectTypes = new Dictionary<string, string>();

            objectTypes.Add("Fruits", "Apple, Banana, Orange, Grapes, Pineapple");
            objectTypes.Add("Vegetables", "Sprouts, Carrots, Caluiflower, Peas");
            objectTypes.Add("Furnitures", "Table, Chair, Sofa, Stool");
            objectTypes.Add("Hardware", "Hammer, Screwdriver, Nails, Screws");

            foreach(KeyValuePair<string, string> pair in objectTypes)
            {
                Console.WriteLine("Key : {0}, Value : {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("--------------");

            string result;
            if (objectTypes.TryGetValue("Fruits", out result))
            {
                Console.WriteLine(result);
                result = result + ", Watermelon";
                objectTypes["Fruits"] = result;
            }

            if (objectTypes.ContainsKey("Vegetables"))
            {
                objectTypes.Remove("Vegetables");
            }

            foreach (KeyValuePair<string, string> pair in objectTypes)
            {
                Console.WriteLine("Key : {0}, Value : {1}", pair.Key, pair.Value);
            }



            Console.ReadLine();


        }
    }
}
