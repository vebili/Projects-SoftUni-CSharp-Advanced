using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    if (input == "END")
                    {
                        break;
                    }

                    if (input.Contains("Create"))
                    {
                        List<string> items = input
                            .Split()
                            .Skip(1)
                            .ToList();
                        listyIterator = new ListyIterator<string>(items);
                    }
                    else if (input == "Print")
                    {
                        listyIterator.Print();
                    }
                    else if (input == "HasNext")
                    {
                        Console.WriteLine(listyIterator.HasNext());

                    }
                    else if (input == "Move")
                    {
                        Console.WriteLine(listyIterator.Move());
                    }
                    else if (input == "PrintAll")
                    {
                        foreach (var item in listyIterator)
                        {
                            Console.Write(item + " ");
                        }

                        Console.WriteLine();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}