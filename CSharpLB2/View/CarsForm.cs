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
using CSharpLB2.Models.CarEnums;

namespace CSharpLB2.View
{
    public partial class CarsForm : Form
    {
        private ViewModelShop _viewModel;
        public CarsForm(AutoShop shop)
        {
            InitializeComponent();
            _viewModel = new ViewModelShop(shop);
            BrandCB.DataSource = Enum.GetValues(typeof(CarBrand));
            ControlCB.DataSource = Enum.GetValues(typeof(ControlType));
            FuelCB.DataSource = Enum.GetValues(typeof(FuelType));
            SellBrandCB.DataSource = _viewModel.Shop.Cars;
            SellBrandCB.DisplayMember = "BrandName";
            SellBrandCB.ValueMember = "BrandName";
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Visible))
            {
                _viewModel.CreateCars((CarBrand)BrandCB.SelectedItem,
                                      NameTB.Text,
                                      (ControlType)ControlCB.SelectedItem,
                                      (FuelType)FuelCB.SelectedValue,
                                      Convert.ToDouble(EngineVolumeTB.Text),
                                      Convert.ToDouble(ConsumptionTB.Text),
                                      Convert.ToInt32(PriceShopTB.Text),
                                      Convert.ToInt32(PriceClientTB.Text),
                                      Convert.ToInt32(QuantityTB.Text));
            }
        }

        private void NameTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(NameTB, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(NameTB, "");
            }
        }

        private void EngineVolumeTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(EngineVolumeTB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(EngineVolumeTB, "Value should not be left blank!");
            }
            else
            {
                if (double.TryParse(EngineVolumeTB.Text, out double i))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(EngineVolumeTB, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(EngineVolumeTB, "Value should be double value!");
                }

            }
        }

        private void ConsumptionTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ConsumptionTB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(ConsumptionTB, "Value should not be left blank!");
            }
            else
            {
                if (double.TryParse(ConsumptionTB.Text, out double i))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(ConsumptionTB, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(ConsumptionTB, "Value should be double value!");
                }

            }
        }

        private void PriceShopTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PriceShopTB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(PriceShopTB, "Value should not be left blank!");
            }
            else
            {
                if (double.TryParse(PriceShopTB.Text, out double i))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(PriceShopTB, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(PriceShopTB, "Value should be double value!");
                }

            }
        }

        private void PriceClientTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PriceClientTB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(PriceClientTB, "Value should not be left blank!");
            }
            else
            {
                if (double.TryParse(PriceClientTB.Text, out double i))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(PriceClientTB, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(PriceClientTB, "Value should be double value!");
                }

            }
        }

        private void QuantityTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(QuantityTB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(QuantityTB, "Value should not be left blank!");
            }
            else
            {
                if (int.TryParse(QuantityTB.Text, out int i))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(QuantityTB, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(QuantityTB, "Value should be integer value!");
                }

            }
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            if (SellBrandCB.Items.Count > 0)
            {
                _viewModel.SellCar(_viewModel.FindCar(SellBrandCB.Text));
            }
            else
            {
                MessageBox.Show("Is no cars for selling!", "Result");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileWorker.Write(_viewModel.Shop.Cars.ToList(), "Cars");
        }
    }
}
