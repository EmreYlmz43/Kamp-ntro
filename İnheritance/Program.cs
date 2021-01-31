using System;

namespace İnheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance == Kallıtım,Miras  

            Person[] persons = new Person[2]
            {
                new Costumer{FirstName="Emre"},
                new Student{SchoolNo= "123548" } 
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName );
            }

            Console.ReadLine();

        }  
    }

    class Person
    {
        public int Id  { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Costumer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string SchoolNo { get; set; }
    }








}   
    
