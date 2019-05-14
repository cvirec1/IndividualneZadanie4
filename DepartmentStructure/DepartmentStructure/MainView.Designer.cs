namespace DepartmentStructure
{
    partial class MainView
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
            this.dgwEmployee = new System.Windows.Forms.DataGridView();
            this.dgwCompany = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditNode = new System.Windows.Forms.Button();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.dgwDivision = new System.Windows.Forms.DataGridView();
            this.dgwProject = new System.Windows.Forms.DataGridView();
            this.dgwDepartment = new System.Windows.Forms.DataGridView();
            this.lblCompany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwEmployee
            // 
            this.dgwEmployee.AllowUserToAddRows = false;
            this.dgwEmployee.AllowUserToDeleteRows = false;
            this.dgwEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmployee.Location = new System.Drawing.Point(243, 64);
            this.dgwEmployee.MultiSelect = false;
            this.dgwEmployee.Name = "dgwEmployee";
            this.dgwEmployee.ReadOnly = true;
            this.dgwEmployee.RowHeadersVisible = false;
            this.dgwEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwEmployee.Size = new System.Drawing.Size(717, 182);
            this.dgwEmployee.TabIndex = 0;
            this.dgwEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEmployee_RowEnter);
            // 
            // dgwCompany
            // 
            this.dgwCompany.AllowUserToAddRows = false;
            this.dgwCompany.AllowUserToDeleteRows = false;
            this.dgwCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCompany.Location = new System.Drawing.Point(24, 340);
            this.dgwCompany.MultiSelect = false;
            this.dgwCompany.Name = "dgwCompany";
            this.dgwCompany.ReadOnly = true;
            this.dgwCompany.RowHeadersVisible = false;
            this.dgwCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCompany.Size = new System.Drawing.Size(276, 335);
            this.dgwCompany.TabIndex = 1;
            this.dgwCompany.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCompany_CellClick);
            this.dgwCompany.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCompany_RowEnter);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(243, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(203, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(498, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(203, 34);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Employee";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(757, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(203, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Employee";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditNode
            // 
            this.btnEditNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditNode.Location = new System.Drawing.Point(989, 256);
            this.btnEditNode.Name = "btnEditNode";
            this.btnEditNode.Size = new System.Drawing.Size(203, 34);
            this.btnEditNode.TabIndex = 6;
            this.btnEditNode.Text = "Edit Node";
            this.btnEditNode.UseVisualStyleBackColor = true;
            this.btnEditNode.Click += new System.EventHandler(this.btnEditNode_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNode.Location = new System.Drawing.Point(24, 256);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(203, 34);
            this.btnAddNode.TabIndex = 5;
            this.btnAddNode.Text = "Add Node";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // dgwDivision
            // 
            this.dgwDivision.AllowUserToAddRows = false;
            this.dgwDivision.AllowUserToDeleteRows = false;
            this.dgwDivision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwDivision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDivision.Location = new System.Drawing.Point(323, 340);
            this.dgwDivision.MultiSelect = false;
            this.dgwDivision.Name = "dgwDivision";
            this.dgwDivision.ReadOnly = true;
            this.dgwDivision.RowHeadersVisible = false;
            this.dgwDivision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDivision.Size = new System.Drawing.Size(276, 335);
            this.dgwDivision.TabIndex = 7;
            this.dgwDivision.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDivision_CellClick);
            this.dgwDivision.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDivision_RowEnter);
            // 
            // dgwProject
            // 
            this.dgwProject.AllowUserToAddRows = false;
            this.dgwProject.AllowUserToDeleteRows = false;
            this.dgwProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProject.Location = new System.Drawing.Point(620, 340);
            this.dgwProject.MultiSelect = false;
            this.dgwProject.Name = "dgwProject";
            this.dgwProject.ReadOnly = true;
            this.dgwProject.RowHeadersVisible = false;
            this.dgwProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProject.Size = new System.Drawing.Size(276, 335);
            this.dgwProject.TabIndex = 8;
            this.dgwProject.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProject_RowEnter);
            // 
            // dgwDepartment
            // 
            this.dgwDepartment.AllowUserToAddRows = false;
            this.dgwDepartment.AllowUserToDeleteRows = false;
            this.dgwDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepartment.Location = new System.Drawing.Point(916, 340);
            this.dgwDepartment.MultiSelect = false;
            this.dgwDepartment.Name = "dgwDepartment";
            this.dgwDepartment.ReadOnly = true;
            this.dgwDepartment.RowHeadersVisible = false;
            this.dgwDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDepartment.Size = new System.Drawing.Size(276, 335);
            this.dgwDepartment.TabIndex = 9;
            this.dgwDepartment.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDepartment_RowEnter);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCompany.Location = new System.Drawing.Point(24, 309);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(83, 20);
            this.lblCompany.TabIndex = 10;
            this.lblCompany.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(319, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Division";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(616, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(912, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Department";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 678);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.dgwDepartment);
            this.Controls.Add(this.dgwProject);
            this.Controls.Add(this.dgwDivision);
            this.Controls.Add(this.btnEditNode);
            this.Controls.Add(this.btnAddNode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgwCompany);
            this.Controls.Add(this.dgwEmployee);
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEmployee;
        private System.Windows.Forms.DataGridView dgwCompany;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditNode;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.DataGridView dgwDivision;
        private System.Windows.Forms.DataGridView dgwProject;
        private System.Windows.Forms.DataGridView dgwDepartment;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

