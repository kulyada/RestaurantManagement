
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
            this.L_Food = new System.Windows.Forms.Label();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sh_F_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_Food)).BeginInit();
            this.SuspendLayout();
            // 
            // L_FName
            // 
            this.L_FName.AutoSize = true;
            this.L_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.L_FName.Location = new System.Drawing.Point(69, 492);
            this.L_FName.Name = "L_FName";
            this.L_FName.Size = new System.Drawing.Size(90, 32);
            this.L_FName.TabIndex = 0;
            this.L_FName.Text = "Name";
            // 
            // L_FPrice
            // 
            this.L_FPrice.AutoSize = true;
            this.L_FPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.L_FPrice.Location = new System.Drawing.Point(75, 541);
            this.L_FPrice.Name = "L_FPrice";
            this.L_FPrice.Size = new System.Drawing.Size(80, 32);
            this.L_FPrice.TabIndex = 1;
            this.L_FPrice.Text = "Price";
            // 
            // Co_TFood
            // 
            this.Co_TFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Co_TFood.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold);
            this.Co_TFood.FormattingEnabled = true;
            this.Co_TFood.Location = new System.Drawing.Point(165, 590);
            this.Co_TFood.Name = "Co_TFood";
            this.Co_TFood.Size = new System.Drawing.Size(196, 44);
            this.Co_TFood.TabIndex = 2;
            // 
            // T_FPrice
            // 
            this.T_FPrice.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold);
            this.T_FPrice.Location = new System.Drawing.Point(165, 541);
            this.T_FPrice.Name = "T_FPrice";
            this.T_FPrice.Size = new System.Drawing.Size(196, 43);
            this.T_FPrice.TabIndex = 3;
            this.T_FPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_FPrice_KeyPress);
            // 
            // T_FName
            // 
            this.T_FName.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold);
            this.T_FName.Location = new System.Drawing.Point(165, 492);
            this.T_FName.Name = "T_FName";
            this.T_FName.Size = new System.Drawing.Size(382, 43);
            this.T_FName.TabIndex = 4;
            // 
            // L_TFood
            // 
            this.L_TFood.AutoSize = true;
            this.L_TFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.L_TFood.Location = new System.Drawing.Point(5, 590);
            this.L_TFood.Name = "L_TFood";
            this.L_TFood.Size = new System.Drawing.Size(150, 32);
            this.L_TFood.TabIndex = 5;
            this.L_TFood.Text = "Type Food";
            // 
            // BT_UpLoadPic
            // 
            this.BT_UpLoadPic.Font = new System.Drawing.Font("TH SarabunPSK", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_UpLoadPic.Location = new System.Drawing.Point(413, 434);
            this.BT_UpLoadPic.Name = "BT_UpLoadPic";
            this.BT_UpLoadPic.Size = new System.Drawing.Size(134, 52);
            this.BT_UpLoadPic.TabIndex = 6;
            this.BT_UpLoadPic.Text = "Upload";
            this.BT_UpLoadPic.UseVisualStyleBackColor = true;
            this.BT_UpLoadPic.Click += new System.EventHandler(this.BT_UpLoadPic_Click);
            // 
            // Sh_F_Data
            // 
            this.Sh_F_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sh_F_Data.Location = new System.Drawing.Point(554, 195);
            this.Sh_F_Data.Name = "Sh_F_Data";
            this.Sh_F_Data.RowHeadersWidth = 51;
            this.Sh_F_Data.RowTemplate.Height = 24;
            this.Sh_F_Data.Size = new System.Drawing.Size(498, 410);
            this.Sh_F_Data.TabIndex = 7;
            this.Sh_F_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sh_F_Data_CellContentClick);
            // 
            // CO_SL_T_F
            // 
            this.CO_SL_T_F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CO_SL_T_F.Font = new System.Drawing.Font("TH SarabunPSK", 16.2F, System.Drawing.FontStyle.Bold);
            this.CO_SL_T_F.FormattingEnabled = true;
            this.CO_SL_T_F.Location = new System.Drawing.Point(553, 145);
            this.CO_SL_T_F.Name = "CO_SL_T_F";
            this.CO_SL_T_F.Size = new System.Drawing.Size(165, 44);
            this.CO_SL_T_F.TabIndex = 8;
            // 
            // P_Food
            // 
            this.P_Food.Location = new System.Drawing.Point(21, 63);
            this.P_Food.Name = "P_Food";
            this.P_Food.Size = new System.Drawing.Size(526, 365);
            this.P_Food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_Food.TabIndex = 9;
            this.P_Food.TabStop = false;
            // 
            // L_Food
            // 
            this.L_Food.AutoSize = true;
            this.L_Food.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.L_Food.Location = new System.Drawing.Point(12, 9);
            this.L_Food.Name = "L_Food";
            this.L_Food.Size = new System.Drawing.Size(287, 51);
            this.L_Food.TabIndex = 10;
            this.L_Food.Text = "Food Manage";
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.BackColor = System.Drawing.Color.Red;
            this.BT_Cancel.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BT_Cancel.ForeColor = System.Drawing.Color.White;
            this.BT_Cancel.Location = new System.Drawing.Point(932, 611);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(120, 50);
            this.BT_Cancel.TabIndex = 60;
            this.BT_Cancel.Text = "Cancel";
            this.BT_Cancel.UseVisualStyleBackColor = false;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Update
            // 
            this.BT_Update.BackColor = System.Drawing.Color.Blue;
            this.BT_Update.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BT_Update.ForeColor = System.Drawing.Color.White;
            this.BT_Update.Location = new System.Drawing.Point(806, 611);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(120, 50);
            this.BT_Update.TabIndex = 59;
            this.BT_Update.Text = "Update";
            this.BT_Update.UseVisualStyleBackColor = false;
            // 
            // BT_Save
            // 
            this.BT_Save.BackColor = System.Drawing.Color.Lime;
            this.BT_Save.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BT_Save.ForeColor = System.Drawing.Color.White;
            this.BT_Save.Location = new System.Drawing.Point(680, 611);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(120, 50);
            this.BT_Save.TabIndex = 58;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = false;
            // 
            // BT_Clear
            // 
            this.BT_Clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_Clear.Font = new System.Drawing.Font("TH SarabunPSK", 19.8F, System.Drawing.FontStyle.Bold);
            this.BT_Clear.Location = new System.Drawing.Point(554, 611);
            this.BT_Clear.Name = "BT_Clear";
            this.BT_Clear.Size = new System.Drawing.Size(120, 50);
            this.BT_Clear.TabIndex = 61;
            this.BT_Clear.Text = "Clear";
            this.BT_Clear.UseVisualStyleBackColor = false;
            this.BT_Clear.Click += new System.EventHandler(this.BT_Clear_Click);
            // 
            // Mg_F_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.BT_Clear);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.L_Food);
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
            this.Name = "Mg_F_Form";
            this.Text = "Restaurant Management";
            this.Load += new System.EventHandler(this.Mg_F_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sh_F_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_Food)).EndInit();
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
        private System.Windows.Forms.Label L_Food;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_Clear;
    }
}