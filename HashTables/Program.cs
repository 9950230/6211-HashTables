using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> names = new Dictionary<int, string>();
            String[] namesArray = new string[3];

            bool exit = false;
            while (!exit)
            {

                Console.WriteLine("Choose your option:");
                Console.WriteLine("1. Insert 3 names into a Dictionary.");
                Console.WriteLine("2. Check if your Dictionary contains a value."); 
                Console.WriteLine("3. Copy the Dictionary to array and display it from the array.");
                Console.WriteLine("4. exit");
                int option = 0;
                try
                { 
                    option = Int32.Parse( Console.ReadLine() );
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\n{0}\n", e.Message);
                }

                switch (option)
                {
                    case 1:

                        Console.WriteLine();

                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("Enter a name: ");
                            names.Add(i, Console.ReadLine());
                        }

                        Console.WriteLine();

                        foreach (KeyValuePair<int, string> x in names)
                        {
                            Console.WriteLine(x.Value);
                        }

                        Console.WriteLine();
                        
                        break;

                    case 2:
                        
                        Console.Write("\nEnter a name to check: ");

                        string nameToCheck = Console.ReadLine();

                        if (names.ContainsValue(nameToCheck))
                        {
                            Console.WriteLine("\nDictionary does contain: {0}\n", nameToCheck);
                        }
                        else
                        {
                            Console.WriteLine("\nDictionary does NOT contain: {0}\n", nameToCheck);
                        }
                        
                        break;
                        
                    case 3:

                        Console.WriteLine();

                        namesArray = names.Values.ToArray();
                        foreach (string name in namesArray)
                        {
                            Console.WriteLine(name);                            
                        }

                        Console.WriteLine();
                        break;

                    case 4:

                        exit = true;
                        break;
                                
                }

            }

        }
    }
}
