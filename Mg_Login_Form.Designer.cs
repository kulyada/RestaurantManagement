
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
            this.L_Login = new System.Windows.Forms.Label();
            this.L_User = new System.Windows.Forms.Label();
            this.L_Pass = new System.Windows.Forms.Label();
            this.T_Pass = new System.Windows.Forms.TextBox();
            this.T_User = new System.Windows.Forms.TextBox();
            this.BT_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_Login
            // 
            this.L_Login.AutoSize = true;
            this.L_Login.Font = new System.Drawing.Font("AngsanaUPC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Login.Location = new System.Drawing.Point(12, 9);
            this.L_Login.Name = "L_Login";
            this.L_Login.Size = new System.Drawing.Size(605, 111);
            this.L_Login.TabIndex = 0;
            this.L_Login.Text = "Restaurant Management";
            // 
            // L_User
            // 
            this.L_User.AutoSize = true;
            this.L_User.Font = new System.Drawing.Font("AngsanaUPC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_User.Location = new System.Drawing.Point(596, 129);
            this.L_User.Name = "L_User";
            this.L_User.Size = new System.Drawing.Size(140, 66);
            this.L_User.TabIndex = 1;
            this.L_User.Text = "USER  :";
            // 
            // L_Pass
            // 
            this.L_Pass.AutoSize = true;
            this.L_Pass.Font = new System.Drawing.Font("AngsanaUPC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Pass.Location = new System.Drawing.Point(508, 202);
            this.L_Pass.Name = "L_Pass";
            this.L_Pass.Size = new System.Drawing.Size(228, 66);
            this.L_Pass.TabIndex = 2;
            this.L_Pass.Text = "PASSWORD :";
            // 
            // T_Pass
            // 
            this.T_Pass.Font = new System.Drawing.Font("AngsanaUPC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Pass.Location = new System.Drawing.Point(742, 203);
            this.T_Pass.Name = "T_Pass";
            this.T_Pass.Size = new System.Drawing.Size(215, 67);
            this.T_Pass.TabIndex = 4;
            this.T_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Pass_KeyPress);
            // 
            // T_User
            // 
            this.T_User.Font = new System.Drawing.Font("AngsanaUPC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_User.Location = new System.Drawing.Point(742, 130);
            this.T_User.Name = "T_User";
            this.T_User.Size = new System.Drawing.Size(215, 67);
            this.T_User.TabIndex = 3;
            this.T_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_User_KeyPress);
            // 
            // BT_Login
            // 
            this.BT_Login.Font = new System.Drawing.Font("AngsanaUPC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BT_Login.Location = new System.Drawing.Point(742, 276);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(215, 52);
            this.BT_Login.TabIndex = 5;
            this.BT_Login.Text = "LOG IN";
            this.BT_Login.UseVisualStyleBackColor = true;
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
            // 
            // Mg_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.BT_Login);
            this.Controls.Add(this.T_User);
            this.Controls.Add(this.T_Pass);
            this.Controls.Add(this.L_Pass);
            this.Controls.Add(this.L_User);
            this.Controls.Add(this.L_Login);
            this.Name = "Mg_Login_Form";
            this.Text = "Restaurant Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Login;
        private System.Windows.Forms.Label L_User;
        private System.Windows.Forms.Label L_Pass;
        private System.Windows.Forms.TextBox T_Pass;
        private System.Windows.Forms.TextBox T_User;
        private System.Windows.Forms.Button BT_Login;
    }
}