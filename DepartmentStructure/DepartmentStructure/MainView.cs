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
        private int _employeeID;
        public MainView(int companyID)
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            //_employeeID = (int)dgwEmployee.Rows[0].Cells[0].Value;
        }

        private void dgwEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //_employeeID = (int)dgwEmployee.Rows[e.RowIndex].Cells[0].Value;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (EmployeeView employeeView = new EmployeeView())
            {
                employeeView.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (EmployeeView employeeView = new EmployeeView(_employeeID))
            {
                employeeView.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
