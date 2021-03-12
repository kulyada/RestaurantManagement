
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mg_Em_From));
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.Co_Depart = new System.Windows.Forms.ComboBox();
            this.L_Depart = new System.Windows.Forms.Label();
            this.T_Surname = new System.Windows.Forms.TextBox();
            this.T_Name = new System.Windows.Forms.TextBox();
            this.L_Surname = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.Label();
            this.Sh_Em_Data = new System.Windows.Forms.DataGridView();
            this.BT_Clear = new System.Windows.Forms.Button();
            this.Co_Sl_Depart = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Co_Status = new System.Windows.Forms.ComboBox();
            this.L_Status = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Bt_to_Employ = new System.Windows.Forms.Button();
            this.Bt_to_Chef = new System.Windows.Forms.Button();
            this.Bt_To_Cashier = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_Log_Out = new System.Windows.Forms.Button();
            this.Bt_Pic = new System.Windows.Forms.Button();
            this.L_Show = new System.Windows.Forms.Label();
            this.L_Em_ID = new System.Windows.Forms.Label();
            this.L_Sh_Em_ID = new System.Windows.Forms.Label();
            this.Bt_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sh_Em_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Update
            // 
            this.BT_Update.BackColor = System.Drawing.Color.DarkBlue;
            this.BT_Update.FlatAppearance.BorderSize = 0;
            this.BT_Update.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.BT_Update.ForeColor = System.Drawing.Color.White;
            this.BT_Update.Location = new System.Drawing.Point(995, 641);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(147, 67);
            this.BT_Update.TabIndex = 56;
            this.BT_Update.Text = "Update";
            this.BT_Update.UseVisualStyleBackColor = false;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.BackColor = System.Drawing.Color.Lime;
            this.BT_Save.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.BT_Save.ForeColor = System.Drawing.Color.White;
            this.BT_Save.Location = new System.Drawing.Point(1148, 641);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(120, 67);
            this.BT_Save.TabIndex = 55;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = false;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // Co_Depart
            // 
            this.Co_Depart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Co_Depart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Co_Depart.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.Co_Depart.FormattingEnabled = true;
            this.Co_Depart.Location = new System.Drawing.Point(684, 580);
            this.Co_Depart.Name = "Co_Depart";
            this.Co_Depart.Size = new System.Drawing.Size(235, 65);
            this.Co_Depart.TabIndex = 53;
            // 
            // L_Depart
            // 
            this.L_Depart.AutoSize = true;
            this.L_Depart.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Depart.Location = new System.Drawing.Point(473, 588);
            this.L_Depart.Name = "L_Depart";
            this.L_Depart.Size = new System.Drawing.Size(183, 50);
            this.L_Depart.TabIndex = 52;
            this.L_Depart.Text = "Department";
            // 
            // T_Surname
            // 
            this.T_Surname.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.T_Surname.Location = new System.Drawing.Point(684, 510);
            this.T_Surname.Name = "T_Surname";
            this.T_Surname.Size = new System.Drawing.Size(235, 64);
            this.T_Surname.TabIndex = 44;
            // 
            // T_Name
            // 
            this.T_Name.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.T_Name.Location = new System.Drawing.Point(684, 440);
            this.T_Name.Name = "T_Name";
            this.T_Name.Size = new System.Drawing.Size(235, 64);
            this.T_Name.TabIndex = 43;
            // 
            // L_Surname
            // 
            this.L_Surname.AutoSize = true;
            this.L_Surname.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Surname.Location = new System.Drawing.Point(495, 518);
            this.L_Surname.Name = "L_Surname";
            this.L_Surname.Size = new System.Drawing.Size(141, 50);
            this.L_Surname.TabIndex = 35;
            this.L_Surname.Text = "Surname";
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Name.Location = new System.Drawing.Point(518, 448);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(99, 50);
            this.L_Name.TabIndex = 34;
            this.L_Name.Text = "Name";
            // 
            // Sh_Em_Data
            // 
            this.Sh_Em_Data.AllowUserToAddRows = false;
            this.Sh_Em_Data.AllowUserToDeleteRows = false;
            this.Sh_Em_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sh_Em_Data.Location = new System.Drawing.Point(467, 168);
            this.Sh_Em_Data.Name = "Sh_Em_Data";
            this.Sh_Em_Data.RowHeadersWidth = 51;
            this.Sh_Em_Data.RowTemplate.Height = 24;
            this.Sh_Em_Data.Size = new System.Drawing.Size(733, 194);
            this.Sh_Em_Data.TabIndex = 30;
            this.Sh_Em_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sh_Em_Data_CellClick);
            // 
            // BT_Clear
            // 
            this.BT_Clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_Clear.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.BT_Clear.Location = new System.Drawing.Point(995, 510);
            this.BT_Clear.Name = "BT_Clear";
            this.BT_Clear.Size = new System.Drawing.Size(147, 67);
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
            this.Co_Sl_Depart.Location = new System.Drawing.Point(1010, 118);
            this.Co_Sl_Depart.Name = "Co_Sl_Depart";
            this.Co_Sl_Depart.Size = new System.Drawing.Size(190, 44);
            this.Co_Sl_Depart.TabIndex = 60;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "Department";
            // 
            // Co_Status
            // 
            this.Co_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Co_Status.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.Co_Status.FormattingEnabled = true;
            this.Co_Status.Location = new System.Drawing.Point(1048, 376);
            this.Co_Status.Name = "Co_Status";
            this.Co_Status.Size = new System.Drawing.Size(152, 65);
            this.Co_Status.TabIndex = 54;
            // 
            // L_Status
            // 
            this.L_Status.AutoSize = true;
            this.L_Status.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.L_Status.Location = new System.Drawing.Point(925, 373);
            this.L_Status.Name = "L_Status";
            this.L_Status.Size = new System.Drawing.Size(117, 58);
            this.L_Status.TabIndex = 58;
            this.L_Status.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(156)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Bt_to_Employ);
            this.panel1.Controls.Add(this.Bt_to_Chef);
            this.panel1.Controls.Add(this.Bt_To_Cashier);
            this.panel1.Location = new System.Drawing.Point(-22, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 995);
            this.panel1.TabIndex = 61;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Andalus", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(20, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(364, 117);
            this.button2.TabIndex = 67;
            this.button2.Text = "TABLE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Andalus", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(21, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 117);
            this.button1.TabIndex = 66;
            this.button1.Text = "FOOD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Bt_to_Employ
            // 
            this.Bt_to_Employ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.Bt_to_Employ.FlatAppearance.BorderSize = 0;
            this.Bt_to_Employ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_to_Employ.Font = new System.Drawing.Font("Andalus", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_to_Employ.Image = ((System.Drawing.Image)(resources.GetObject("Bt_to_Employ.Image")));
            this.Bt_to_Employ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_to_Employ.Location = new System.Drawing.Point(20, 226);
            this.Bt_to_Employ.Name = "Bt_to_Employ";
            this.Bt_to_Employ.Size = new System.Drawing.Size(364, 117);
            this.Bt_to_Employ.TabIndex = 65;
            this.Bt_to_Employ.Text = "EMPLOYEE";
            this.Bt_to_Employ.UseVisualStyleBackColor = false;
            // 
            // Bt_to_Chef
            // 
            this.Bt_to_Chef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.Bt_to_Chef.FlatAppearance.BorderSize = 0;
            this.Bt_to_Chef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_to_Chef.Font = new System.Drawing.Font("Andalus", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_to_Chef.Image = ((System.Drawing.Image)(resources.GetObject("Bt_to_Chef.Image")));
            this.Bt_to_Chef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_to_Chef.Location = new System.Drawing.Point(20, 114);
            this.Bt_to_Chef.Name = "Bt_to_Chef";
            this.Bt_to_Chef.Size = new System.Drawing.Size(364, 117);
            this.Bt_to_Chef.TabIndex = 64;
            this.Bt_to_Chef.Text = "CHEF";
            this.Bt_to_Chef.UseVisualStyleBackColor = false;
            // 
            // Bt_To_Cashier
            // 
            this.Bt_To_Cashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.Bt_To_Cashier.FlatAppearance.BorderSize = 0;
            this.Bt_To_Cashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_To_Cashier.Font = new System.Drawing.Font("Andalus", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_To_Cashier.Image = ((System.Drawing.Image)(resources.GetObject("Bt_To_Cashier.Image")));
            this.Bt_To_Cashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_To_Cashier.Location = new System.Drawing.Point(20, 0);
            this.Bt_To_Cashier.Name = "Bt_To_Cashier";
            this.Bt_To_Cashier.Size = new System.Drawing.Size(364, 117);
            this.Bt_To_Cashier.TabIndex = 63;
            this.Bt_To_Cashier.Text = "CASHIER";
            this.Bt_To_Cashier.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.BT_Log_Out);
            this.panel2.Controls.Add(this.Bt_Pic);
            this.panel2.Controls.Add(this.L_Show);
            this.panel2.Location = new System.Drawing.Point(-22, -14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1930, 126);
            this.panel2.TabIndex = 62;
            // 
            // BT_Log_Out
            // 
            this.BT_Log_Out.FlatAppearance.BorderSize = 0;
            this.BT_Log_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Log_Out.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Log_Out.Image = ((System.Drawing.Image)(resources.GetObject("BT_Log_Out.Image")));
            this.BT_Log_Out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Log_Out.Location = new System.Drawing.Point(1089, 28);
            this.BT_Log_Out.Name = "BT_Log_Out";
            this.BT_Log_Out.Size = new System.Drawing.Size(192, 80);
            this.BT_Log_Out.TabIndex = 64;
            this.BT_Log_Out.Text = "Log Out";
            this.BT_Log_Out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_Log_Out.UseVisualStyleBackColor = true;
            this.BT_Log_Out.Click += new System.EventHandler(this.BT_Log_Out_Click);
            // 
            // Bt_Pic
            // 
            this.Bt_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Bt_Pic.FlatAppearance.BorderSize = 0;
            this.Bt_Pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Pic.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Pic.Image")));
            this.Bt_Pic.Location = new System.Drawing.Point(50, 28);
            this.Bt_Pic.Name = "Bt_Pic";
            this.Bt_Pic.Size = new System.Drawing.Size(75, 75);
            this.Bt_Pic.TabIndex = 63;
            this.Bt_Pic.UseVisualStyleBackColor = true;
            // 
            // L_Show
            // 
            this.L_Show.AutoSize = true;
            this.L_Show.Font = new System.Drawing.Font("Bodoni MT Condensed", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Show.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.L_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_Show.Location = new System.Drawing.Point(131, 14);
            this.L_Show.Name = "L_Show";
            this.L_Show.Size = new System.Drawing.Size(205, 100);
            this.L_Show.TabIndex = 63;
            this.L_Show.Text = "Restaurant \r\nManagement";
            // 
            // L_Em_ID
            // 
            this.L_Em_ID.AutoSize = true;
            this.L_Em_ID.Font = new System.Drawing.Font("Andalus", 19.8F);
            this.L_Em_ID.Location = new System.Drawing.Point(541, 378);
            this.L_Em_ID.Name = "L_Em_ID";
            this.L_Em_ID.Size = new System.Drawing.Size(55, 50);
            this.L_Em_ID.TabIndex = 63;
            this.L_Em_ID.Text = "ID";
            // 
            // L_Sh_Em_ID
            // 
            this.L_Sh_Em_ID.AutoSize = true;
            this.L_Sh_Em_ID.Font = new System.Drawing.Font("Andalus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Sh_Em_ID.Location = new System.Drawing.Point(732, 373);
            this.L_Sh_Em_ID.Name = "L_Sh_Em_ID";
            this.L_Sh_Em_ID.Size = new System.Drawing.Size(0, 61);
            this.L_Sh_Em_ID.TabIndex = 64;
            // 
            // Bt_Refresh
            // 
            this.Bt_Refresh.FlatAppearance.BorderSize = 0;
            this.Bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Refresh.Image")));
            this.Bt_Refresh.Location = new System.Drawing.Point(971, 122);
            this.Bt_Refresh.Name = "Bt_Refresh";
            this.Bt_Refresh.Size = new System.Drawing.Size(33, 34);
            this.Bt_Refresh.TabIndex = 65;
            this.Bt_Refresh.UseVisualStyleBackColor = true;
            this.Bt_Refresh.Click += new System.EventHandler(this.Bt_Refresh_Click);
            // 
            // Mg_Em_From
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Bt_Refresh);
            this.Controls.Add(this.L_Sh_Em_ID);
            this.Controls.Add(this.L_Em_ID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Co_Sl_Depart);
            this.Controls.Add(this.BT_Clear);
            this.Controls.Add(this.L_Status);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.Co_Status);
            this.Controls.Add(this.Co_Depart);
            this.Controls.Add(this.L_Depart);
            this.Controls.Add(this.T_Surname);
            this.Controls.Add(this.T_Name);
            this.Controls.Add(this.L_Surname);
            this.Controls.Add(this.L_Name);
            this.Controls.Add(this.Sh_Em_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mg_Em_From";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Management";
            this.Load += new System.EventHandler(this.Mg_Em_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sh_Em_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.ComboBox Co_Depart;
        private System.Windows.Forms.Label L_Depart;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.TextBox T_Surname;
        private System.Windows.Forms.TextBox T_Name;
        private System.Windows.Forms.Label L_Surname;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.DataGridView Sh_Em_Data;
        private System.Windows.Forms.Button BT_Clear;
        private System.Windows.Forms.ComboBox Co_Sl_Depart;
        private System.Windows.Forms.ComboBox Co_Status;
        private System.Windows.Forms.Label L_Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label L_Show;
        private System.Windows.Forms.Button Bt_Pic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Bt_to_Employ;
        private System.Windows.Forms.Button Bt_to_Chef;
        private System.Windows.Forms.Button Bt_To_Cashier;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label L_Em_ID;
        private System.Windows.Forms.Label L_Sh_Em_ID;
        private System.Windows.Forms.Button BT_Log_Out;
        private System.Windows.Forms.Button Bt_Refresh;
    }
}

