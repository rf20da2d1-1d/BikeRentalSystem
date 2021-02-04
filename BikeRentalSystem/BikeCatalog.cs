using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRentalSystem
{
    public class BikeCatalog
    {
        private List<Bike> bikes;

        public BikeCatalog()
        {
            // initialisering
            bikes = new List<Bike>();
        }

        public void AddBike(Bike aBike)
        {
            // laver tjek
            if (bikes.Exists(b => b.ChassisNumber == aBike.ChassisNumber))
            {
                // kaster exception
                throw new ArgumentException($"Cykel med stelnummer {aBike.ChassisNumber} findes allerede");
                // resten udføres ikke

            }
            
            bikes.Add(aBike);
        }

        public void PrintBikeList()
        {
            foreach (Bike bike in bikes)
            {
                Console.WriteLine(bike);
            }

            Console.WriteLine($"Antal cykler = {bikes.Count} og tidspunktet er {DateTime.Now}");

        }
    }
}
