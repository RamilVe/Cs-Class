using System;
using System.Collections.Generic;
using System.Text;

namespace Cs_Class
{
    internal class Notebook
    {
        //Notebook class yaradın ve aşağıdakı xüsusiyyətləri olsun 
        //- Name - məhsulun adını ifadə edən xüsusiyyət 
        //- BrandName - Notebook -un brand adı 
        //- Price - Notebook -un qiyməti.

        public string Name;
        public string BrandName;
        public double Price;


        //static string TotalPrice(Notebook[] notebook)
        //{
        //    Console.WriteLine("minPrice: ");
        //    var minPriceStr = Console.ReadLine();
        //    var minPrice = Convert.ToInt32(minPriceStr);

        //    Console.WriteLine("maxPrice: ");
        //    var maxPriceStr = Console.ReadLine();
        //    var maxPrice = Convert.ToInt32(maxPriceStr);


        //    for (int i = 0; i < notebook.Length; i++)
        //    {
        //        if (notebook[i].Price >= minPrice && notebook[i].Price <= maxPrice)
        //        {
        //            Console.WriteLine($"{notebook[i].Name}");
        //        }
        //    }
        //    return notebook.Name;
        }
    }
}
