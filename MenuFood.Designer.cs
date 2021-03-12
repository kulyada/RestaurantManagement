
namespace RestaurantManagement
{
    partial class Cus_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cus_Order));
            this.L_Menu = new System.Windows.Forms.Label();
            this.Da_Sh_Menu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_Log_Out = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Bt_Pic = new System.Windows.Forms.Button();
            this.L_Show = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bt_To_Order = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.L_Name = new System.Windows.Forms.Label();
            this.L_Price = new System.Windows.Forms.Label();
            this.Sh_N = new System.Windows.Forms.Label();
            this.Sh_P = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Da_Sh_Menu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_Menu
            // 
            this.L_Menu.AutoSize = true;
            this.L_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.L_Menu.Location = new System.Drawing.Point(56, 32);
            this.L_Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Menu.Name = "L_Menu";
            this.L_Menu.Size = new System.Drawing.Size(196, 39);
            this.L_Menu.TabIndex = 0;
            this.L_Menu.Text = "รายการอาหาร";
            // 
            // Da_Sh_Menu
            // 
            this.Da_Sh_Menu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Da_Sh_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Da_Sh_Menu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Da_Sh_Menu.Location = new System.Drawing.Point(394, 125);
            this.Da_Sh_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Da_Sh_Menu.Name = "Da_Sh_Menu";
            this.Da_Sh_Menu.RowHeadersWidth = 51;
            this.Da_Sh_Menu.Size = new System.Drawing.Size(456, 700);
            this.Da_Sh_Menu.TabIndex = 11;
            this.Da_Sh_Menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Da_Sh_Menu_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.BT_Log_Out);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Bt_Pic);
            this.panel2.Controls.Add(this.L_Show);
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 118);
            this.panel2.TabIndex = 65;
            // 
            // BT_Log_Out
            // 
            this.BT_Log_Out.FlatAppearance.BorderSize = 0;
            this.BT_Log_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Log_Out.Font = new System.Drawing.Font("Andalus", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Log_Out.Image = ((System.Drawing.Image)(resources.GetObject("BT_Log_Out.Image")));
            this.BT_Log_Out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Log_Out.Location = new System.Drawing.Point(1131, 19);
            this.BT_Log_Out.Name = "BT_Log_Out";
            this.BT_Log_Out.Size = new System.Drawing.Size(139, 80);
            this.BT_Log_Out.TabIndex = 66;
            this.BT_Log_Out.Text = "Back";
            this.BT_Log_Out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_Log_Out.UseVisualStyleBackColor = true;
            this.BT_Log_Out.Click += new System.EventHandler(this.BT_Log_Out_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(30, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 65;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Bt_Pic
            // 
            this.Bt_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Bt_Pic.FlatAppearance.BorderSize = 0;
            this.Bt_Pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.L_Show.Location = new System.Drawing.Point(103, 9);
            this.L_Show.Name = "L_Show";
            this.L_Show.Size = new System.Drawing.Size(205, 100);
            this.L_Show.TabIndex = 63;
            this.L_Show.Text = "Restaurant \r\nManagement";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(156)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.Bt_To_Order);
            this.panel1.Location = new System.Drawing.Point(-4, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 763);
            this.panel1.TabIndex = 66;
            // 
            // Bt_To_Order
            // 
            this.Bt_To_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.Bt_To_Order.FlatAppearance.BorderSize = 0;
            this.Bt_To_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_To_Order.Font = new System.Drawing.Font("Andalus", 25.8F);
            this.Bt_To_Order.Image = ((System.Drawing.Image)(resources.GetObject("Bt_To_Order.Image")));
            this.Bt_To_Order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_To_Order.Location = new System.Drawing.Point(0, 4);
            this.Bt_To_Order.Name = "Bt_To_Order";
            this.Bt_To_Order.Size = new System.Drawing.Size(391, 117);
            this.Bt_To_Order.TabIndex = 67;
            this.Bt_To_Order.Text = "ORDER";
            this.Bt_To_Order.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Andalus", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(996, 758);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 67);
            this.button2.TabIndex = 68;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.BackColor = System.Drawing.Color.Lime;
            this.BT_Save.Font = new System.Drawing.Font("Andalus", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Save.ForeColor = System.Drawing.Color.White;
            this.BT_Save.Location = new System.Drawing.Point(1161, 759);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(120, 67);
            this.BT_Save.TabIndex = 67;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = false;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Name.Location = new System.Drawing.Point(879, 290);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(126, 46);
            this.L_Name.TabIndex = 69;
            this.L_Name.Text = "Name";
            // 
            // L_Price
            // 
            this.L_Price.AutoSize = true;
            this.L_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Price.Location = new System.Drawing.Point(886, 377);
            this.L_Price.Name = "L_Price";
            this.L_Price.Size = new System.Drawing.Size(112, 46);
            this.L_Price.TabIndex = 70;
            this.L_Price.Text = "Price";
            // 
            // Sh_N
            // 
            this.Sh_N.AutoSize = true;
            this.Sh_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Sh_N.Location = new System.Drawing.Point(1063, 290);
            this.Sh_N.Name = "Sh_N";
            this.Sh_N.Size = new System.Drawing.Size(0, 46);
            this.Sh_N.TabIndex = 71;
            // 
            // Sh_P
            // 
            this.Sh_P.AutoSize = true;
            this.Sh_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Sh_P.Location = new System.Drawing.Point(1063, 377);
            this.Sh_P.Name = "Sh_P";
            this.Sh_P.Size = new System.Drawing.Size(0, 46);
            this.Sh_P.TabIndex = 72;
            // 
            // Cus_Order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1293, 838);
            this.Controls.Add(this.Sh_P);
            this.Controls.Add(this.Sh_N);
            this.Controls.Add(this.L_Price);
            this.Controls.Add(this.L_Name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Da_Sh_Menu);
            this.Controls.Add(this.L_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cus_Order";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Da_Sh_Menu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Menu;
        private System.Windows.Forms.DataGridView Da_Sh_Menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Bt_Pic;
        private System.Windows.Forms.Label L_Show;
        private System.Windows.Forms.Button BT_Log_Out;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bt_To_Order;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Label L_Price;
        private System.Windows.Forms.Label Sh_N;
        private System.Windows.Forms.Label Sh_P;
    }
}

