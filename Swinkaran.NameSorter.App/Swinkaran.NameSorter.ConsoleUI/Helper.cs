using System;
using System.Collections.Generic;
using System.Text;

namespace Swinkaran.NameSorter.ConsoleUI
{
    public static class Helper
    {
        public static void WriteToConsole(string message = "")
        {
            if (message.Length > 0)
            {
                Console.WriteLine(message);
            }
        }
    }
}
