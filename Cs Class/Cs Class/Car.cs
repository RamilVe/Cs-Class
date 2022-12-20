using System;
using System.Collections.Generic;
using System.Text;

namespace Cs_Class
{
    internal class Car
    {
        //    Aşağıdaki parametrlərə sahib Car class yaradın
        //- Brand
        //- Model
        //- CurrentFuel - masinin hazirki benzin miqdari
        //- FuelFor1Km - masinin 1 km ucun xerclediyi benzin
        //- Millage - Masinin bu vaxtadək neçə km sürüldüyü
        //- Drive() - sürülmə metodu.Bu metod int parametr qeəbul edir (neçə km sürmək istədiyimiz)
        // Car obyekti yaradın drive metodunu işə saldıqda arqument olaraq neçə km sürmək istədyimizi daxil edirik və
        // əgər benzin kifayət edirsə maşının millage dəyəri və benzini azalır, benzin kifayət etmirsə console-da xəta mesajı yazılır

        public string Brand;
        public string Model;
        public int CurrentFuel;
        public int FuelFor1km;
        public int Millage;

        public void Drive(int distance)
        {
            var kmStr = Console.ReadLine();
            var km = Convert.ToInt32(kmStr);
            if (CurrentFuel >= km * FuelFor1km)
            {
                Millage += km;
            }
            else
            {
                Console.WriteLine("Benzin kifayet etmir");
            }
        }
    }
}
