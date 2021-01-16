using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int caseSwitch = 3;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Casse 1");
                    break;
                case 2:
                    Console.WriteLine("Casse 2");
                    break;
                case 3:
                    Console.WriteLine("Casse 3");
                    break;
                default:
                    Console.WriteLine("Varsayılan Sayı");
                    break;
            }
        }
    }
}
