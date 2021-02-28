using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
namespace RestaurantManagement
{
    public partial class Mg_Login_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\RestaurantManagement\Deltafood.mdf;Integrated Security=True;Connect Timeout=30");
        public Mg_Login_Form()
        {
            InitializeComponent();
            T_User.MaxLength = 6;
            T_Pass.PasswordChar = '*';
            T_Pass.MaxLength = 6;
        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Em_User,Em_Password FROM Employee WHERE Em_User='" + T_User.Text.Trim() + "'AND Em_Password = '" + T_Pass.Text.Trim() + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable lgin = new DataTable();
            da.Fill(lgin);
            if (lgin.Rows.Count == 1)
            {
                Mg_Path_To_Em_And_F mg_Path_To_Em_And_F = new Mg_Path_To_Em_And_F(this);
                mg_Path_To_Em_And_F.Show();
                Hide();
                T_User.Text = T_Pass.Text = null;

            }
            else
            {
                MessageBox.Show("Check Your User And Password", "WARNING!!", MessageBoxButtons.OK);
                T_User.Text = T_Pass.Text = null;
            }
        }

        private void T_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void T_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
