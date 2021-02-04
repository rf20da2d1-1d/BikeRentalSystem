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

        public Bike SearchBike(String chassisNumber) // måtte tilpasse typen til propertien dvs int -> string
        {
            return bikes.Find(b => b.ChassisNumber == chassisNumber);
        }

        public Bike SearchBikeAlternativt(String chassisNumber) 
        {
            if (bikes.Exists(b => b.ChassisNumber == chassisNumber))
            {
                throw new KeyNotFoundException($"Cykel med stelnummer {chassisNumber} findes ikke");
            }

            return bikes.Find(b => b.ChassisNumber == chassisNumber);
        }

        public void DeleteBike(String chasisNumber)
        {
            Bike bikeToDelete = SearchBikeAlternativt(chasisNumber);
            bikes.Remove(bikeToDelete);
        }

        public List<Bike> SearchBikesOfModel(string model)
        {
            List<Bike> foundBikes = new List<Bike>();
            foreach (Bike bike in bikes)
            {
                if (bike.Model.Contains(model))
                {
                    foundBikes.Add(bike);
                }
            }

            return foundBikes;
        }

        public List<Bike> SearchBikesOfModelAlternativt(string model)
        {
            return bikes.FindAll( b => b.Model.Contains(model));
        }

        public void deleteAllBikesOfModel(string model)
        {
            /*
             * Man kan ikke slette i den liste du er ved at gennemløbe med foreach
             * Du har i forrige opgave lavet en metoder der finder alle bike af en speciel model
             */
            foreach (Bike bike in SearchBikesOfModel(model))
            {
                bikes.Remove(bike);
            }
        }
    }
}
