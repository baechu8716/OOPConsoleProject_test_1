using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Extension
    {
        
    }

    public static class Util
    {
        public static void PressAnyKey(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("계속하려면 아무키나 누르시오...");
            Console.ReadKey(true);
        }
    }
}
