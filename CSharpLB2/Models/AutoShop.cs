using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLB2.Models
{
    public class AutoShop : IComparable<AutoShop>
    {
        public string Name { get; set; }
        public int NumberOfDepartments { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Address { get; set; }

        public int AverageMonthlyMoneyIncome { get; set; }
        public int AllSalaryOfEmployees { get; set; }
        public int AllCostsOfGoods { get; set; }
        public int CountOfGoods { get; set; }


        public AutoShop(string name,
                        int numberOfDepartments,
                        int numberOfEmployees,
                        string address,
                        int averageMonthlyMoneyIncome,
                        int allSalaryOfEmployees,
                        int allCostsOfGoods,
                        int countOfGoods)
        {
            Name = name;
            NumberOfDepartments = numberOfDepartments;
            NumberOfEmployees = numberOfEmployees;
            Address = address;
            AverageMonthlyMoneyIncome = averageMonthlyMoneyIncome;
            AllSalaryOfEmployees = allSalaryOfEmployees;
            AllCostsOfGoods = allCostsOfGoods;
            CountOfGoods = countOfGoods;
        }

        public int this[string propName]
        {
            get
            {
                switch (propName)
                {
                    case "Income": return AverageMonthlyMoneyIncome;
                    case "Salary": return AllSalaryOfEmployees;
                    case "Costs": return AllCostsOfGoods;
                    default: throw new Exception("Unknown property");
                }
            }
        }
        public int CalcuteIncomeMonth(int countMonth)
        {
            return countMonth * AverageMonthlyMoneyIncome;
        }

        public int CalcuteIncomeYear(int countYear)
        {
            return countYear * AverageMonthlyMoneyIncome * 12;
        }

        public void HireEmployee()
        {
           
            NumberOfEmployees++;
        }
        public void FireEmployee()
        {
            if (NumberOfEmployees > 0)
            {
                NumberOfEmployees--;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Address: {1}, Departments: {2}, Employees: {3}, Income: {4}, Employees Salary: {5}, Goods Count {6}, Goods Costs {7}",
                          Name, Address, NumberOfDepartments, NumberOfEmployees, AverageMonthlyMoneyIncome, AllSalaryOfEmployees, CountOfGoods, AllCostsOfGoods);
        }

        public int CalcTax()
        {
            return (AverageMonthlyMoneyIncome * 12 * 17) / 100;
        }

        public static AutoShop operator ++(AutoShop shop)
        {
            shop.NumberOfEmployees++;
            return shop;
        }

        public static AutoShop operator --(AutoShop shop)
        {
            shop.NumberOfEmployees--;
            return shop;
        }

        public int CompareTo(AutoShop shop)
        {
            if (shop is null) throw new ArgumentException("Inccorect parameter");
            return NumberOfDepartments - shop.NumberOfDepartments;
        }
    }
}
