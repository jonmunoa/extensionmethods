using System;

namespace extensionmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hoy es {DateTime.Now}");
            Console.WriteLine($"Mañana es {DateTime.Now.Tomorrow()}");
            Console.ReadLine();
        }
    }
}
