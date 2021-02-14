using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Invoke.Static_Classes
{
    public static class ConsoleColorSetting
    {
        public static void SetColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
}
