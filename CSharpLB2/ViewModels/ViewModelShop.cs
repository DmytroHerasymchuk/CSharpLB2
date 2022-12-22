using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLB2.Models;
using CSharpLB2.Models.WorkerEnums;
using CSharpLB2.Models.CarEnums;
using CSharpLB2.Core;

namespace CSharpLB2.ViewModels
{
    public class ViewModelShop
    {
        public AutoShop Shop;
        public ViewModelShop(AutoShop shop)
        {
            Shop = shop;
        }

        public void CreateWorker(string name, string lastName, Education education, Position position, DateTime birthday, int salary)
        {
            Worker worker = new Worker(name, lastName, education, position, birthday, salary);
            Shop.HireEmployee(worker);
        }

        public void CreateCars(CarBrand brand, string name, ControlType controlType, FuelType fuelType, double engineVolume, double fuelPer100KM, int priceForShop, int priceForClient, int quantity)
        {           
            Car car = new Car(brand, name, controlType, fuelType, engineVolume, fuelPer100KM, priceForShop, priceForClient);
            Shop.AddCars(car, quantity);         
        }

        public void SellCar(Car car)
        {
            Shop.SellCar(car);
        }

        public void FireAll()
        {
            Shop.FireAll();
        }

        public void FireByIPN(string IPN)
        {
            Shop.FireEmployee(IPN);
        }

        public Car FindCar(string brandName)
        {
            return Shop.Cars.FirstOrDefault(a=>a.BrandName==brandName);
        }
    }
}
