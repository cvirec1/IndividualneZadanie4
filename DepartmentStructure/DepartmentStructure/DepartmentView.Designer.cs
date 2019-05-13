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
            this.btnAdd.Location = new System.Drawing.Point(143, 123);
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
            this.btnCancel.Location = new System.Drawing.Point(39, 123);
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
            this.lblCode.Location = new System.Drawing.Point(37, 58);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(165, 20);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Department code* :";
            // 
            // txbCode
            // 
            this.txbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbCode.Location = new System.Drawing.Point(41, 81);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(190, 26);
            this.txbCode.TabIndex = 4;
            // 
            // DepartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 164);
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
    }
}