using System;

namespace İnterface1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------URUNLERİ TEK VERİ TABANINA EKLEME VE SİLME---------------");
            ProductManager productManager = new ProductManager();
            productManager.Add(new SqlDataBase());
            productManager.Delete(new OracleDataBase());

            Console.WriteLine("--------------URUNLERİ İKİ VERİ TABANINA EKLEME VE GÜNCELLEME ---------------");

            IProduct[] products = new IProduct[2]
            {
                new SqlDataBase(),
                new OracleDataBase()
            };

            foreach (var product in products)
            {
                product.Add();
            }
            foreach (var product in products)
            {
                product.Update();
            }

            Console.WriteLine("--------------YENİ VERİ TABANI EKLEME ---------------");

            IProduct[] products1 = new IProduct[3]
            {
                new SqlDataBase(),
                new OracleDataBase(),
                new MySqlDataBase()
            };

            foreach (var product in products1)
            {
                product.Delete();
            }

        }
    }
    interface IProduct
    {
        void Add();
        void Update();
        void Delete();
    }

    class MySqlDataBase : IProduct
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql Updated");
        }
    }

    class SqlDataBase : IProduct
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }

    class OracleDataBase : IProduct
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }

       


        }
    class ProductManager
    {
        public void Add(IProduct product)
        {
            product.Add();
        }
        public void Delete (IProduct product)
        {
            product.Delete();
        }

    }
}
