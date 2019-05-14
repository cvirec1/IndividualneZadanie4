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
    public partial class CompanyView : Form
    {
        private CompanyViewModel _companyViewModel;
        private int _companyID;
        public CompanyView()
        {
            InitializeComponent();
            _companyViewModel = new CompanyViewModel();
            dgwCompany.DataSource = _companyViewModel.GetAllCompanies();
            dgwCompany.DataMember = "Company";           
            if (dgwCompany.RowCount > 0)
            {
                _companyID = (int)dgwCompany.Rows[0].Cells[0].Value;
                dgwCompany.DataMember = "Company";
            }
            else
            {
                _companyID = 0;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgwCompany_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _companyID = (int)dgwCompany.Rows[e.RowIndex].Cells[0].Value;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(_companyID!=0)
            {
                using (MainView mainView = new MainView(_companyID))
                {
                    mainView.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("You must add new company.",
                            $"Please add new company.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (DepartmentView departmentView = new DepartmentView(0))
            {
                departmentView.ShowDialog();
                if (departmentView.DialogResult == DialogResult.OK)
                {
                    dgwCompany.DataSource = _companyViewModel.GetAllCompanies();
                    dgwCompany.DataMember = "Company";
                }
            }
        }
    }
}
