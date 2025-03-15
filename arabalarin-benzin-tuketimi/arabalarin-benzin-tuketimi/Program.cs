using System;
using System.Collections.Generic;

class Araba
{
    public string Marka { get; set; }
    public double BenzinTuketimi { get; set; } // 100 km'de litre
}

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>
        {
            new Araba { Marka = "Toyota", BenzinTuketimi = 6.5 },
            new Araba { Marka = "BMW", BenzinTuketimi = 8.2 },
            new Araba { Marka = "Renault", BenzinTuketimi = 5.9 },
            new Araba { Marka = "Mercedes", BenzinTuketimi = 7.4 }
        };

        double toplamTuketim = 0;

        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Marka: {araba.Marka}, 100 km'de Benzin Tüketimi: {araba.BenzinTuketimi} litre");
            toplamTuketim += araba.BenzinTuketimi;
        }

        Console.WriteLine("\nToplam Benzin Tüketimi: " + toplamTuketim + " litre/100 km");
    }
}
