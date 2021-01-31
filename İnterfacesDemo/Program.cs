using System;

namespace İnterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- ÇALIŞANLARI ÇALIŞTIR-------------"+ "\n");
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }
            Console.WriteLine("\n" + "------- ÇALIŞANLARA YEMEK YEDİR-------------" + "\n");
            IEat[] eat = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var eats in eat )
            {
                eats.Eat();
            }


        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yönetici Yemek Yedi");
        }

        public void GetSalary()
        {
            Console.WriteLine("Yönetici Maaş Aldı");
        }

        public void Work()
        {
            Console.WriteLine("Yönetici Bugün Çalıştı");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Çalışan Yemek Yedi");
        }

        public void GetSalary()
        {
            Console.WriteLine("Çalışan Maaş Aldı");
        }

        public void Work()
        {
            Console.WriteLine("Çalışan Bügün Çalıştı");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Bugün Çalıştı");
        }
    }
}
