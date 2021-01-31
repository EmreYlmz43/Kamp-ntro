using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // constroctor yapıcı blok demektir...

            //Costumer costumer1 = new Costumer { Id = 1, FirstName = "Emre", LastName = "YILMAZ", City = "Kütahya" };

            Costumer costumer2 = new Costumer (2, "Bedirhan", "Yılmaz", "İstanbul");
            // costumer parametrelerini illaki bu şekilde kullanacaksak o zaman Aşağıdaki gibi Costumer  constroctor'üne
            //parametreleri yazmamız gerekiyor "int Id, string FirstName, string LastName, string City" şeklinde....
            // Ancak ve Ancak bu sefer en üstteki costumer1' i  şeklini kullanamayız....
            // Eğer iki şekildede kullanmak istiyorsak o zaman bir ""ctor"" daha oluşturmamız gerekecek.

            Console.WriteLine(costumer2.FirstName);

            Method(5, "Engin", "Demiroğ", "Diyarbakır");

        }
        static void Method (int Id, string FirstName, string LastName, string City)
        {

        }
    }
    class Costumer
    {
        // default Constroctor.==  Parametresi olmayn ctor'lara denilir.
        public Costumer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
