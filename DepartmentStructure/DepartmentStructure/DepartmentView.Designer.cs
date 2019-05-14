namespace DepartmentStructure
{
    partial class DepartmentView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbDepartmentName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblCompanyLevel = new System.Windows.Forms.Label();
            this.cbxCompanyLevel = new System.Windows.Forms.ComboBox();
            this.cbxSupervisor = new System.Windows.Forms.ComboBox();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.cbxHeadDepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txbDepartmentName
            // 
            this.txbDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbDepartmentName.Location = new System.Drawing.Point(39, 32);
            this.txbDepartmentName.Name = "txbDepartmentName";
            this.txbDepartmentName.Size = new System.Drawing.Size(190, 26);
            this.txbDepartmentName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(253, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDepartmentName.Location = new System.Drawing.Point(35, 9);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(170, 20);
            this.lblDepartmentName.TabIndex = 2;
            this.lblDepartmentName.Text = "Department name* :";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(149, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCode.Location = new System.Drawing.Point(279, 9);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(165, 20);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Department code* :";
            // 
            // txbCode
            // 
            this.txbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbCode.Location = new System.Drawing.Point(283, 32);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(190, 26);
            this.txbCode.TabIndex = 4;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHead.Location = new System.Drawing.Point(36, 95);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(169, 20);
            this.lblHead.TabIndex = 7;
            this.lblHead.Text = "Head Department* :";
            // 
            // lblCompanyLevel
            // 
            this.lblCompanyLevel.AutoSize = true;
            this.lblCompanyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCompanyLevel.Location = new System.Drawing.Point(279, 61);
            this.lblCompanyLevel.Name = "lblCompanyLevel";
            this.lblCompanyLevel.Size = new System.Drawing.Size(142, 20);
            this.lblCompanyLevel.TabIndex = 8;
            this.lblCompanyLevel.Text = "CompanyLevel* :";
            // 
            // cbxCompanyLevel
            // 
            this.cbxCompanyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxCompanyLevel.FormattingEnabled = true;
            this.cbxCompanyLevel.Location = new System.Drawing.Point(283, 85);
            this.cbxCompanyLevel.Name = "cbxCompanyLevel";
            this.cbxCompanyLevel.Size = new System.Drawing.Size(190, 24);
            this.cbxCompanyLevel.TabIndex = 9;
            this.cbxCompanyLevel.SelectedIndexChanged += new System.EventHandler(this.cbxCompanyLevel_SelectedIndexChanged);
            // 
            // cbxSupervisor
            // 
            this.cbxSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxSupervisor.FormattingEnabled = true;
            this.cbxSupervisor.Location = new System.Drawing.Point(283, 135);
            this.cbxSupervisor.Name = "cbxSupervisor";
            this.cbxSupervisor.Size = new System.Drawing.Size(190, 24);
            this.cbxSupervisor.TabIndex = 11;
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSupervisor.Location = new System.Drawing.Point(279, 112);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(104, 20);
            this.lblSupervisor.TabIndex = 10;
            this.lblSupervisor.Text = "Supervisor :";
            // 
            // cbxHeadDepartment
            // 
            this.cbxHeadDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxHeadDepartment.FormattingEnabled = true;
            this.cbxHeadDepartment.Location = new System.Drawing.Point(39, 118);
            this.cbxHeadDepartment.Name = "cbxHeadDepartment";
            this.cbxHeadDepartment.Size = new System.Drawing.Size(190, 24);
            this.cbxHeadDepartment.TabIndex = 12;
            // 
            // DepartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 228);
            this.Controls.Add(this.cbxHeadDepartment);
            this.Controls.Add(this.cbxSupervisor);
            this.Controls.Add(this.lblSupervisor);
            this.Controls.Add(this.cbxCompanyLevel);
            this.Controls.Add(this.lblCompanyLevel);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbDepartmentName);
            this.Name = "DepartmentView";
            this.Text = "DepartmentView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDepartmentName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblCompanyLevel;
        private System.Windows.Forms.ComboBox cbxCompanyLevel;
        private System.Windows.Forms.ComboBox cbxSupervisor;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.ComboBox cbxHeadDepartment;
    }
}