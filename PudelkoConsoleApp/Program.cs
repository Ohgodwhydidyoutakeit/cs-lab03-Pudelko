using PudelkoLibrary;
using System;
using System.Collections.Generic;

namespace PudelkoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pudelko> pudelka = new List<Pudelko>();
            // pamietaj o rozmiarach geniuszu 
            pudelka.Add(new Pudelko(4200, 3123, null, UnitOfMeasure.milimeter));
            pudelka.Add(new Pudelko(45, 21, null, UnitOfMeasure.milimeter));
            pudelka.Add(new Pudelko(2.5, 9.321, 0.1, UnitOfMeasure.meter));
            pudelka.Add(
             new Pudelko(321, 654, 123, UnitOfMeasure.milimeter).Kompresuj()
         );
           
            pudelka.Add(new Pudelko(233.76, 152.44, 123.456, UnitOfMeasure.centimeter));
     
   
         

            pudelka.Sort();

            pudelka.ForEach(
                (pudelko) => {
                    Console.WriteLine(pudelko.ToString());
                }
            );
        }
    }
}