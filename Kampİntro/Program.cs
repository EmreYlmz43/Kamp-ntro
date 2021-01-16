using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety -tip güvenliği
            // metinlerde tek tırnak koymuyoruz.
            // noktalı virgül her satır bitince konulur.
            //string den sonra yazılan değer tutucudur. alias

            string kategoriEtiketi = "Kategori";
            int ögrenciSayısı = 32000;
            double faizOranı=1.45;
            bool sistemeGirisYapmısmı = false;

            double dolarDun = 7.50;
            double dolarBugun = 7.85;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Artış Oku");

            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("eşittir");
                
            }
            break

            



            }




        }
        }












            if (sistemeGirisYapmısmı== false)
            {
                Console.WriteLine("Kullanıcı ayarı butonu");
                
            }

            else
            {
                Console.WriteLine("Girirş yapma butonu");
            }
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
