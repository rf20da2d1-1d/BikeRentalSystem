using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRentalSystem
{
    public class EBike : Bike  // ebike arvet fra Bike
    {
        private int _motor;

        public int Motor
        {
            get => _motor;
            set => _motor = value;
        }

        public EBike()
        {
            _motor = 0;
        }

        public EBike(string model, int yearOfPurchase, string frameColor, string chassisNumber, int motor) : 
            base(model, yearOfPurchase, frameColor, chassisNumber)
        {
            _motor = motor;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Motor)}: {Motor}";
        }
    }
}
