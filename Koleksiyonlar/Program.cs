﻿using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Emre", "Yılmaz", "Bedirhan", "Ahmet" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Emre")// bu şekildede yaılabilir.

            List<string> isimler2 = new List<string> { "Emre", "Yılmaz", "Bedirhan", "Ahmet" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Selim");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            // "List" ler oluşturduğumuz "array" lerde yeni bir ekleme yapacağımız zaman yeni bir array oluşturmadan ekleme yapmamızı sağlayacaktır.

        }

    }
}