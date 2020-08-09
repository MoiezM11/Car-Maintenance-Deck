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
    public partial class LogScreen : Form
    {
        public string u_id;
        public string v_id;
        public LogScreen(string UserName,string vehicle_no)
        {
            InitializeComponent();
            u_id = UserName;
            v_id = vehicle_no;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string serviced_part = comboBox1.selectedValue;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["WheelsOnCharge"].ConnectionString;
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select CNIC from tbl_user where Email ='" + u_id + "'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            string user_id = dt.Rows[0][0].ToString();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_maintenance", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //calling stored Procedures
                cmd.Parameters.Add("@userid", SqlDbType.NVarChar).Value = user_id;
                cmd.Parameters.Add("@vehicleno", SqlDbType.NVarChar).Value = v_id;
                cmd.Parameters.Add("@date", SqlDbType.NVarChar).Value = Date;
                cmd.Parameters.Add("@hmmmm", SqlDbType.NVarChar).Value = "[" + serviced_part + "]";
                cmd.ExecuteNonQuery();
                con.Close();
                con.Dispose();
                MessageBox.Show("Log Entered Sccessfully!!!", "Logs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Screen3 s3 = new Screen3(u_id);
                s3.Show();
            }
            catch
            {
                MessageBox.Show("Error in entering logs", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screen3 s3 = new Screen3(u_id);
            s3.Show();
        }
    }
}
