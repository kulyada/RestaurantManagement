
namespace RestaurantManagement
{
    partial class Mg_Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mg_Login_Form));
            this.L_Pass = new System.Windows.Forms.Label();
            this.T_Pass = new System.Windows.Forms.TextBox();
            this.BT_Login = new System.Windows.Forms.Button();
            this.Bt_Pic = new System.Windows.Forms.Button();
            this.L_Show = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_Pass
            // 
            this.L_Pass.AutoSize = true;
            this.L_Pass.Font = new System.Drawing.Font("Andalus", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Pass.Location = new System.Drawing.Point(926, 168);
            this.L_Pass.Name = "L_Pass";
            this.L_Pass.Size = new System.Drawing.Size(213, 58);
            this.L_Pass.TabIndex = 2;
            this.L_Pass.Text = "PASSWORD";
            // 
            // T_Pass
            // 
            this.T_Pass.Font = new System.Drawing.Font("AngsanaUPC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Pass.Location = new System.Drawing.Point(936, 255);
            this.T_Pass.Name = "T_Pass";
            this.T_Pass.Size = new System.Drawing.Size(203, 67);
            this.T_Pass.TabIndex = 4;
            this.T_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Pass_KeyPress);
            // 
            // BT_Login
            // 
            this.BT_Login.BackColor = System.Drawing.SystemColors.Highlight;
            this.BT_Login.FlatAppearance.BorderSize = 0;
            this.BT_Login.Font = new System.Drawing.Font("Andalus", 19.8F);
            this.BT_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BT_Login.Location = new System.Drawing.Point(969, 354);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(139, 52);
            this.BT_Login.TabIndex = 5;
            this.BT_Login.Text = "LOG IN";
            this.BT_Login.UseVisualStyleBackColor = false;
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
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
            this.panel2.Controls.Add(this.Bt_Pic);
            this.panel2.Controls.Add(this.L_Show);
            this.panel2.Location = new System.Drawing.Point(-10, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1290, 120);
            this.panel2.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Andalus", 19.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1111, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 52);
            this.button1.TabIndex = 64;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mg_Login_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BT_Login);
            this.Controls.Add(this.T_Pass);
            this.Controls.Add(this.L_Pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mg_Login_Form";
            this.Text = "Restaurant Management";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label L_Pass;
        private System.Windows.Forms.TextBox T_Pass;
        private System.Windows.Forms.Button BT_Login;
        private System.Windows.Forms.Button Bt_Pic;
        private System.Windows.Forms.Label L_Show;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}