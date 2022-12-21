using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpLB2.Models;
using CSharpLB2.Core;

namespace CSharpLB2.ViewModels
{
    public class ViewModel
    {
        public BindingList<AutoShop> Shops = new BindingList<AutoShop>();

        public void CreateShop(string name,
                        int numberOfCars,
                        int numberOfEmployees,
                        string address,
                        int averageMonthlyMoneyIncome,
                        int allSalaryOfEmployees,
                        int allCostsOfGoods,
                        int countOfGoods)
        {
            AutoShop shop = new AutoShop(name,
                        address,
                        averageMonthlyMoneyIncome,
                        allSalaryOfEmployees,
                        allCostsOfGoods,
                        countOfGoods);
            Shops.Add(shop);
            MesssageBoxPrint("Shop created!");
        }
        

        public void Hire(DataGridView dataGridView)
        {
            //GetShopFromDataGrid(dataGridView).HireEmployee();
        }
        public void Fire(DataGridView dataGridView)
        {
            //GetShopFromDataGrid(dataGridView).FireEmployee();
        }
        
        public void ShopToString(DataGridView dataGridView)
        {
            MesssageBoxPrint(GetShopFromDataGrid(dataGridView).ToString());
        }
        public void CompareShops(ComboBox comboBoxFirst, ComboBox comboBoxSecond)
        {
            AutoShop shopFirst = GetShopFromComboBox(comboBoxFirst);
            AutoShop shopSecond = GetShopFromComboBox(comboBoxSecond);
            int result = shopFirst.CompareTo(shopSecond);
            if (result == 0)
            {
                MessageBox.Show("Shops are equal", "Result");
                return;
            }
            if (result > 0)
            {
                MessageBox.Show("First shop is bigger", "Result");
                return;
            }
            if (result < 0)
            {
                MessageBox.Show("Second shop is bigger", "Result");
                return;
            }
        }
        
        private AutoShop GetShopFromDataGrid(DataGridView dataGridView)
        {
            return (AutoShop)dataGridView.CurrentRow.DataBoundItem;
        }
        private AutoShop GetShopFromComboBox(ComboBox comboBox)
        {
            return (AutoShop)comboBox.SelectedItem;
        }
        private void MesssageBoxPrint(string text)
        {
            MessageBox.Show("Result is: " + text, "Result");
        }
    }
}
