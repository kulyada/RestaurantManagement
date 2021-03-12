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
using System.Configuration;
namespace RestaurantManagement
{
    public partial class Mg_Em_From : Form
    {
        Form formPath;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\RestaurantManagement\Deltafood.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter dataEm;
        ArrayList gender = new ArrayList();
        ArrayList status = new ArrayList();
        DataTable Employ = new DataTable();
        public Mg_Em_From(Form formpath)
        {
            InitializeComponent();
            formPath = formpath;
            Display();
            //Add Status in ComboBox
            status.Add("Work");
            status.Add("Resigned");
            Co_Status.DataSource = status;
        }
         public void Display()
        {
            con.Open();
            DataTable dt = new DataTable();
            dataEm = new SqlDataAdapter("SELECT Em_ID, Em_Name , Em_SurName ,Em_Password,D_Name FROM Employee Em,Department Dept WHERE Em.D_ID=Dept.D_ID AND Em_Status=1", con);
            dataEm.Fill(dt);
            Sh_Em_Data.DataSource = dt;
            con.Close();
            //Rename Header Columns in Datagridview(Sh_Em_Data)
            Sh_Em_Data.Columns["Em_ID"].HeaderText = "Employee ID";
            Sh_Em_Data.Columns["Em_Name"].HeaderText = "Name";
            Sh_Em_Data.Columns["Em_SurName"].HeaderText = "Surname";
            Sh_Em_Data.Columns["Em_Password"].HeaderText = "Password";
            Sh_Em_Data.Columns["D_name"].HeaderText = "Department";
        }

        private void Mg_Em_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Department", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable depart = new DataTable();
            depart.Columns.Add("Department", typeof(string));
            depart.Load(reader);
            Co_Depart.ValueMember = "D_Name";
            Co_Depart.DataSource = depart;
            con.Close();
            //
            con.Open();
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            DataTable depart1 = new DataTable();
            depart1.Columns.Add("Department", typeof(string));
            depart1.Load(reader1);
            Co_Sl_Depart.ValueMember = "D_Name";
            Co_Sl_Depart.DataSource = depart1;
            con.Close();
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            //Randon Password
            Random ran = new Random();
            StringBuilder passran = new StringBuilder();
            passran.Append(ran.Next(000000, 999999).ToString());
            //Insert Data
            string DatEm = "INSERT INTO Employee(Em_Name , Em_SurName ,Em_Password,Em_Status,D_ID)" +
                           "VALUES('" + T_Name.Text.ToString() + "' ,'" + T_Surname.Text.ToString() + "','" + passran.ToString() + "', 1 ,(SELECT D_ID FROM Department WHERE D_Name = '" + Co_Depart.SelectedValue.ToString() + "'))";
            con.Open();
            if (T_Name.Text != "" && T_Surname.Text != "")
            {
                cmd = new SqlCommand(DatEm, con);
                MessageBox.Show("Password : " + passran.ToString(), "Save Success!!", MessageBoxButtons.OK);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Please Input", "WARNING!!", MessageBoxButtons.OK);
            }
            con.Close();
            Display();
        }

        private void BT_Clear_Click(object sender, EventArgs e)
        {
            TextBox txt = default(TextBox);
            foreach(Control ctl in this.Controls)
            {
                if(object.ReferenceEquals(ctl.GetType(),typeof(TextBox)))
                {
                    txt = (TextBox)ctl;
                    txt.Text = null;
                }
            }
            L_Sh_Em_ID.Text = "";
        }


        private void Sh_Em_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = Sh_Em_Data.Rows[e.RowIndex];
                L_Sh_Em_ID.Text = row.Cells["Em_ID"].Value.ToString();
                T_Name.Text = row.Cells["Em_Name"].Value.ToString();
                T_Surname.Text = row.Cells["Em_SurName"].Value.ToString();
                Co_Depart.Text = row.Cells["D_Name"].Value.ToString();
            }
        }

        private void BT_Update_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE Employee SET Em_Name =@name, Em_SurName=@surname,(SELECT D_ID FROM Department WHERE D_Name = @depart) WHERE Em_ID =@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", L_Sh_Em_ID.Text.ToString());
            cmd.Parameters.AddWithValue("@name", T_Name.Text.ToString());
            cmd.Parameters.AddWithValue("@surname", T_Surname.Text.ToString());
            cmd.Parameters.AddWithValue("@depart", Co_Depart.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();
            Display();
            /*using (cmd=new SqlCommand("UPDATE Employee SET Em_Name ='" + T_Name.Text.ToString() + "' , Em_SurName='" + T_Surname.Text.ToString() + "',(SELECT D_ID FROM Department WHERE D_Name = '" + Co_Depart.SelectedValue.ToString() + "') WHERE Em_ID ='" + L_Sh_Em_ID.Text.ToString() + "'",con))
            {
                MessageBox.Show("Update Success!!");
            }
            if (Co_Status.SelectedItem.ToString() == "Resigned")
            {
                cmd = new SqlCommand("UPDATE Employee SET Em_Status = 0 WHERE Em_ID ='" + L_Sh_Em_ID.Text.ToString() + "'",con);
            }*/
        }

        private void BT_Log_Out_Click(object sender, EventArgs e)
        {
            formPath.Show();
            Close();
        }

        private void Bt_Refresh_Click(object sender, EventArgs e)
        {
         /*   Sh_Em_Data.DataSource = null;
            Sh_Em_Data.Update();
            Sh_Em_Data.Refresh();
            Display();*/
        }
    }
}
