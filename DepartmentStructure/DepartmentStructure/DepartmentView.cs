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
        private int _type;

        public DepartmentView(int type)
        {
            InitializeComponent();
            _departmentViewModel = new DepartmentViewModel();
            _type = type;
            lblCompanyLevel.Visible = false;
            cbxCompanyLevel.Visible = false;
            lblHead.Visible = false;
            cbxSupervisor.Visible = false;
            lblHead.Visible = false;
            cbxHeadDepartment.Visible = false;
            lblSupervisor.Visible = false;
        }
        public DepartmentView(int type,int companyID)
        {
            InitializeComponent();
            _departmentViewModel = new DepartmentViewModel();
            _departmentViewModel.CompanyID = companyID;
            _type = type;
            if( type == 1)
            {
                foreach (var item in _departmentViewModel.CompanyLevelList)
                {
                    cbxCompanyLevel.Items.Add($"{item.Key} - {item.Value}");
                }
                if (cbxCompanyLevel.Items.Count != 0)
                {
                    cbxCompanyLevel.SelectedIndex = 0;
                }

                foreach (var item in _departmentViewModel.EmployyeList)
                {
                    cbxSupervisor.Items.Add($"{item.EmployeeID} - {item.Name} {item.Surname}");
                }
                if (cbxSupervisor.Items.Count != 0)
                {
                    cbxSupervisor.SelectedIndex = 0;
                }

            }
            else
            {
                _departmentViewModel.GetDepartmentByID(type);
                btnAdd.Text = "Edit";
                this.Text = "Edit Node";
                txbDepartmentName.Text = _departmentViewModel.Department.DepartmentName;
                txbCode.Text = _departmentViewModel.Department.DepartmentCode;

                foreach (var item in _departmentViewModel.CompanyLevelList)
                {
                    cbxCompanyLevel.Items.Add($"{item.Key} - {item.Value}");
                }
                if (cbxCompanyLevel.Items.Count != 0)
                {
                    cbxCompanyLevel.SelectedIndex = cbxCompanyLevel.FindString(_departmentViewModel.Department.CompanyLevelData.CompanyLevelID.ToString());
                    //cbxCompanyLevel.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                foreach (var item in _departmentViewModel.EmployyeList)
                {
                    cbxSupervisor.Items.Add($"{item.EmployeeID} - {item.Name} {item.Surname}");
                }
                if (cbxSupervisor.Items.Count != 0)
                {
                    cbxSupervisor.SelectedIndex = cbxSupervisor.FindString(_departmentViewModel.Department.EmployeeData.EmployeeID.ToString());
                }
                if (cbxHeadDepartment.Items.Count != 0)
                {
                    cbxHeadDepartment.SelectedIndex = cbxHeadDepartment.FindString(_departmentViewModel.Department.HeadDepartment.ToString()); ;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(_type == 0)
            {
                if (ControlInput())
                {
                    _departmentViewModel.NewDepartment.DepartmentName = txbDepartmentName.Text;
                    _departmentViewModel.NewDepartment.DepartmentCode = txbCode.Text;
                    _departmentViewModel.NewDepartment.CompanyLevelData.CompanyLevelID = 1;
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
            }else if (_type == 1)
            {
                if (ControlInput())
                {
                    _departmentViewModel.NewDepartment.DepartmentName = txbDepartmentName.Text;
                    _departmentViewModel.NewDepartment.DepartmentCode = txbCode.Text;
                    var ret1 = cbxCompanyLevel.SelectedItem.ToString().Split(' ');
                    _departmentViewModel.NewDepartment.CompanyLevelData.CompanyLevelID = int.Parse(ret1[0]);
                    var ret2 = cbxHeadDepartment.SelectedItem.ToString().Split(' ');
                    _departmentViewModel.NewDepartment.HeadDepartment= int.Parse(ret2[0]);
                    if (cbxSupervisor.Items.Count != 0)
                    {
                        var ret3 = cbxSupervisor.SelectedItem.ToString().Split(' ');
                        _departmentViewModel.NewDepartment.EmployeeData.EmployeeID = int.Parse(ret3[0]);
                    }                    
                    _departmentViewModel.NewDepartment.IdCompany = _departmentViewModel.CompanyID;
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
            }
            else
            {
                _departmentViewModel.Department.DepartmentName = txbDepartmentName.Text;
                _departmentViewModel.Department.DepartmentCode = txbCode.Text;
                var ret1 = cbxCompanyLevel.SelectedItem.ToString().Split(' ');
                _departmentViewModel.Department.CompanyLevelData.CompanyLevelID = int.Parse(ret1[0]);
                var ret2 = cbxHeadDepartment.SelectedItem.ToString().Split(' ');
                _departmentViewModel.Department.HeadDepartment = int.Parse(ret2[0]);
                if (cbxSupervisor.Items.Count != 0)
                {
                    var ret3 = cbxSupervisor.SelectedItem.ToString().Split(' ');
                    _departmentViewModel.NewDepartment.EmployeeData.EmployeeID = int.Parse(ret3[0]);
                }
                _departmentViewModel.Department.IdCompany = _departmentViewModel.CompanyID;
                _departmentViewModel.UpdateDepartment();
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

        private void txbHeadDepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxCompanyLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ret1 = cbxCompanyLevel.SelectedItem.ToString().Split(' ');
            _departmentViewModel.GetAllDepartments(int.Parse(ret1[0])-1);
            cbxHeadDepartment.Items.Clear();
            foreach (var item in _departmentViewModel.DepartmentList)
            {
                cbxHeadDepartment.Items.Add($"{item.DepartmentID} - {item.DepartmentName}");
            }
            if (cbxHeadDepartment.Items.Count != 0)
            {
                cbxHeadDepartment.SelectedIndex = 0;
            }
        }
    }
}
