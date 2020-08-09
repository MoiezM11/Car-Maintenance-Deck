using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WheelOnCharge
{
    public partial class EnterVehicle : Form
    {
        public string  u_id;
        public EnterVehicle(string userid)
        {
            InitializeComponent();
            u_id = userid;
        }

        private void EnterVehicle_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string no = v_no.Text;
            string name = v_name.Text;
            //string user_id = u_id;
            string model = v_model.Text;
            string type = v_type.selectedValue;      // combobox
            string colour = u_colour.Text;
            string LicenseIssuDate = v_LIssuDate.Value.ToString("yyyy-MM-dd");
            string LicenseNo = vL_no.Text;
            string LicenseExpiryDate = L_expiryDate.Value.ToString("yyyy-MM-dd");
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["WheelsOnCharge"].ConnectionString;
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select CNIC from tbl_user where Email ='" + u_id + "'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            string user_id = dt.Rows[0][0].ToString();
            if (no != null && name != null && user_id != null && model != null && type != null && colour != null && LicenseNo != null && LicenseIssuDate != null && LicenseExpiryDate != null)
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_VehicleDails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //calling stored Procedures
                    cmd.Parameters.Add("@u_id", SqlDbType.NVarChar).Value = user_id;
                    cmd.Parameters.Add("@v_no", SqlDbType.NVarChar).Value = no;
                    cmd.Parameters.Add("@v_name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@v_model", SqlDbType.NVarChar).Value = model;
                    cmd.Parameters.Add("@v_colour", SqlDbType.NVarChar).Value = colour;
                    cmd.Parameters.Add("@v_type", SqlDbType.NVarChar).Value = type;
                    cmd.Parameters.Add("@License_no", SqlDbType.NVarChar).Value = LicenseNo;
                    cmd.Parameters.Add("@License_DOI", SqlDbType.NVarChar).Value = LicenseIssuDate;
                    cmd.Parameters.Add("@License_DOE", SqlDbType.NVarChar).Value = LicenseExpiryDate;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    MessageBox.Show("Vehicle added Sccessfully!!!", "Logs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Screen3 s3 = new Screen3(u_id);
                    s3.Show();

                }
                catch
                {
                    MessageBox.Show("Error was encountered while adding vehicle! contact Database Admin!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Some Fields are empty", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screen3 S3 = new Screen3(u_id);
            S3.Show();
        }
    }
}
