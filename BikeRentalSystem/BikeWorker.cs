﻿using System;

namespace BikeRentalSystem
{
    internal class BikeWorker
    {
        public BikeWorker()
        {
        }

        public void Start()
        {
            Bike b1 = new Bike();
            Bike b2 = new Bike("Herre", 2016, "Rød", "SX345678");
            Bike b3 = new Bike("Barn", 2019, "grøn", "BB123455");

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);

            BikeCatalog bikeCatalog = new BikeCatalog();
            try
            {
                bikeCatalog.AddBike(b1);
                bikeCatalog.AddBike(b2);
                bikeCatalog.AddBike(b3);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            

            Bike b4 = new Bike("Dame", 2020, "Blå", "BB123455");

            try
            {
                bikeCatalog.AddBike(b4);

                // hvis bikeCatalog.AddBike(b4); kaster en exception bliver resten af try-blok skippet
                Bike b5 = new Bike("Dame", 2020, "Blå", "KB123455");
                bikeCatalog.AddBike(b5);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }


            EBike eb = new EBike("Herre", 2019, "sort", "bmx678", 300);
            
            bikeCatalog.AddBike(eb);
            bikeCatalog.PrintBikeList();


            Bike bsearch = bikeCatalog.SearchBike("BB123455");
            Console.WriteLine("BB123455 = " + bsearch);
            Bike bsearch2 = bikeCatalog.SearchBike("Findes ikke");
            Console.WriteLine("findes ikke  = " + bsearch2);

            Console.WriteLine("Sletter BB123455");
            bikeCatalog.DeleteBike("BB123455");
            bikeCatalog.PrintBikeList();

            Console.WriteLine("søger model 'Herre'");
            foreach (Bike b in bikeCatalog.SearchBikesOfModel("Herre"))
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("Sletter alle 'Herre'");
            bikeCatalog.deleteAllBikesOfModel("Herre");
            bikeCatalog.PrintBikeList();

        }
    }
}