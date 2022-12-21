using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLB2.Models.CarEnums;

namespace CSharpLB2.Models
{
    public class Car
    {
        private int _priceForClient;
        public CarBrand Brand { get; set; }
        public string Name { get; set; }
        public ControlType ControlType { get; set; }
        public FuelType FuelType { get; set; }
        public double EngineVolume { get; set; }
        public double FuelPer100KM { get; set; }
        public int PriceForShop { get; set; } 
        public int PriceForClient {
            get
            {
                return _priceForClient;
            }
            set
            {
                if (value > PriceForShop)
                {
                    _priceForClient = value;
                }
            }
        }

        public Car(CarBrand brand, string name, ControlType controlType, FuelType fuelType, double engineVolume, double fuelPer100KM, int priceForShop, int priceForClient)
        {
            Brand = brand;
            Name = name;
            ControlType = controlType;
            FuelType = fuelType;
            EngineVolume = engineVolume;
            FuelPer100KM = fuelPer100KM;
            PriceForShop = priceForShop;
            PriceForClient = priceForClient;
        }
    }
}
