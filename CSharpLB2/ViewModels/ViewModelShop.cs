using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLB2.Models;
using CSharpLB2.Models.WorkerEnums;
using CSharpLB2.Models.CarEnums;
using CSharpLB2.Core;
using System.Windows.Forms;

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
            MesssageBoxPrint($"{worker.Name} {worker.LastName} was hired, his IPN = {worker.IPN}");
        }

        public void CreateCars(CarBrand brand, string name, ControlType controlType, FuelType fuelType, double engineVolume, double fuelPer100KM, int priceForShop, int priceForClient, int quantity)
        {           
            Car car = new Car(brand, name, controlType, fuelType, engineVolume, fuelPer100KM, priceForShop, priceForClient);
            if (car.PriceForShop > Shop.AllCostsOfGoods)
            {
                MesssageBoxPrint("Not enough money");
            }
            else
            {
                Shop.AddCars(car, quantity);
                MesssageBoxPrint("Cars added!");
            }
            
        }

        public void SellCar(Car car)
        {
            if (Shop.NumberOfCars > 0)
            {
                Shop.SellCar(car);
                MesssageBoxPrint($"{car.BrandName} is sold");
            }
            else
            {
                MesssageBoxPrint("There is no cars in a shop!");
            }
        }

        public void FireAll()
        {
            if (Shop.NumberOfEmployees > 0)
            {
                MesssageBoxPrint("All employees are fired");
                Shop.FireAll();
            }
            else
            {
                MesssageBoxPrint("There is no employees!");
            }
        }

        public void FireByIPN(string IPN)
        {

            if (Shop.NumberOfEmployees > 0)
            {
                MesssageBoxPrint("Employee with IPN " + IPN + "was fired!");
                Shop.FireEmployee(IPN);
            }
            else
            {
                MesssageBoxPrint("There is no employees!");
            }
        }

        public Car FindCar(string brandName)
        {
            return Shop.Cars.FirstOrDefault(a=>a.BrandName==brandName);
        }

        private void MesssageBoxPrint(string text)
        {
            MessageBox.Show("Result is: " + text, "Result");
        }

        public void WriteWorkers()
        {
            FileWorker.CreateFile("workers");
            FileWorker.Write(Shop.Cars.ToList(), "cars");
        }
    }
}
