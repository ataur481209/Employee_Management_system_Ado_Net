using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_system
{
    public partial class frmEmployeeUpdateDelete : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=employeeDetails;Trusted_Connection=True;");

        public frmEmployeeUpdateDelete()
        {
            InitializeComponent();
        }

        private void frmEmployeeUpdateDelete_Load(object sender, EventArgs e)
        {
            LoadSubject();
        }
        private void LoadSubject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select id,departmentName from department";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbDepertment.DataSource = ds.Tables[0];
            cmbDepertment.DisplayMember = "departmentName";
           cmbDepertment.ValueMember = "id";
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select employeeId,employeeName,contact,email,gender,picture,departmentId,joinDate from employee where employeeId=@i";
            cmd.Parameters.AddWithValue("@i", txtSearch.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0][1].ToString();
                txtContact.Text = dt.Rows[0][2].ToString();
                txtEmail.Text = dt.Rows[0][3].ToString();
                cmbDepertment.SelectedValue = dt.Rows[0][6].ToString();
                dateTimePicker1.Text = dt.Rows[0][7].ToString();
                //chkGender.Text = dt.Rows[0][7].ToString();
                string genderStatus = dt.Rows[0][4].ToString();
                if (genderStatus == "True")
                {
                    chkGender.Checked = true;
                }
                else
                {
                    chkGender.Checked = false;
                }
                MemoryStream ms = new MemoryStream((byte[])dt.Rows[0][5]);
                Image img = Image.FromStream(ms);
                pictureBox1.Image = img;

            }
            con.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicture.Text = openFileDialog1.FileName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPicture.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);


            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE employee SET employeeName=@n,contact=@c,email=@e,gender=@g,picture=@p,departmentId=@d,joinDate=@j WHERE employeeId=@i";
            cmd.Parameters.AddWithValue("@i", txtSearch.Text);
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@c", txtContact.Text);
            cmd.Parameters.AddWithValue("@e", txtEmail.Text);
            cmd.Parameters.AddWithValue("@j", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@g", chkGender.Checked.ToString());

            cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary) { Value = ms.ToArray() });
            cmd.Parameters.AddWithValue("@d", cmbDepertment.SelectedValue);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Updated successfully!!!";
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from employee WHERE employeeId=@i";
            cmd.Parameters.AddWithValue("@i", txtSearch.Text);

            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Deleted successfully!!!";
            con.Close();
        }
    }
}
