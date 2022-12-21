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
        public CarBrand Brand { get; set; }
        public string Name { get; set; }
        public ControlType ControlType { get; set; }
        FuelType FuelType { get; set; }
        public double EngineVolume { get; set; }
        public double FuelPer100KM { get; set; }
        public uint PriceForShop { get; set; } 
        public uint PriceForClient {
            get
            {
                return PriceForClient;
            }
            set
            {
                if (value > PriceForShop)
                {
                    PriceForClient = value;
                }
                else
                {
                    PriceForClient = 0;
                }
            }
        }
    }
}
