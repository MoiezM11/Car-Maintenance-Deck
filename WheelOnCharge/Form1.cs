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
using System.Configuration;

namespace WheelOnCharge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }
        public string user_email;
        private void button1_Click(object sender, EventArgs e)
        {
            user_email= login_email.Text;
            string pass = login_password.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["WheelsOnCharge"].ConnectionString;
            SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from tbl_user where email ='" + user_email + "' and password ='" + pass + "'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Welcome!!!", "login Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Screen3 f3 = new Screen3(user_email);
                this.Hide();
                f3.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect!!!", "Login Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void login_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
