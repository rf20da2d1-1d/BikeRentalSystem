using System;

namespace BikeRentalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BikeWorker worker = new BikeWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
