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
using System.Collections;
namespace RestaurantManagement
{
    public partial class Cus_Order : Form
    {
        Form formPath;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\งาน\RestaurantManagement\Deltafood.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter datafood;
        DataTable menufood = new DataTable();
        public Cus_Order(Form formpath)
        {
            InitializeComponent();
            formPath = formpath;
            con.Open();
            DataTable dt = new DataTable();
            datafood = new SqlDataAdapter("SELECT F_Name,F_Price,F_Pic,TF_Name FROM Food F,TypeFood TyFd WHERE F.TF_ID=TyFd.TF_ID AND F_Status=1", con);
            datafood.Fill(dt);
            Da_Sh_Menu.DataSource = dt;
            con.Close();
            Da_Sh_Menu.Columns["F_Name"].HeaderText = "ชื่ออาหาร";
            Da_Sh_Menu.Columns["F_Price"].HeaderText = "ราคา";
            Da_Sh_Menu.Columns["F_Pic"].HeaderText = "รูปภาพ";
            Da_Sh_Menu.Columns["TF_Name"].HeaderText = "ประเภท";
        }

        private void Da_Sh_Menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = Da_Sh_Menu.Rows[e.RowIndex];
                Sh_N.Text = row.Cells["F_Name"].Value.ToString();
                Sh_P.Text = row.Cells["F_Price"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sh_N.Text = Sh_P.Text = "";
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            float p = Convert.ToInt32(Sh_P.Text);
            con.Open();
            cmd = new SqlCommand("INSERT INTO Ordered(O_Total,O_Status,F_ID) VALUES(@t,1,(SELECT F_ID FROM Food WHERE F_Name = @fn))", con);
            cmd.Parameters.AddWithValue("@t", p);
            cmd.Parameters.AddWithValue("@fn", Sh_N.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Save Success!!");
            con.Close();
        }

        private void BT_Log_Out_Click(object sender, EventArgs e)
        {
            formPath.Show();
            Close();
        }
    }
}
