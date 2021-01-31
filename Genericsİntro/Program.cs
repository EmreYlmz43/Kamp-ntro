using System;

namespace Genericsİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>() { "Emre", "Ahmet", "Mehmet" };
            //isimler.Add("Emre");

            Console.WriteLine(isimler);
        }
    }
}
