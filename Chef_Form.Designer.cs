
namespace RestaurantManagement
{
    partial class Chef_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chef_Form));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_Log_Out = new System.Windows.Forms.Button();
            this.Bt_Pic = new System.Windows.Forms.Button();
            this.L_Show = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bt_to_Chef = new System.Windows.Forms.Button();
            this.Sh_Ordered = new System.Windows.Forms.DataGridView();
            this.Bt_Clear = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sh_Ordered)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.BT_Log_Out);
            this.panel2.Controls.Add(this.Bt_Pic);
            this.panel2.Controls.Add(this.L_Show);
            this.panel2.Location = new System.Drawing.Point(-31, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1342, 134);
            this.panel2.TabIndex = 63;
            // 
            // BT_Log_Out
            // 
            this.BT_Log_Out.FlatAppearance.BorderSize = 0;
            this.BT_Log_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Log_Out.Font = new System.Drawing.Font("Andalus", 18F);
            this.BT_Log_Out.Image = ((System.Drawing.Image)(resources.GetObject("BT_Log_Out.Image")));
            this.BT_Log_Out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Log_Out.Location = new System.Drawing.Point(1170, 28);
            this.BT_Log_Out.Name = "BT_Log_Out";
            this.BT_Log_Out.Size = new System.Drawing.Size(120, 80);
            this.BT_Log_Out.TabIndex = 64;
            this.BT_Log_Out.Text = "Back";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(156)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.Bt_to_Chef);
            this.panel1.Location = new System.Drawing.Point(-2, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 770);
            this.panel1.TabIndex = 66;
            // 
            // Bt_to_Chef
            // 
            this.Bt_to_Chef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.Bt_to_Chef.FlatAppearance.BorderSize = 0;
            this.Bt_to_Chef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_to_Chef.Font = new System.Drawing.Font("Andalus", 25.8F);
            this.Bt_to_Chef.Image = ((System.Drawing.Image)(resources.GetObject("Bt_to_Chef.Image")));
            this.Bt_to_Chef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_to_Chef.Location = new System.Drawing.Point(0, 13);
            this.Bt_to_Chef.Name = "Bt_to_Chef";
            this.Bt_to_Chef.Size = new System.Drawing.Size(273, 117);
            this.Bt_to_Chef.TabIndex = 64;
            this.Bt_to_Chef.Text = "CHEF";
            this.Bt_to_Chef.UseVisualStyleBackColor = false;
            // 
            // Sh_Ordered
            // 
            this.Sh_Ordered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sh_Ordered.Location = new System.Drawing.Point(277, 132);
            this.Sh_Ordered.Name = "Sh_Ordered";
            this.Sh_Ordered.RowHeadersWidth = 51;
            this.Sh_Ordered.RowTemplate.Height = 24;
            this.Sh_Ordered.Size = new System.Drawing.Size(991, 420);
            this.Sh_Ordered.TabIndex = 67;
            this.Sh_Ordered.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sh_Ordered_CellClick);
            // 
            // Bt_Clear
            // 
            this.Bt_Clear.FlatAppearance.BorderSize = 0;
            this.Bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Clear.Font = new System.Drawing.Font("Andalus", 25.8F);
            this.Bt_Clear.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Clear.Image")));
            this.Bt_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_Clear.Location = new System.Drawing.Point(1102, 558);
            this.Bt_Clear.Name = "Bt_Clear";
            this.Bt_Clear.Size = new System.Drawing.Size(166, 60);
            this.Bt_Clear.TabIndex = 68;
            this.Bt_Clear.Text = "Clear";
            this.Bt_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bt_Clear.UseVisualStyleBackColor = true;
            this.Bt_Clear.Click += new System.EventHandler(this.Bt_Clear_Click);
            // 
            // Chef_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Bt_Clear);
            this.Controls.Add(this.Sh_Ordered);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chef_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chef_Form";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sh_Ordered)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_Log_Out;
        private System.Windows.Forms.Button Bt_Pic;
        private System.Windows.Forms.Label L_Show;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bt_to_Chef;
        private System.Windows.Forms.DataGridView Sh_Ordered;
        private System.Windows.Forms.Button Bt_Clear;
    }
}