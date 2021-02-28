using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class Mg_Path_To_Em_And_F : Form
    {
        Form formLog;
        public Mg_Path_To_Em_And_F(Form formlog_in)
        {
            InitializeComponent();
            formLog = formlog_in;
        }

        private void BT_To_Em_Click(object sender, EventArgs e)
        {
            Mg_Em_From mg_Em_From = new Mg_Em_From(this);
            Hide();
            mg_Em_From.Show();
        }

        private void BT_To_F_Click(object sender, EventArgs e)
        {
            Mg_F_Form mg_F_Form = new Mg_F_Form(this);
            Hide();
            mg_F_Form.Show();
        }

        private void BT_Logout_Click(object sender, EventArgs e)
        {
            formLog.Show();
            Close();
        }
    }
}
