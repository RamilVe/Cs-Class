using System;
using System.IO;

namespace Cs_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook
            {
                Name = "HP",
                Price = 2400
            };

            Notebook notebook2 = new Notebook
            {
                Name = "Asus",
                Price = 1500
            };

            Notebook notebook3 = new Notebook
            {
                Name = "Acer",
                Price = 500
            };

            Notebook[] notebook = { notebook1, notebook2, notebook3 };
            Price(ref notebook);
            Console.WriteLine(notebook);
        }

        //1-ci tapşırıqda yaratdığınız Notebook classindan bir notebook array-i duzeldin
        //Layihə işə düşdükdə bizdən minPrice dəyəri daxil etməyimizi və daha sonra maxPrice dəyəri daxil etməyimizi istəsin.
        //Daha sonra yaratmış olduğumuz array-də minPrice və maxPrice aralığında qiyməti olan notebookların adlarını console-a yazdırsız

        static void Price(ref Notebook[] notebook)
        {
            Console.WriteLine("minPrice: ");
            var minPriceStr = Console.ReadLine();
            var minPrice = Convert.ToInt32(minPriceStr);

            Console.WriteLine("maxPrice: ");
            var maxPriceStr = Console.ReadLine();
            var maxPrice = Convert.ToInt32(maxPriceStr);


            for (int i = 0; i < notebook.Length; i++)
            {
                if (notebook[i].Price > minPrice && notebook[i].Price < maxPrice)
                {
                    Console.WriteLine($"{notebook[i].Name}");
                }
            }
        }
    }
}
