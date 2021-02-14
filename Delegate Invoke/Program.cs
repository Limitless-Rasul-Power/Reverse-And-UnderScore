using System;
using Delegate_Invoke.Entities;
using Delegate_Invoke.Static_Classes;

namespace Delegate_Invoke
{
    public delegate void Function(string text);
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.CursorVisible = false;
                Console.Write("Enter something: ");
                string text = Console.ReadLine();
                Console.Clear();
                Example example = new Example();                
                Function functionDelegate = example.PrintReverseText;
                functionDelegate += example.PrintUnderScoredText;
                Run.RunFunction(functionDelegate, text);
                Console.Write("\nPress \"Enter\" to continue...");
                Console.ReadLine();
                Console.Clear();
            }            
        }
    }
}