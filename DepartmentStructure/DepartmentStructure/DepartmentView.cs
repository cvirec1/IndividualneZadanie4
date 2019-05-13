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
    public partial class DepartmentView : Form
    {
        private DepartmentViewModel _departmentViewModel;
        public DepartmentView()
        {
            InitializeComponent();
            _departmentViewModel = new DepartmentViewModel();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ControlInput())
            {
                _departmentViewModel.NewDepartment.DepartmentName = txbDepartmentName.Text;
                _departmentViewModel.NewDepartment.DepartmentCode = txbCode.Text;
                _departmentViewModel.AddDepartment();
                if (_departmentViewModel.ActionResult.DBResultEnum == DbEnum.DBResposeType.OK)
                {
                    MessageBox.Show(_departmentViewModel.ActionResult.DBResultMessage,
                        $"Success add.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(_departmentViewModel.ActionResult.DBResultMessage,
                        "Wrong action.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(_departmentViewModel.ActionResult.DBResultMessage,
                        " Wrong action please fill neccesary data.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            
        }

        private bool ControlInput()
        {

            if (String.IsNullOrWhiteSpace(txbCode.Text) && String.IsNullOrWhiteSpace(txbDepartmentName.Text))
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
