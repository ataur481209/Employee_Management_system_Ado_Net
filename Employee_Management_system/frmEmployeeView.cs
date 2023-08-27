using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_system
{
    public partial class frmEmployeeView : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=employeeDetails;Trusted_Connection=True;");

        public frmEmployeeView()
        {
            InitializeComponent();
        }

        private void frmEmployeeView_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select e.employeeId,e.employeeName,e.contact,e.email,e.gender,e.picture,d.departmentName,e.joinDate from employee e inner join department d on e.departmentId=d.id", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
