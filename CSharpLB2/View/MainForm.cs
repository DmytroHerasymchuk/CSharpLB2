using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpLB2.ViewModels;
using CSharpLB2.Core;
using CSharpLB2.View;
using CSharpLB2.Models;

using System.IO;
using System.Threading.Tasks;
using System.Text.Json;


namespace CSharpLB2
{
    public partial class MainForm : Form
    {
        private readonly string _pathWorkers = @"ShopData\Workers.json";
        private readonly string _pathCars = @"ShopData\Cars.json";
        private readonly string _pathShops = @"ShopData\Shops.json";
        private ViewModelAll _viewModel;
        public MainForm()
        {
            InitializeComponent();
            _viewModel = new ViewModelAll();
            FileWorker.CreateDirectory();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            BindingSource sourceForGrid = new BindingSource();
            BindingSource sourceComboFirst = new BindingSource();
            BindingSource sourceComboSecond = new BindingSource();
            sourceForGrid.DataSource = _viewModel.Shops;
            sourceComboFirst.DataSource = _viewModel.Shops;
            sourceComboSecond.DataSource = _viewModel.Shops;
            AllShopsGrid.DataSource = sourceForGrid;
            FirstComboBox.DataSource = sourceComboFirst;
            FirstComboBox.DisplayMember = "Name";
            SecondComboBox.DataSource = sourceComboSecond;
            SecondComboBox.DisplayMember = "Name";
        }
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            CreationPanel.Visible = true;
            ListAllPanel.Visible = false;
        }
        private void ListAllButton_Click(object sender, EventArgs e)
        {
            ListAllPanel.Visible = true;
            CreationPanel.Visible = false;
        }
        private void CreationButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Visible))
            {
                _viewModel.CreateShop(NameTextBox.Text,
                                      AddressTextBox.Text,
                                      Convert.ToInt32(IncomeTextBox.Text),
                                      Convert.ToInt32(BudgetTextBox.Text),
                                      Convert.ToInt32(CostsTextBox.Text),
                                      Convert.ToInt32(CountOfGoodsTextBox.Text));
            }
        }
        

        private void ToStringButton_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty())
            {
                _viewModel.ShopToString(AllShopsGrid);
            }
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            if(CheckGridIsNotEmpty())
            {
                _viewModel.CompareShops(FirstComboBox,SecondComboBox);
            }
        }

        private bool CheckGridIsNotEmpty()
        {
            if(AllShopsGrid.RowCount > 0)
            {
                return true;
            }
            MessageBox.Show("There is no shops!", "Result");
            return false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(NameTextBox, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(NameTextBox, "");
            }
        }

        private void AddressTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AddressTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(AddressTextBox, "Address should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(AddressTextBox, "");
            }
        }



        private void CostsTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CostsTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(CostsTextBox, "Value should not be left blank!");
            }
            else
            {
                if (int.TryParse(CostsTextBox.Text, out int i))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(CostsTextBox, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(CostsTextBox, "Value should be integer value!");
                }

            }
        }

        private void IncomeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(IncomeTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(IncomeTextBox, "Value should not be left blank!");
            }
            else
            {
                if (int.TryParse(IncomeTextBox.Text, out int i))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(IncomeTextBox, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(IncomeTextBox, "Value should be integer value!");
                }

            }
        }

        private void CountOfGoodsTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CountOfGoodsTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(CountOfGoodsTextBox, "Value should not be left blank!");
            }
            else
            {
                if (int.TryParse(CountOfGoodsTextBox.Text, out int i))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(CountOfGoodsTextBox, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(CountOfGoodsTextBox, "Value should be integer value!");
                }

            }
        }

        private void BudgetTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(BudgetTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(BudgetTextBox, "Value should not be left blank!");
            }
            else
            {
                if (int.TryParse(BudgetTextBox.Text, out int i))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(BudgetTextBox, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(BudgetTextBox, "Value should be integer value!");
                }

            }
        }

        private void AddCars_button_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty())
            {
                EmployeesForm form = new EmployeesForm(_viewModel.GetShopFromDataGrid(AllShopsGrid));
                form.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty())
            {
                CarsForm form = new CarsForm(_viewModel.GetShopFromDataGrid(AllShopsGrid));
                form.Show();
            }
            
        }




        

        private async Task<List<AutoShop>> DeserializeAsync()
        {
            using (FileStream stream = new FileStream(_pathShops, FileMode.OpenOrCreate))
            {
                List<AutoShop> shops = await JsonSerializer.DeserializeAsync<List<AutoShop>>(stream);
                return shops;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        

        private async void LoadButton_Click(object sender, EventArgs e)
        {
           
                List<AutoShop> shops = await DeserializeAsync();

                AllShopsGrid.DataSource = shops;
            
        }
        private async void button4_Click(object sender, EventArgs e)
        {
            var shops_list = new List<AutoShop>();

            foreach (DataGridViewRow row in AllShopsGrid.Rows)
            {
                if (row != null)
                    shops_list.Add((AutoShop)row.DataBoundItem);
            }

            await SerializeAsync(shops_list);

            UnloadAsync();
        }

        private async Task SerializeAsync(List<AutoShop> shops)
        {
            using (var stream = new FileStream(_pathShops, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<List<AutoShop>>(stream, shops);
            }
        }
        private async void UnloadAsync()
        {
            var cars = new List<Car>();
            var workers = new Dictionary<string, Worker>();
            foreach (DataGridViewRow item in AllShopsGrid.Rows)
            {
                var shop = (AutoShop)item.DataBoundItem;

                foreach (var car in shop.Cars)
                {
                    cars.Add(car);
                }
                foreach (var worker in shop.Workers)
                {
                    workers.Add(worker.Key,worker.Value);
                }
            }

            await SerializeCarsAsync(cars);
            await SerializeWorkersAsync(workers);
        }

        private async Task SerializeCarsAsync(List<Car> cars)
        {
            using (var stream = new FileStream(_pathCars, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<List<Car>>(stream, cars);
            }
        }
        private async Task SerializeWorkersAsync(Dictionary<string, Worker> workers)
        {
            using (var stream = new FileStream(_pathWorkers, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Dictionary<string,Worker>>(stream, workers);
            }
        }
    }
}
