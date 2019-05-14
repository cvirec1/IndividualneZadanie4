using DatabaseCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentStructure
{
    public partial class MainView : Form
    {
        private MainViewModel _mainViewModel;
        private int _employeeID;

        public MainView(int companyID)
        {
            InitializeComponent();
            
            _mainViewModel = new MainViewModel();
            _mainViewModel.CompanyID = companyID;
            SetAllDataSource();            
            
        }        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (EmployeeView employeeView = new EmployeeView(_mainViewModel.CompanyID))
            {
                employeeView.ShowDialog();
                if (employeeView.DialogResult == DialogResult.OK)
                {
                    dgwEmployee.DataSource = _mainViewModel.GetAllEmployees();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (EmployeeView employeeView = new EmployeeView(_employeeID, _mainViewModel.CompanyID))
            {
                employeeView.ShowDialog();
                if(employeeView.DialogResult == DialogResult.OK)
                {
                    dgwEmployee.DataSource = _mainViewModel.GetAllEmployees();
                }
            }
        }

        private void SetAllDataSource()
        {
            dgwEmployee.DataSource = _mainViewModel.GetAllEmployees();
            dgwEmployee.DataMember = "Employee";
            if (dgwCompany.RowCount > 0)
            {
                _employeeID = (int)dgwCompany.Rows[0].Cells[0].Value;
            }
            dgwCompany.DataSource = _mainViewModel.GetCompany();
            dgwCompany.DataMember = "Company";
            if (dgwCompany.RowCount > 0)
            {
                _mainViewModel.CompanyID = (int)dgwCompany.Rows[0].Cells[0].Value;
            }
            dgwDivision.DataSource = _mainViewModel.GetAllDivision();
            dgwDivision.DataMember = "Division";
            
            if (dgwDivision.RowCount > 0)
            {
                _mainViewModel.DepartmentID = (int)dgwDivision.Rows[0].Cells[0].Value;
            }
            dgwProject.DataSource = _mainViewModel.GetAllProject();
            dgwProject.DataMember = "Project";            

            dgwDepartment.DataSource = _mainViewModel.GetAllDepartment();
            dgwDepartment.DataMember = "Department";
        }
        

        private void dgwCompany_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _mainViewModel.CompanyID = (int)dgwCompany.Rows[e.RowIndex].Cells[0].Value;
        }

        private void dgwEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _employeeID = (int)dgwEmployee.Rows[e.RowIndex].Cells[0].Value;
        }

        private void dgwDivision_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _mainViewModel.DepartmentID = (int)dgwDivision.Rows[e.RowIndex].Cells[0].Value;
        }

        private void dgwProject_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _mainViewModel.DepartmentID = (int)dgwProject.Rows[e.RowIndex].Cells[0].Value;
        }

        private void dgwDepartment_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _mainViewModel.DepartmentID = (int)dgwDepartment.Rows[e.RowIndex].Cells[0].Value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want delete this Employee?", "Delete Employee", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                _mainViewModel.DeleteEmployee(_employeeID);
                if (_mainViewModel.ActionResult.DBResultEnum == DbEnum.DBResposeType.OK)
                {
                    MessageBox.Show(_mainViewModel.ActionResult.DBResultMessage,
                        $"Success delete.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    dgwEmployee.DataSource = _mainViewModel.GetAllEmployees();
                }
                else
                {
                    MessageBox.Show(_mainViewModel.ActionResult.DBResultMessage,
                        "Wrong action.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            using(DepartmentView departmentView = new DepartmentView(2,_mainViewModel.CompanyID))
            {
                departmentView.ShowDialog();
                if (departmentView.DialogResult == DialogResult.OK)
                {
                    SetAllDataSource();
                }
            }
        }

        private void btnEditNode_Click(object sender, EventArgs e)
        {
            using (DepartmentView departmentView = new DepartmentView(_mainViewModel.DepartmentID, _mainViewModel.CompanyID))
            {
                departmentView.ShowDialog();
                if (departmentView.DialogResult == DialogResult.OK)
                {
                    SetAllDataSource();
                }
            }
        }

        private void dgwDivision_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _mainViewModel.DepartmentID = (int)dgwDivision.Rows[e.RowIndex].Cells[0].Value;
        }

        private void dgwCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _mainViewModel.DepartmentID = (int)dgwCompany.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
