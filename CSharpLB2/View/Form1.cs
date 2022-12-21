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

namespace CSharpLB2
{
    public partial class Form1 : Form
    {
        private ViewModel _viewModel;
        public Form1()
        {
            InitializeComponent();
            _viewModel = new ViewModel();          
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
                                      Convert.ToInt32(CountDepTextBox.Text),
                                      Convert.ToInt32(CountOfEmployeesTextBox.Text),
                                      AddressTextBox.Text,
                                      Convert.ToInt32(IncomeTextBox.Text),
                                      Convert.ToInt32(BudgetTextBox.Text),
                                      Convert.ToInt32(CostsTextBox.Text),
                                      Convert.ToInt32(CountOfGoodsTextBox.Text));
            }
        }
        private void MonthCalcButton_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty() && Validator.Validate(MonthTextBox.Text))
            {
                int countMonth = Convert.ToInt32(MonthTextBox.Text);
                _viewModel.CalculateIncomeMonth(AllShopsGrid, countMonth);
            }
        }

        private void YearCalcButton_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty() && Validator.Validate(YearTextBox.Text) )
            {
                int countYear = Convert.ToInt32(YearTextBox.Text);
                _viewModel.CalculateIncomeYear(AllShopsGrid, countYear);
            }
        }

        private void HireEmployeeButton_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty())
            {
                _viewModel.Hire(AllShopsGrid);
                AllShopsGrid.Refresh();
            }
        }

        private void FireEmployeeButton_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty())
            {
                _viewModel.Fire(AllShopsGrid);
                AllShopsGrid.Refresh();
            }
        }

        private void ToStringButton_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty())
            {
                _viewModel.ShopToString(AllShopsGrid);
            }
        }

        private void TaxCalcButton_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty())
            {
                _viewModel.CalculateTax(AllShopsGrid);
            }
        }

        private void HireIncrementButton_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty())
            {
                _viewModel.HireInc(AllShopsGrid);
                AllShopsGrid.Refresh();
            }
        }

        private void HireDecrementButton_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty())
            {
                _viewModel.FireDec(AllShopsGrid);
                AllShopsGrid.Refresh();
            }
        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty())
            {
                _viewModel.GetIncome(AllShopsGrid);
            }
        }

        private void SalaryButton_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty())
            {
                _viewModel.GetSalary(AllShopsGrid);
            }
        }

        private void CostsButton_Click(object sender, EventArgs e)
        {
            if (CheckGridIsNotEmpty())
            {
                _viewModel.GetCosts(AllShopsGrid);
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

        private void CountDepTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CountDepTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(CountDepTextBox, "Value should not be left blank!");

            }
            else
            {
                if (int.TryParse(CountDepTextBox.Text, out int i))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(CountDepTextBox, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(CountDepTextBox, "Value should be integer value!");
                }

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

        private void CountOfEmployeesTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CountOfEmployeesTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(CountOfEmployeesTextBox, "Value should not be left blank!");
            }
            else
            {
                if (int.TryParse(CountOfEmployeesTextBox.Text, out int i))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(CountOfEmployeesTextBox, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(CountOfEmployeesTextBox, "Value should be integer value!");
                }

            }
        }

        private void MonthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(MonthTextBox.Text))
            {

                errorProvider1.SetError(MonthTextBox, "Value should not be left blank!");
            }
            else
            {
                if (int.TryParse(MonthTextBox.Text, out int i))
                {

                    errorProvider1.SetError(MonthTextBox, "");
                }
                else
                {

                    errorProvider1.SetError(MonthTextBox, "Value should be integer value!");
                }

            }
        }

        private void YearTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(YearTextBox.Text))
            {

                errorProvider1.SetError(YearTextBox, "Value should not be left blank!");
            }
            else
            {
                if (int.TryParse(YearTextBox.Text, out int i))
                {

                    errorProvider1.SetError(YearTextBox, "");
                }
                else
                {

                    errorProvider1.SetError(YearTextBox, "Value should be integer value!");
                }

            }
        }
    }
}
