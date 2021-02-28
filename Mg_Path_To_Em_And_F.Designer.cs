
namespace RestaurantManagement
{
    partial class Mg_Path_To_Em_And_F
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
            this.BT_To_Em = new System.Windows.Forms.Button();
            this.BT_To_F = new System.Windows.Forms.Button();
            this.BT_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_To_Em
            // 
            this.BT_To_Em.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_To_Em.Location = new System.Drawing.Point(657, 271);
            this.BT_To_Em.Name = "BT_To_Em";
            this.BT_To_Em.Size = new System.Drawing.Size(393, 52);
            this.BT_To_Em.TabIndex = 0;
            this.BT_To_Em.Text = "Manage Registration";
            this.BT_To_Em.UseVisualStyleBackColor = true;
            this.BT_To_Em.Click += new System.EventHandler(this.BT_To_Em_Click);
            // 
            // BT_To_F
            // 
            this.BT_To_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.BT_To_F.Location = new System.Drawing.Point(657, 329);
            this.BT_To_F.Name = "BT_To_F";
            this.BT_To_F.Size = new System.Drawing.Size(393, 52);
            this.BT_To_F.TabIndex = 1;
            this.BT_To_F.Text = "Food Manage";
            this.BT_To_F.UseVisualStyleBackColor = true;
            this.BT_To_F.Click += new System.EventHandler(this.BT_To_F_Click);
            // 
            // BT_Logout
            // 
            this.BT_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Logout.Location = new System.Drawing.Point(835, 609);
            this.BT_Logout.Name = "BT_Logout";
            this.BT_Logout.Size = new System.Drawing.Size(215, 52);
            this.BT_Logout.TabIndex = 2;
            this.BT_Logout.Text = "LOG OUT";
            this.BT_Logout.UseVisualStyleBackColor = true;
            this.BT_Logout.Click += new System.EventHandler(this.BT_Logout_Click);
            // 
            // Mg_Parh_To_Em_And_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.BT_Logout);
            this.Controls.Add(this.BT_To_F);
            this.Controls.Add(this.BT_To_Em);
            this.Name = "Mg_Parh_To_Em_And_F";
            this.Text = "Restaurant Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_To_Em;
        private System.Windows.Forms.Button BT_To_F;
        private System.Windows.Forms.Button BT_Logout;
    }
}