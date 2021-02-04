using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRentalSystem
{
    public class Bike
    {
        // Instans felter (attributter)
        private String _model;
        private int _yearOfPurchase;
        private String _frameColor;
        private readonly String _chassisNumber;

        // properties
        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public int YearOfPurchase
        {
            get => _yearOfPurchase;
            set => _yearOfPurchase = value;
        }

        public string FrameColor
        {
            get => _frameColor;
            set => _frameColor = value;
        }

        public string ChassisNumber
        {
            get => _chassisNumber;
            //private set => _chassisNumber = value;
        }

        public Bike()
        {
            _model = "";
            _yearOfPurchase = 0;
            _frameColor = "";
            _chassisNumber = "";
        }

        public Bike(string model, int yearOfPurchase, string frameColor, string chassisNumber)
        {
            _model = model;
            _yearOfPurchase = yearOfPurchase;
            _frameColor = frameColor;
            _chassisNumber = chassisNumber;
        }

        public override string ToString()
        {
            return $"{nameof(Model)}: {Model}, {nameof(YearOfPurchase)}: {YearOfPurchase}, {nameof(FrameColor)}: {FrameColor}, {nameof(ChassisNumber)}: {ChassisNumber}";
        }
    }
}
