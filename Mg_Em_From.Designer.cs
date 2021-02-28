
namespace RestaurantManagement
{
    partial class Mg_Em_From
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
            this.components = new System.ComponentModel.Container();
            this.L_Status = new System.Windows.Forms.Label();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.Co_Status = new System.Windows.Forms.ComboBox();
            this.Co_Depart = new System.Windows.Forms.ComboBox();
            this.L_Depart = new System.Windows.Forms.Label();
            this.T_Salary = new System.Windows.Forms.TextBox();
            this.T_Email = new System.Windows.Forms.TextBox();
            this.T_Tel = new System.Windows.Forms.TextBox();
            this.T_Nation = new System.Windows.Forms.TextBox();
            this.T_Adress = new System.Windows.Forms.TextBox();
            this.Co_Gender = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.T_Birth = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.T_Surname = new System.Windows.Forms.TextBox();
            this.T_Name = new System.Windows.Forms.TextBox();
            this.L_Email = new System.Windows.Forms.Label();
            this.L_Sarary = new System.Windows.Forms.Label();
            this.L_Tel = new System.Windows.Forms.Label();
            this.L_Nation = new System.Windows.Forms.Label();
            this.L_Address = new System.Windows.Forms.Label();
            this.L_Birth = new System.Windows.Forms.Label();
            this.L_Gender = new System.Windows.Forms.Label();
            this.L_Surname = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.Label();
            this.L_Sh_Em = new System.Windows.Forms.Label();
            this.L_IDNum = new System.Windows.Forms.Label();
            this.T_IDNum = new System.Windows.Forms.TextBox();
            this.Sh_Em_Data = new System.Windows.Forms.DataGridView();
            this.BT_Clear = new System.Windows.Forms.Button();
            this.Co_Sl_Depart = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sh_Em_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Status
            // 
            this.L_Status.AutoSize = true;
            this.L_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Status.Location = new System.Drawing.Point(634, 74);
            this.L_Status.Name = "L_Status";
            this.L_Status.Size = new System.Drawing.Size(96, 32);
            this.L_Status.TabIndex = 58;
            this.L_Status.Text = "Status";
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.BackColor = System.Drawing.Color.Red;
            this.BT_Cancel.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BT_Cancel.ForeColor = System.Drawing.Color.White;
            this.BT_Cancel.Location = new System.Drawing.Point(930, 611);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(120, 50);
            this.BT_Cancel.TabIndex = 57;
            this.BT_Cancel.Text = "Cancel";
            this.BT_Cancel.UseVisualStyleBackColor = false;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Update
            // 
            this.BT_Update.BackColor = System.Drawing.Color.Blue;
            this.BT_Update.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BT_Update.ForeColor = System.Drawing.Color.White;
            this.BT_Update.Location = new System.Drawing.Point(804, 611);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(120, 50);
            this.BT_Update.TabIndex = 56;
            this.BT_Update.Text = "Update";
            this.BT_Update.UseVisualStyleBackColor = false;
            // 
            // BT_Save
            // 
            this.BT_Save.BackColor = System.Drawing.Color.Lime;
            this.BT_Save.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BT_Save.ForeColor = System.Drawing.Color.White;
            this.BT_Save.Location = new System.Drawing.Point(678, 611);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(120, 50);
            this.BT_Save.TabIndex = 55;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = false;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // Co_Status
            // 
            this.Co_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Co_Status.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Co_Status.FormattingEnabled = true;
            this.Co_Status.Location = new System.Drawing.Point(736, 74);
            this.Co_Status.Name = "Co_Status";
            this.Co_Status.Size = new System.Drawing.Size(149, 44);
            this.Co_Status.TabIndex = 54;
            // 
            // Co_Depart
            // 
            this.Co_Depart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Co_Depart.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Co_Depart.FormattingEnabled = true;
            this.Co_Depart.Location = new System.Drawing.Point(184, 546);
            this.Co_Depart.Name = "Co_Depart";
            this.Co_Depart.Size = new System.Drawing.Size(190, 44);
            this.Co_Depart.TabIndex = 53;
            // 
            // L_Depart
            // 
            this.L_Depart.AutoSize = true;
            this.L_Depart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Depart.Location = new System.Drawing.Point(15, 546);
            this.L_Depart.Name = "L_Depart";
            this.L_Depart.Size = new System.Drawing.Size(163, 32);
            this.L_Depart.TabIndex = 52;
            this.L_Depart.Text = "Department";
            // 
            // T_Salary
            // 
            this.T_Salary.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.T_Salary.Location = new System.Drawing.Point(184, 596);
            this.T_Salary.Name = "T_Salary";
            this.T_Salary.Size = new System.Drawing.Size(190, 43);
            this.T_Salary.TabIndex = 51;
            this.T_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Salary_KeyPress);
            // 
            // T_Email
            // 
            this.T_Email.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.T_Email.Location = new System.Drawing.Point(139, 500);
            this.T_Email.Name = "T_Email";
            this.T_Email.Size = new System.Drawing.Size(379, 43);
            this.T_Email.TabIndex = 50;
            // 
            // T_Tel
            // 
            this.T_Tel.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.T_Tel.Location = new System.Drawing.Point(139, 454);
            this.T_Tel.Name = "T_Tel";
            this.T_Tel.Size = new System.Drawing.Size(190, 43);
            this.T_Tel.TabIndex = 49;
            this.T_Tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_Nation
            // 
            this.T_Nation.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.T_Nation.Location = new System.Drawing.Point(193, 237);
            this.T_Nation.Name = "T_Nation";
            this.T_Nation.Size = new System.Drawing.Size(190, 43);
            this.T_Nation.TabIndex = 48;
            // 
            // T_Adress
            // 
            this.T_Adress.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.T_Adress.Location = new System.Drawing.Point(139, 287);
            this.T_Adress.Multiline = true;
            this.T_Adress.Name = "T_Adress";
            this.T_Adress.Size = new System.Drawing.Size(379, 161);
            this.T_Adress.TabIndex = 47;
            // 
            // Co_Gender
            // 
            this.Co_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Co_Gender.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Co_Gender.FormattingEnabled = true;
            this.Co_Gender.Location = new System.Drawing.Point(505, 177);
            this.Co_Gender.Name = "Co_Gender";
            this.Co_Gender.Size = new System.Drawing.Size(123, 44);
            this.Co_Gender.TabIndex = 46;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            // 
            // T_Birth
            // 
            this.T_Birth.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.T_Birth.Location = new System.Drawing.Point(193, 181);
            this.T_Birth.Name = "T_Birth";
            this.T_Birth.Size = new System.Drawing.Size(190, 43);
            this.T_Birth.TabIndex = 45;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "Department";
            // 
            // T_Surname
            // 
            this.T_Surname.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.T_Surname.Location = new System.Drawing.Point(438, 128);
            this.T_Surname.Name = "T_Surname";
            this.T_Surname.Size = new System.Drawing.Size(190, 43);
            this.T_Surname.TabIndex = 44;
            // 
            // T_Name
            // 
            this.T_Name.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.T_Name.Location = new System.Drawing.Point(106, 128);
            this.T_Name.Name = "T_Name";
            this.T_Name.Size = new System.Drawing.Size(190, 43);
            this.T_Name.TabIndex = 43;
            // 
            // L_Email
            // 
            this.L_Email.AutoSize = true;
            this.L_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Email.Location = new System.Drawing.Point(14, 500);
            this.L_Email.Name = "L_Email";
            this.L_Email.Size = new System.Drawing.Size(87, 32);
            this.L_Email.TabIndex = 42;
            this.L_Email.Text = "Email";
            // 
            // L_Sarary
            // 
            this.L_Sarary.AutoSize = true;
            this.L_Sarary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Sarary.Location = new System.Drawing.Point(15, 596);
            this.L_Sarary.Name = "L_Sarary";
            this.L_Sarary.Size = new System.Drawing.Size(96, 32);
            this.L_Sarary.TabIndex = 41;
            this.L_Sarary.Text = "Salary";
            // 
            // L_Tel
            // 
            this.L_Tel.AutoSize = true;
            this.L_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Tel.Location = new System.Drawing.Point(15, 454);
            this.L_Tel.Name = "L_Tel";
            this.L_Tel.Size = new System.Drawing.Size(55, 32);
            this.L_Tel.TabIndex = 40;
            this.L_Tel.Text = "Tel";
            // 
            // L_Nation
            // 
            this.L_Nation.AutoSize = true;
            this.L_Nation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Nation.Location = new System.Drawing.Point(15, 237);
            this.L_Nation.Name = "L_Nation";
            this.L_Nation.Size = new System.Drawing.Size(150, 32);
            this.L_Nation.TabIndex = 39;
            this.L_Nation.Text = "Nationality";
            // 
            // L_Address
            // 
            this.L_Address.AutoSize = true;
            this.L_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Address.Location = new System.Drawing.Point(14, 287);
            this.L_Address.Name = "L_Address";
            this.L_Address.Size = new System.Drawing.Size(119, 32);
            this.L_Address.TabIndex = 38;
            this.L_Address.Text = "Address";
            // 
            // L_Birth
            // 
            this.L_Birth.AutoSize = true;
            this.L_Birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Birth.Location = new System.Drawing.Point(15, 181);
            this.L_Birth.Name = "L_Birth";
            this.L_Birth.Size = new System.Drawing.Size(172, 32);
            this.L_Birth.TabIndex = 37;
            this.L_Birth.Text = "Date of Birth";
            // 
            // L_Gender
            // 
            this.L_Gender.AutoSize = true;
            this.L_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Gender.Location = new System.Drawing.Point(389, 182);
            this.L_Gender.Name = "L_Gender";
            this.L_Gender.Size = new System.Drawing.Size(110, 32);
            this.L_Gender.TabIndex = 36;
            this.L_Gender.Text = "Gender";
            // 
            // L_Surname
            // 
            this.L_Surname.AutoSize = true;
            this.L_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Surname.Location = new System.Drawing.Point(302, 128);
            this.L_Surname.Name = "L_Surname";
            this.L_Surname.Size = new System.Drawing.Size(130, 32);
            this.L_Surname.TabIndex = 35;
            this.L_Surname.Text = "Surname";
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Name.Location = new System.Drawing.Point(15, 128);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(90, 32);
            this.L_Name.TabIndex = 34;
            this.L_Name.Text = "Name";
            // 
            // L_Sh_Em
            // 
            this.L_Sh_Em.AutoSize = true;
            this.L_Sh_Em.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Sh_Em.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.L_Sh_Em.Location = new System.Drawing.Point(11, 10);
            this.L_Sh_Em.Name = "L_Sh_Em";
            this.L_Sh_Em.Size = new System.Drawing.Size(420, 51);
            this.L_Sh_Em.TabIndex = 33;
            this.L_Sh_Em.Text = "Manage Registration";
            // 
            // L_IDNum
            // 
            this.L_IDNum.AutoSize = true;
            this.L_IDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_IDNum.Location = new System.Drawing.Point(15, 74);
            this.L_IDNum.Name = "L_IDNum";
            this.L_IDNum.Size = new System.Drawing.Size(234, 32);
            this.L_IDNum.TabIndex = 32;
            this.L_IDNum.Text = "Identification NO.";
            // 
            // T_IDNum
            // 
            this.T_IDNum.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.T_IDNum.Location = new System.Drawing.Point(255, 74);
            this.T_IDNum.Name = "T_IDNum";
            this.T_IDNum.Size = new System.Drawing.Size(373, 43);
            this.T_IDNum.TabIndex = 31;
            this.T_IDNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_IDNum_KeyPress);
            // 
            // Sh_Em_Data
            // 
            this.Sh_Em_Data.AllowUserToAddRows = false;
            this.Sh_Em_Data.AllowUserToDeleteRows = false;
            this.Sh_Em_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sh_Em_Data.Location = new System.Drawing.Point(534, 227);
            this.Sh_Em_Data.Name = "Sh_Em_Data";
            this.Sh_Em_Data.RowHeadersWidth = 51;
            this.Sh_Em_Data.RowTemplate.Height = 24;
            this.Sh_Em_Data.Size = new System.Drawing.Size(516, 351);
            this.Sh_Em_Data.TabIndex = 30;
            this.Sh_Em_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sh_Em_Data_CellClick);
            // 
            // BT_Clear
            // 
            this.BT_Clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_Clear.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, System.Drawing.FontStyle.Bold);
            this.BT_Clear.Location = new System.Drawing.Point(552, 611);
            this.BT_Clear.Name = "BT_Clear";
            this.BT_Clear.Size = new System.Drawing.Size(120, 50);
            this.BT_Clear.TabIndex = 59;
            this.BT_Clear.Text = "Clear";
            this.BT_Clear.UseVisualStyleBackColor = false;
            this.BT_Clear.Click += new System.EventHandler(this.BT_Clear_Click);
            // 
            // Co_Sl_Depart
            // 
            this.Co_Sl_Depart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Co_Sl_Depart.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold);
            this.Co_Sl_Depart.FormattingEnabled = true;
            this.Co_Sl_Depart.Location = new System.Drawing.Point(860, 180);
            this.Co_Sl_Depart.Name = "Co_Sl_Depart";
            this.Co_Sl_Depart.Size = new System.Drawing.Size(190, 44);
            this.Co_Sl_Depart.TabIndex = 60;
            // 
            // Mg_Em_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.Co_Sl_Depart);
            this.Controls.Add(this.BT_Clear);
            this.Controls.Add(this.L_Status);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.Co_Status);
            this.Controls.Add(this.Co_Depart);
            this.Controls.Add(this.L_Depart);
            this.Controls.Add(this.T_Salary);
            this.Controls.Add(this.T_Email);
            this.Controls.Add(this.T_Tel);
            this.Controls.Add(this.T_Nation);
            this.Controls.Add(this.T_Adress);
            this.Controls.Add(this.Co_Gender);
            this.Controls.Add(this.T_Birth);
            this.Controls.Add(this.T_Surname);
            this.Controls.Add(this.T_Name);
            this.Controls.Add(this.L_Email);
            this.Controls.Add(this.L_Sarary);
            this.Controls.Add(this.L_Tel);
            this.Controls.Add(this.L_Nation);
            this.Controls.Add(this.L_Address);
            this.Controls.Add(this.L_Birth);
            this.Controls.Add(this.L_Gender);
            this.Controls.Add(this.L_Surname);
            this.Controls.Add(this.L_Name);
            this.Controls.Add(this.L_Sh_Em);
            this.Controls.Add(this.L_IDNum);
            this.Controls.Add(this.T_IDNum);
            this.Controls.Add(this.Sh_Em_Data);
            this.Name = "Mg_Em_From";
            this.Text = "Restaurant Management";
            this.Load += new System.EventHandler(this.Mg_Em_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sh_Em_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label L_Status;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.ComboBox Co_Status;
        private System.Windows.Forms.ComboBox Co_Depart;
        private System.Windows.Forms.Label L_Depart;
        private System.Windows.Forms.TextBox T_Salary;
        private System.Windows.Forms.TextBox T_Email;
        private System.Windows.Forms.TextBox T_Tel;
        private System.Windows.Forms.TextBox T_Nation;
        private System.Windows.Forms.TextBox T_Adress;
        private System.Windows.Forms.ComboBox Co_Gender;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.TextBox T_Birth;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.TextBox T_Surname;
        private System.Windows.Forms.TextBox T_Name;
        private System.Windows.Forms.Label L_Email;
        private System.Windows.Forms.Label L_Sarary;
        private System.Windows.Forms.Label L_Tel;
        private System.Windows.Forms.Label L_Nation;
        private System.Windows.Forms.Label L_Address;
        private System.Windows.Forms.Label L_Birth;
        private System.Windows.Forms.Label L_Gender;
        private System.Windows.Forms.Label L_Surname;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Label L_Sh_Em;
        private System.Windows.Forms.Label L_IDNum;
        private System.Windows.Forms.TextBox T_IDNum;
        private System.Windows.Forms.DataGridView Sh_Em_Data;
        private System.Windows.Forms.Button BT_Clear;
        private System.Windows.Forms.ComboBox Co_Sl_Depart;
    }
}

