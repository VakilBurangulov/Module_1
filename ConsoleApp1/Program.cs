using System;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Echo("Привет", 4);
        }

        static void Echo (string msg, int deep)
        {
            if ((msg.Length > 2) | (deep > 0))
            {
                Console.WriteLine(msg);
                Echo(msg.Remove(0, 2), deep - 1);
            }
        }
    }
}
