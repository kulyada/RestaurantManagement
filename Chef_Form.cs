using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace RestaurantManagement
{
    public partial class Chef_Form : Form
    {
        string id;
        Form formPath;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\งาน\RestaurantManagement\Deltafood.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter deltaMenu;
        public Chef_Form(Form Formpath)
        {
            InitializeComponent();
            formPath = Formpath;
            display();
        }
        private void display()
        {
            con.Open();
            DataTable dt = new DataTable();
            deltaMenu = new SqlDataAdapter("SELECT O_ID,F_Name FROM Food f,Ordered o WHERE f.F_ID=o.F_ID AND O_Status = 1", con);
            deltaMenu.Fill(dt);
            Sh_Ordered.DataSource = dt;
            con.Close();
            Sh_Ordered.Columns["O_ID"].HeaderText = "Order ID";
            Sh_Ordered.Columns["F_Name"].HeaderText = "Food Name";
        }

        private void BT_Log_Out_Click(object sender, EventArgs e)
        {
            formPath.Show();
            Close();
        }

        private void Sh_Ordered_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = Sh_Ordered.Rows[e.RowIndex];
                id = row.Cells["O_ID"].Value.ToString();
            }
        }

        private void Bt_Clear_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE Ordered SET O_status = 0 WHERE O_ID = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
            display(); 
        }
    }
}
