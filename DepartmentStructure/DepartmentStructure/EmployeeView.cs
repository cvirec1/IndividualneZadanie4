using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseCommunication;
using Support;
namespace DepartmentStructure
{
    public partial class EmployeeView : Form
    {
        private EmployeeViewModel _employeeViewModel;
        public EmployeeView(int companyID)
        {
            InitializeComponent();
            _employeeViewModel = new EmployeeViewModel();
            _employeeViewModel.CompanyID = companyID;
            _employeeViewModel.GetAllDepartments();
            foreach (var item in _employeeViewModel.DepartmentList)
            {
                cbxDepartment.Items.Add($"{item.DepartmentID} - {item.DepartmentName}");
            }
            if (cbxDepartment.Items.Count != 0)
            {
                cbxDepartment.SelectedIndex = 0;
            }
            cbxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public EmployeeView(int employeeID, int companyID)
        {
            InitializeComponent();
            _employeeViewModel = new EmployeeViewModel(employeeID);
            _employeeViewModel.CompanyID = companyID;
            this.Text = "Edit employee";
            btnSave.Text = "Edit";
            txbTitle.Text = _employeeViewModel.Employee.Title;
            txbName.Text = _employeeViewModel.Employee.Name;
            txbSurname.Text = _employeeViewModel.Employee.Surname;
            txbPhone.Text = _employeeViewModel.Employee.Phone;
            _employeeViewModel.GetAllDepartments();
            foreach (var item in _employeeViewModel.DepartmentList)
            {
                cbxDepartment.Items.Add($"{item.DepartmentID} - {item.DepartmentName}");
            }
            cbxDepartment.SelectedIndex = cbxDepartment.FindString(_employeeViewModel.Employee.DepartmentID.ToString());
            cbxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Edit")
            {
                if (ControlInput())
                {
                    _employeeViewModel.Employee.Title = txbTitle.Text;
                    _employeeViewModel.Employee.Name= txbName.Text;
                    _employeeViewModel.Employee.Surname= txbSurname.Text;
                    _employeeViewModel.Employee.Phone = txbPhone.Text;
                    if (cbxDepartment.Items.Count != 0)
                    {
                        var ret = cbxDepartment.SelectedItem.ToString().Split(' ');
                        _employeeViewModel.Employee.DepartmentID = int.Parse(ret[0]);
                    }
                    else
                    {
                        _employeeViewModel.Employee.DepartmentID = _employeeViewModel.CompanyID;
                    }
                    _employeeViewModel.UpdateEmployee();
                    if (_employeeViewModel.ActionResult.DBResultEnum == DbEnum.DBResposeType.OK)
                    {
                        MessageBox.Show(_employeeViewModel.ActionResult.DBResultMessage,
                            $"Success add.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(_employeeViewModel.ActionResult.DBResultMessage,
                            "Wrong action.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show($"Zadajte povinné údaje označené *.");
                }

            }
            else
            {
                if (ControlInput())
                {
                    _employeeViewModel.NewEmployee.Title = txbTitle.Text;
                    _employeeViewModel.NewEmployee.Name = txbName.Text;
                    _employeeViewModel.NewEmployee.Surname= txbSurname.Text;
                    _employeeViewModel.NewEmployee.Phone = txbPhone.Text;
                    if(cbxDepartment.Items.Count != 0)
                    {
                        var ret = cbxDepartment.SelectedItem.ToString().Split(' ');
                        _employeeViewModel.NewEmployee.DepartmentID = int.Parse(ret[0]);
                    }
                    else
                    {
                        _employeeViewModel.NewEmployee.DepartmentID = _employeeViewModel.CompanyID;
                    }
                    _employeeViewModel.AddEmployee();
                    if (_employeeViewModel.ActionResult.DBResultEnum == DbEnum.DBResposeType.OK)
                    {
                        MessageBox.Show(_employeeViewModel.ActionResult.DBResultMessage,
                            $"Success add.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(_employeeViewModel.ActionResult.DBResultMessage,
                            "Wrong action.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show($"Zadajte povinné údaje označené *.");
                }

            }
        }

        private bool ControlInput()
        {

            if (String.IsNullOrWhiteSpace(txbName.Text) && String.IsNullOrWhiteSpace(txbSurname.Text) && String.IsNullOrWhiteSpace(txbPhone.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
