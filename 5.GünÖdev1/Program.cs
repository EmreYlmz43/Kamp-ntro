using System;

namespace _5.GünÖdev1
{
    class Program
    {
        static void Main(string[] args)
        {

            //PersonManager manager = new PersonManager();
            //Customer customer = new Customer()
            //{
            //    Id = 1,
            //    FirstName = "Emre",
            //    LastName = "YILMAZ",
            //    Adress = "Balıkesir"
            //};
            //Student student = new Student()
            //{
            //    Id = 2,
            //    FirstName = "Bedirhan",
            //    LastName = "YILMAZ",
            //    Departmant = "Developer"
            //};
            //manager.Add(customer);
            //Console.WriteLine(customer.Adress);
            //manager.Add(student);
            //Console.WriteLine(student.Departmant);









            Console.ReadLine();
        }

    }
    interface IPerson
    {
       int Id { get; set; }
       string FirstName { get; set; }
       string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.Id);
            
        }
    }
}
    

