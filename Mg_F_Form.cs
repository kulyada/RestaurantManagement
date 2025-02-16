﻿using System;
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
    public partial class Mg_F_Form : Form
    {
        Form formPath;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\RestaurantManagement\Deltafood.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter dataF;
        DataTable Food = new DataTable();
        OpenFileDialog open;
        string imageUrl = null;
        public Mg_F_Form(Form formpath)
        {
            InitializeComponent();
            formPath = formpath;
            Display();
        }
        private void Display()
        {
            con.Open();
            DataTable dt = new DataTable();
            dataF = new SqlDataAdapter("SELECT F_ID,F_Name,F_Price,F_Pic,TF_Name FROM Food F,TypeFood TyFd WHERE F.TF_ID=TyFd.TF_ID AND F_Status=1", con);
            dataF.Fill(dt);
            Sh_F_Data.DataSource = dt;
            con.Close();
            Sh_F_Data.DataSource = Food;
            Sh_F_Data.Columns["F_ID"].HeaderText = "Food ID";
            Sh_F_Data.Columns["F_Name"].HeaderText = "Name";
            Sh_F_Data.Columns["F_Price"].HeaderText = "Price";
            Sh_F_Data.Columns["F_Pic"].HeaderText = "Picture";
            Sh_F_Data.Columns["TF_Name"].HeaderText = "Kind";
        }
        private void Mg_F_Form_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM TypeFood", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable typefood = new DataTable();
            typefood.Columns.Add("TypeFood", typeof(string));
            typefood.Load(reader);
            Co_TFood.ValueMember = "TF_Name";
            Co_TFood.DataSource = typefood;
            con.Close();
        }

        private void Sh_F_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = Sh_F_Data.Rows[e.RowIndex];
                T_FName.Text = row.Cells["F_Name"].Value.ToString();
                T_FPrice.Text = row.Cells["F_Price"].Value.ToString();
                Co_TFood.Text = row.Cells["TF_Name"].Value.ToString();
            }
        }

        private void BT_UpLoadPic_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                P_Food.Image = new Bitmap(open.FileName);
                imageUrl = open.FileName;
                P_Food.SizeMode = PictureBoxSizeMode.CenterImage;
                P_Food.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void T_FPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void BT_Save_Click(object sender, EventArgs e)
        {
            Image image = P_Food.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr =(byte[])converter.ConvertTo(image,typeof(byte[]));

            con.Open();
            cmd = new SqlCommand("INSERT INTO Food(F_Name,F_Price,F_Pic,F_PicUrl,F_Status,TF_ID) VALUES(@name,@price,@photo,@photourl,1,(SELECT TF_ID FROM TypeFood WHERE TF_Name = @tfid))", con);
            cmd.Parameters.AddWithValue("@name", T_FName.Text);
            cmd.Parameters.AddWithValue("@price", T_FPrice.Text);
            cmd.Parameters.AddWithValue("@photo", arr);
            cmd.Parameters.AddWithValue("@photourl", imageUrl);
            cmd.Parameters.AddWithValue("@tfid", Co_TFood.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Save Success!!");
            Sh_F_Data.DataSource = null;
            Display();
        }

        private void BT_Clear_Click_1(object sender, EventArgs e)
        {
            TextBox txt = default(TextBox);
            foreach (Control ctl in this.Controls)
            {
                if (object.ReferenceEquals(ctl.GetType(), typeof(TextBox)))
                {
                    txt = (TextBox)ctl;
                    txt.Text = null;
                }
            }
            P_Food.Image = null;
        }

        private void BT_Log_Out_Click_1(object sender, EventArgs e)
        {
            formPath.Show();
            Close();
        }

        private void Bt_Refresh_Click(object sender, EventArgs e)
        {
            Sh_F_Data.DataSource = null;
            Sh_F_Data.Update();
            Sh_F_Data.Refresh();
            Display();
        }
    }
}
