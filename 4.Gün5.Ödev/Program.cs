using System;
using System.Collections.Generic;

namespace _4.Gün5.Ödev
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, string> song = new MyDictionary<string, string>();
            song.Add("Velet", "Salına salına");
            song.Add("Uzi", "Makina");
            song.Add("Ramiz", "Rest");
            song.Add("Ados", "Yıkılır");
            song.Add("Ados", "Eylül");
            song.Add("Contra", "Islak Kum");

            Console.WriteLine("Şarkıcı :" + song.Count);

            for (int i = 0; i < song.Count; i++)
            {
                Console.WriteLine(song.Keys[i] + "-" + song.Value[i]);
            }
            Console.ReadLine();





        }
    }
}
