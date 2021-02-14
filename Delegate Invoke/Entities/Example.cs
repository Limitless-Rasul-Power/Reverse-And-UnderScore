using System;
using Delegate_Invoke.Static_Classes;

namespace Delegate_Invoke.Entities
{
    public class Example
    {
        public void PrintUnderScoredText(string text)
        {
            Console.Write($"Under Scored Version of {text} is ");
            ConsoleColorSetting.SetColor(ConsoleColor.Yellow);
            int originalSizePlusUnderScores = (text.Length * 2) - 1;
            for (int i = 0, j = 0; i < originalSizePlusUnderScores; i++)
            {
                if (i % 2 != 0)
                { Console.Write('_'); j++; }

                else
                    Console.Write(text[i - j]);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
        public void PrintReverseText(string text)
        {
            Console.Write($"Reversed Version of {text} is ");
            ConsoleColorSetting.SetColor(ConsoleColor.Red);
            char[] reversedText = text.ToCharArray();
            Array.Reverse(reversedText);
            Console.WriteLine(reversedText);
            Console.ResetColor();
        }
    }

}
