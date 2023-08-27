using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_system
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void allDepartmentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment fd= new frmDepartment();
            fd.Show();
            fd.MdiParent= this; 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void employeeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeEntry fee = new frmEmployeeEntry();  
            fee.Show(); 
            fee.MdiParent= this;    
        }

        private void employeeUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeUpdateDelete fud = new frmEmployeeUpdateDelete();    
            fud.Show(); 
            fud.MdiParent= this;    
        }

        private void employeeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeView fv = new frmEmployeeView(); 
            fv.Show();  
            fv.MdiParent= this; 
        }
    }
}
