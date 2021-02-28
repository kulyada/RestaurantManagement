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
        DataTable Employ = new DataTable();
        public Mg_Em_From(Form formpath)
        {
            InitializeComponent();
            T_IDNum.MaxLength = 13;
            T_Tel.MaxLength = 10;
            formPath = formpath;
            using (cmd = new SqlCommand("SELECT Em_ID,Em_IDNum , Em_Name , Em_SurName , Em_Gender , Em_Birthday , Em_Address , Em_Nationality  , Em_Tel , Em_Salary , Em_Email ,D_Name FROM Employee Em,Department Dept WHERE Em.D_ID=Dept.D_ID AND Em_Status=1", con))
            {
                using (dataEm = new SqlDataAdapter(cmd))
                {
                    dataEm.Fill(Employ);
                }
            }
            Sh_Em_Data.DataSource = Employ;
            //Rename Header Columns in Datagridview(Sh_Em_Data)
            Sh_Em_Data.Columns["Em_ID"].HeaderText = "Employee ID";
            Sh_Em_Data.Columns["Em_IDNum"].HeaderText = "Identification NO.";
            Sh_Em_Data.Columns["Em_Name"].HeaderText = "Name";
            Sh_Em_Data.Columns["Em_SurName"].HeaderText = "Surname";
            Sh_Em_Data.Columns["Em_Gender"].HeaderText = "Gender";
            Sh_Em_Data.Columns["Em_Birthday"].HeaderText = "Date Of Birth";
            Sh_Em_Data.Columns["Em_Birthday"].DefaultCellStyle.Format = "dd/MM/yyyy";
            Sh_Em_Data.Columns["Em_Address"].HeaderText = "Address";
            Sh_Em_Data.Columns["Em_Nationality"].HeaderText = "Nationality";
            Sh_Em_Data.Columns["Em_Tel"].HeaderText = "tel";
            Sh_Em_Data.Columns["Em_Salary"].HeaderText = "Salary";
            Sh_Em_Data.Columns["Em_Email"].HeaderText = "E-Mail";
            Sh_Em_Data.Columns["D_name"].HeaderText = "Department";
            // ComboBox
            gender.Add("Male");
            gender.Add("Female");
            Co_Gender.DataSource = gender;
        }

        private void Mg_Em_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Department", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable depart = new DataTable();
            depart.Columns.Add("Department", typeof(string));
            depart.Columns.Add("D_ID", typeof(string));
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
            Random ran = new Random();
            StringBuilder passran = new StringBuilder();
            passran.Append(ran.Next(000000, 999999).ToString());
            DateTime today = DateTime.Now;
            con.Open();
            cmd = new SqlCommand("INSERT INTO Employee(Em_IDNum , Em_Name , Em_SurName , Em_Gender , Em_Birthday , Em_Address , Em_Nationality  , Em_Tel , Em_Salary , Em_Email, Em_Starting_Date , Em_Password)" +
                                 " VALUES(@Em_IDNum , @Em_Name , @Em_SurName , @Em_Gender , @Em_Birthday , @Em_Address , @Em_Nationality  , @Em_Tel , @Em_Salary , @Em_Email ,@Em_Starting_Date , @Em_Password)", con);
            cmd.Parameters.Add("@Em_IDNum", T_IDNum.Text);
            cmd.Parameters.Add("@Em_Name", T_Name.Text);
            cmd.Parameters.Add("@Em_SurName", T_Surname);
            cmd.Parameters.Add("@Em_Gender", Co_Gender.Items.ToString());
            cmd.Parameters.Add("@Em_Birthday", T_Birth.Text);
            cmd.Parameters.Add("@Em_Address", T_Adress.Text);
            cmd.Parameters.Add("@Em_Nationality", T_Nation.Text);
            cmd.Parameters.Add("@Em_Tel", T_Tel.Text);
            cmd.Parameters.Add("@Em_Salary", T_Salary.Text);
            cmd.Parameters.Add("@Em_Email", T_Email.Text);
            cmd.Parameters.Add("@Em_Starting_Date", today.ToString("dd/MM/yyyy"));
            cmd.Parameters.Add("@Em_Password", passran);
            con.Close();
           
        }
        private Boolean VerifyIDNum(String Idnum)
        {
            int sumValue = 0;
            for (int i = 0; i < Idnum.Length - 1; i++)
            { 
                sumValue += int.Parse(Idnum.ToString()) * (13 - i);
            }
            int v = 11 - (sumValue % 11);
            return Idnum[12].ToString() == v.ToString();
        }

        private void T_IDNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && T_IDNum.Text.Length != 13)
            {
                e.Handled = true; 
            }
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
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            formPath.Show();
            Close();
        }

        private void Sh_Em_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = Sh_Em_Data.Rows[e.RowIndex];
                T_IDNum.Text = row.Cells["Em_IDNum"].Value.ToString();
                T_Name.Text = row.Cells["Em_Name"].Value.ToString();
                T_Surname.Text = row.Cells["Em_SurName"].Value.ToString();
                Co_Gender.Text = row.Cells["Em_Gender"].Value.ToString();
                T_Birth.Text = Convert.ToDateTime(Employ.Rows[e.RowIndex]["Em_Birthday"]).ToString("dd/MM/yyyy");
                T_Adress.Text = row.Cells["Em_Address"].Value.ToString();
                T_Nation.Text = row.Cells["Em_Nationality"].Value.ToString();
                T_Tel.Text = row.Cells["Em_Tel"].Value.ToString();
                T_Salary.Text = row.Cells["Em_Salary"].Value.ToString();
                Co_Depart.Text = row.Cells["D_Name"].Value.ToString();
            }
        }

        private void T_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back )
            {
                e.Handled = true;
            }
        }
    }
}
