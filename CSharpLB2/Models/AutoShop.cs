using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLB2.Models.CarEnums;
using System.ComponentModel;

namespace CSharpLB2.Models
{
    public class AutoShop : IComparable<AutoShop>
    {
        public string Name { get; set; }
        public int NumberOfCars => Cars.Count;
        public int NumberOfEmployees => Workers.Count;     
        public string Address { get; set; }
        public int AverageMonthlyMoneyIncome { get; set; }
        public int AllSalaryOfEmployees { get; set; }
        public int AllCostsOfGoods { get; set; }
        public int CountOfGoods { get; set; }
        public BindingList<Car> Cars = new BindingList<Car>();
        public Dictionary<string, Worker> Workers = new Dictionary<string, Worker>();
        public AutoShop(string name,
                        string address,
                        int averageMonthlyMoneyIncome,
                        int allSalaryOfEmployees,
                        int allCostsOfGoods,
                        int countOfGoods)
        {
            Name = name;
            Address = address;
            AverageMonthlyMoneyIncome = averageMonthlyMoneyIncome;
            AllSalaryOfEmployees = allSalaryOfEmployees;
            AllCostsOfGoods = allCostsOfGoods;
            CountOfGoods = countOfGoods;
        }

     


        public void HireEmployee(Worker person)
        {
            Workers.Add(person.IPN, person);
        }
        public void FireEmployee(string IPN)
        {
            Workers.Remove(IPN);

        }

        public void FireAll()
        {
            Workers.Clear();
        }

        public void AddCars(Car car, int quantity)
        {
            for(int i = 0; i < quantity; i++)
            {
                if (car.PriceForShop > AllCostsOfGoods)
                {
                    return;
                }
                Cars.Add(car);
                AllCostsOfGoods -= car.PriceForShop;
            }
        }

        public void SellCar(Car car)
        {

            Cars.Remove(car);
            AllCostsOfGoods += car.PriceForClient;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Address: {1}, Cars: {2}, Employees: {3}, Income: {4}, Employees Salary: {5}, Goods Count {6}, Goods Costs {7}",
                          Name, Address, NumberOfCars, NumberOfEmployees, AverageMonthlyMoneyIncome, AllSalaryOfEmployees, CountOfGoods, AllCostsOfGoods);
        }

      
        

        public int CompareTo(AutoShop shop)
        {
            if (shop is null) throw new ArgumentException("Inccorect parameter");
            return NumberOfCars - shop.NumberOfCars;
        }

        
    }
}
