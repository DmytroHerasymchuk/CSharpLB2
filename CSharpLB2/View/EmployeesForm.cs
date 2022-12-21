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
using CSharpLB2.Models.WorkerEnums;

namespace CSharpLB2.View
{
    public partial class EmployeesForm : Form
    {
        private ViewModelShop _viewModel;
        public EmployeesForm(AutoShop shop)
        {
            InitializeComponent();
            _viewModel = new ViewModelShop(shop);
            EducationCB.DataSource = Enum.GetValues(typeof(Education));
            PositionCB.DataSource = Enum.GetValues(typeof(Position));
            
        }

        private void CreatePerson_Click(object sender, EventArgs e)
        {
            _viewModel.CreateWorker(NameTB.Text,
                                    LastNameTB.Text,
                                    (Education)EducationCB.SelectedItem,
                                    (Position)PositionCB.SelectedItem,
                                    DateTime.Parse(BirthdayDT.Text),
                                    Convert.ToInt32(SalaryTB.Text));
        }

        private void FireIPNButton_Click(object sender, EventArgs e)
        {
            _viewModel.FireByIPN(IpnTB.Text);
        }

        private void FireAllButton_Click(object sender, EventArgs e)
        {
            _viewModel.FireAll();
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

        private void LastNameTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(LastNameTB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(NameTB, "Lastname should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(NameTB, "");
            }
        }

        private void SalaryTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(SalaryTB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(SalaryTB, "Value should not be left blank!");
            }
            else
            {
                if (int.TryParse(SalaryTB.Text, out int i))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(SalaryTB, "");
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(SalaryTB, "Value should be integer value!");
                }

            }
        }

        private void IpnTB_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
