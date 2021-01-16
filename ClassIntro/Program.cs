using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmen = "Emre Yılmaz";
            kurs1.İzlenmeOranı = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.İzlenmeOranı = 62;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.İzlenmeOranı = 60;


            Kurs kurs4 = new Kurs();
            kurs4.KursAdı = "C++";
            kurs4.Egitmen = "Veli Deli";
            kurs4.İzlenmeOranı = 40;


            //Console.WriteLine(kurs1.KursAdı+":"+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
                Console.WriteLine(kurs.KursAdı+":"+kurs.Egitmen+":"+kurs.İzlenmeOranı);
            {

            }

        }
    }
    class Kurs

    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOranı { get; set; }
    }
}
