using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            while (true)
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
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (input == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                    
                }
                else if (input == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }

            }
        }
    }
}