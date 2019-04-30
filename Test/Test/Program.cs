using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new dictionary of strings, with string keys.
            //
            Dictionary<int, string[] > Adress =
                new Dictionary<int, string [] >();

            // Add some elements to the dictionary. There are no 
            // duplicate keys, but some of the values are duplicates.
            Adress.Add(1, new string[] { "Name", "Nachname", });
            Adress.Add(2, new string[] { "Test1", "Test2", });
            Adress.Add(3, new string[] { "Test4", "Test3", });

            Adress.Clear();

            foreach (var item in Adress[3])
            {
                Console.WriteLine(item);
            }


            Console.Read();
        }
    }
}
