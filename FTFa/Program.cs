using System;
using System.Collections.Generic;
using System.Linq;

namespace FTFa
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            Phonebook phonebook = new Phonebook();

            while(isRunning)
            {
                Console.WriteLine("Use either: 'add name phonenumber' or 'list' or 'exit'");

                List<string> input = Console.ReadLine().Split(' ').ToList();

                if (input.Count == 0)
                {
                    Console.WriteLine($"No input");
                    continue;
                }

                string command = input[0];
                switch (command)
                {
                    case "add":
                        if (input.Count != 3)
                        {
                            Console.WriteLine($"Command did not have 2 arguments");
                            continue;
                        }
                        var name = input[1];
                        var number = input[2];
                        bool isAdded = phonebook.AddEntry(number, name);
                        if(isAdded)
                        {
                            Console.WriteLine($"Entry added to phonebook");
                        }
                        else
                        {
                            Console.WriteLine($"Could not add entry to phonebook");
                        }
                        break;
                    case "list":
                        foreach (KeyValuePair<string, string> entry in phonebook.GetEntries())
                        {
                            Console.WriteLine($"{entry.Value}, {entry.Key}");
                        }                        
                        break;
                    case "exit":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid command");
                        break;

                }
            }
        }
    }
}
