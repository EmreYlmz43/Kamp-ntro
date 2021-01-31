using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// int,decimal,float,enum,boolen,value,types  =  Değer Tiplerdir....
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;
            //sayi2 = 100;

            //Console.WriteLine("Sayı1 :" + sayi1);

            ////arrays,class,interface....   = Referans Tipler....

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 100,200,300};

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("sayılar1[0] :" + sayilar1[0]);


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Emre";
            // ilk durumda person2 nin FirstName'i "Emre" olur...
            person2 = person1;
            person1.FirstName = "Bedirhan";
            // bu durumda Firstname == Bedirhan olur....

            //Console.WriteLine(person2.FirstName);

            // Farklı tipler birbirine atanamazlar...

            Costumer costumer = new Costumer();
            costumer.FirstName = "Bedooooo";
            costumer.CreditCartNumber = "1234567890";

            Employe employe = new Employe();
            employe.FirstName = "Veli";

            Person person3 = costumer;

            //Console.WriteLine(person3.FirstName);


            //Console.WriteLine(((Costumer)person3).CreditCartNumber);

            PersonMeneger personManager = new PersonMeneger();
            personManager.Add(costumer);


            
            



        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    // Aşağıda yazan Person kısmına == base class denır  
    class Costumer : Person
    {
        public string CreditCartNumber { get; set; }
    }

    class Employe : Person
    {
        public int EmployeNumber { get; set; }
    }
    class PersonMeneger
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
            Console.WriteLine(((Costumer)person).CreditCartNumber);

        }
        // yukarıdaki parantez içerisine "Employe" yazarsak sadece "Employe" çalışırız...
        // "Costumer" yazarsak sadece "Costumer" çalışırız....
        // ANCAK VE ANCAK "Person" yazarsak işte o zaman hem "Employe" hem de "Costumer" çalışırız..... 


    }
}
