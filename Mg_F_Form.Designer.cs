
namespace RestaurantManagement
{
    partial class Mg_F_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mg_F_Form));
            this.L_FName = new System.Windows.Forms.Label();
            this.L_FPrice = new System.Windows.Forms.Label();
            this.Co_TFood = new System.Windows.Forms.ComboBox();
            this.T_FPrice = new System.Windows.Forms.TextBox();
            this.T_FName = new System.Windows.Forms.TextBox();
            this.L_TFood = new System.Windows.Forms.Label();
            this.BT_UpLoadPic = new System.Windows.Forms.Button();
            this.Sh_F_Data = new System.Windows.Forms.DataGridView();
            this.CO_SL_T_F = new System.Windows.Forms.ComboBox();
            this.P_Food = new System.Windows.Forms.PictureBox();
            this.Bt_Pic = new System.Windows.Forms.Button();
            this.L_Show = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Bt_to_Employ = new System.Windows.Forms.Button();
            this.Bt_to_Chef = new System.Windows.Forms.Button();
            this.Bt_To_Cashier = new System.Windows.Forms.Button();
            this.BT_Clear = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_Log_Out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sh_F_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_Food)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_FName
            // 
            this.L_FName.AutoSize = true;
            this.L_FName.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.L_FName.Location = new System.Drawing.Point(712, 441);
            this.L_FName.Name = "L_FName";
            this.L_FName.Size = new System.Drawing.Size(116, 58);
            this.L_FName.TabIndex = 0;
            this.L_FName.Text = "Name";
            // 
            // L_FPrice
            // 
            this.L_FPrice.AutoSize = true;
            this.L_FPrice.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.L_FPrice.Location = new System.Drawing.Point(712, 487);
            this.L_FPrice.Name = "L_FPrice";
            this.L_FPrice.Size = new System.Drawing.Size(102, 58);
            this.L_FPrice.TabIndex = 1;
            this.L_FPrice.Text = "Price";
            // 
            // Co_TFood
            // 
            this.Co_TFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Co_TFood.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Co_TFood.FormattingEnabled = true;
            this.Co_TFood.Location = new System.Drawing.Point(869, 557);
            this.Co_TFood.Name = "Co_TFood";
            this.Co_TFood.Size = new System.Drawing.Size(159, 48);
            this.Co_TFood.TabIndex = 2;
            // 
            // T_FPrice
            // 
            this.T_FPrice.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_FPrice.Location = new System.Drawing.Point(869, 502);
            this.T_FPrice.Name = "T_FPrice";
            this.T_FPrice.Size = new System.Drawing.Size(159, 47);
            this.T_FPrice.TabIndex = 3;
            this.T_FPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_FPrice_KeyPress);
            // 
            // T_FName
            // 
            this.T_FName.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_FName.Location = new System.Drawing.Point(869, 444);
            this.T_FName.Name = "T_FName";
            this.T_FName.Size = new System.Drawing.Size(275, 47);
            this.T_FName.TabIndex = 4;
            // 
            // L_TFood
            // 
            this.L_TFood.AutoSize = true;
            this.L_TFood.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.L_TFood.Location = new System.Drawing.Point(680, 547);
            this.L_TFood.Name = "L_TFood";
            this.L_TFood.Size = new System.Drawing.Size(183, 58);
            this.L_TFood.TabIndex = 5;
            this.L_TFood.Text = "Type Food";
            // 
            // BT_UpLoadPic
            // 
            this.BT_UpLoadPic.Font = new System.Drawing.Font("Andalus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_UpLoadPic.Location = new System.Drawing.Point(1153, 444);
            this.BT_UpLoadPic.Name = "BT_UpLoadPic";
            this.BT_UpLoadPic.Size = new System.Drawing.Size(115, 50);
            this.BT_UpLoadPic.TabIndex = 6;
            this.BT_UpLoadPic.Text = "Upload";
            this.BT_UpLoadPic.UseVisualStyleBackColor = true;
            this.BT_UpLoadPic.Click += new System.EventHandler(this.BT_UpLoadPic_Click);
            // 
            // Sh_F_Data
            // 
            this.Sh_F_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sh_F_Data.Location = new System.Drawing.Point(377, 127);
            this.Sh_F_Data.Name = "Sh_F_Data";
            this.Sh_F_Data.RowHeadersWidth = 51;
            this.Sh_F_Data.RowTemplate.Height = 24;
            this.Sh_F_Data.Size = new System.Drawing.Size(297, 581);
            this.Sh_F_Data.TabIndex = 7;
            this.Sh_F_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sh_F_Data_CellContentClick);
            // 
            // CO_SL_T_F
            // 
            this.CO_SL_T_F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CO_SL_T_F.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold);
            this.CO_SL_T_F.FormattingEnabled = true;
            this.CO_SL_T_F.Location = new System.Drawing.Point(1099, 127);
            this.CO_SL_T_F.Name = "CO_SL_T_F";
            this.CO_SL_T_F.Size = new System.Drawing.Size(173, 44);
            this.CO_SL_T_F.TabIndex = 8;
            this.CO_SL_T_F.SelectedIndexChanged += new System.EventHandler(this.CO_SL_T_F_SelectedIndexChanged);
            // 
            // P_Food
            // 
            this.P_Food.Location = new System.Drawing.Point(689, 177);
            this.P_Food.Name = "P_Food";
            this.P_Food.Size = new System.Drawing.Size(583, 261);
            this.P_Food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_Food.TabIndex = 9;
            this.P_Food.TabStop = false;
            // 
            // Bt_Pic
            // 
            this.Bt_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Bt_Pic.FlatAppearance.BorderSize = 0;
            this.Bt_Pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Pic.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Pic.Image")));
            this.Bt_Pic.Location = new System.Drawing.Point(22, 27);
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
            this.L_Show.Location = new System.Drawing.Point(103, 14);
            this.L_Show.Name = "L_Show";
            this.L_Show.Size = new System.Drawing.Size(205, 100);
            this.L_Show.TabIndex = 63;
            this.L_Show.Text = "Restaurant \r\nManagement";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.BT_Log_Out);
            this.panel2.Controls.Add(this.Bt_Pic);
            this.panel2.Controls.Add(this.L_Show);
            this.panel2.Location = new System.Drawing.Point(-4, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 124);
            this.panel2.TabIndex = 64;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(156)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Bt_to_Employ);
            this.panel1.Controls.Add(this.Bt_to_Chef);
            this.panel1.Controls.Add(this.Bt_To_Cashier);
            this.panel1.Location = new System.Drawing.Point(-4, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 733);
            this.panel1.TabIndex = 66;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Andalus", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(372, 117);
            this.button2.TabIndex = 67;
            this.button2.Text = "TABLE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Andalus", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(372, 117);
            this.button3.TabIndex = 66;
            this.button3.Text = "FOOD";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Bt_to_Employ
            // 
            this.Bt_to_Employ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.Bt_to_Employ.FlatAppearance.BorderSize = 0;
            this.Bt_to_Employ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_to_Employ.Font = new System.Drawing.Font("Andalus", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_to_Employ.Image = ((System.Drawing.Image)(resources.GetObject("Bt_to_Employ.Image")));
            this.Bt_to_Employ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_to_Employ.Location = new System.Drawing.Point(3, 225);
            this.Bt_to_Employ.Name = "Bt_to_Employ";
            this.Bt_to_Employ.Size = new System.Drawing.Size(372, 117);
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
            this.Bt_to_Chef.Location = new System.Drawing.Point(3, 111);
            this.Bt_to_Chef.Name = "Bt_to_Chef";
            this.Bt_to_Chef.Size = new System.Drawing.Size(372, 117);
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
            this.Bt_To_Cashier.Location = new System.Drawing.Point(3, 0);
            this.Bt_To_Cashier.Name = "Bt_To_Cashier";
            this.Bt_To_Cashier.Size = new System.Drawing.Size(372, 117);
            this.Bt_To_Cashier.TabIndex = 63;
            this.Bt_To_Cashier.Text = "CASHIER";
            this.Bt_To_Cashier.UseVisualStyleBackColor = false;
            // 
            // BT_Clear
            // 
            this.BT_Clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_Clear.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.BT_Clear.Location = new System.Drawing.Point(1034, 515);
            this.BT_Clear.Name = "BT_Clear";
            this.BT_Clear.Size = new System.Drawing.Size(147, 67);
            this.BT_Clear.TabIndex = 66;
            this.BT_Clear.Text = "Clear";
            this.BT_Clear.UseVisualStyleBackColor = false;
            // 
            // BT_Update
            // 
            this.BT_Update.BackColor = System.Drawing.Color.DarkBlue;
            this.BT_Update.FlatAppearance.BorderSize = 0;
            this.BT_Update.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.BT_Update.ForeColor = System.Drawing.Color.White;
            this.BT_Update.Location = new System.Drawing.Point(1000, 642);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(147, 67);
            this.BT_Update.TabIndex = 65;
            this.BT_Update.Text = "Update";
            this.BT_Update.UseVisualStyleBackColor = false;
            // 
            // BT_Save
            // 
            this.BT_Save.BackColor = System.Drawing.Color.Lime;
            this.BT_Save.Font = new System.Drawing.Font("Andalus", 22.2F);
            this.BT_Save.ForeColor = System.Drawing.Color.White;
            this.BT_Save.Location = new System.Drawing.Point(1153, 642);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(120, 67);
            this.BT_Save.TabIndex = 64;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = false;
            // 
            // BT_Log_Out
            // 
            this.BT_Log_Out.FlatAppearance.BorderSize = 0;
            this.BT_Log_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Log_Out.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Log_Out.Image = ((System.Drawing.Image)(resources.GetObject("BT_Log_Out.Image")));
            this.BT_Log_Out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Log_Out.Location = new System.Drawing.Point(1080, 22);
            this.BT_Log_Out.Name = "BT_Log_Out";
            this.BT_Log_Out.Size = new System.Drawing.Size(192, 80);
            this.BT_Log_Out.TabIndex = 67;
            this.BT_Log_Out.Text = "Log Out";
            this.BT_Log_Out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_Log_Out.UseVisualStyleBackColor = true;
            // 
            // Mg_F_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.BT_Clear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.CO_SL_T_F);
            this.Controls.Add(this.Sh_F_Data);
            this.Controls.Add(this.BT_UpLoadPic);
            this.Controls.Add(this.L_TFood);
            this.Controls.Add(this.T_FName);
            this.Controls.Add(this.T_FPrice);
            this.Controls.Add(this.Co_TFood);
            this.Controls.Add(this.L_FPrice);
            this.Controls.Add(this.L_FName);
            this.Controls.Add(this.P_Food);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mg_F_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Management";
            this.Load += new System.EventHandler(this.Mg_F_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sh_F_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_Food)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_FName;
        private System.Windows.Forms.Label L_FPrice;
        private System.Windows.Forms.ComboBox Co_TFood;
        private System.Windows.Forms.TextBox T_FPrice;
        private System.Windows.Forms.TextBox T_FName;
        private System.Windows.Forms.Label L_TFood;
        private System.Windows.Forms.Button BT_UpLoadPic;
        private System.Windows.Forms.DataGridView Sh_F_Data;
        private System.Windows.Forms.ComboBox CO_SL_T_F;
        private System.Windows.Forms.PictureBox P_Food;
        private System.Windows.Forms.Button Bt_Pic;
        private System.Windows.Forms.Label L_Show;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Bt_to_Employ;
        private System.Windows.Forms.Button Bt_to_Chef;
        private System.Windows.Forms.Button Bt_To_Cashier;
        private System.Windows.Forms.Button BT_Clear;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_Log_Out;
    }
}