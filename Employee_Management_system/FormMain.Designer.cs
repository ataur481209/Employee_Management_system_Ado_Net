namespace Employee_Management_system
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depertmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDepartmentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeUpdateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullEmployeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depertmentToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullEmployeeReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // depertmentToolStripMenuItem
            // 
            this.depertmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allDepartmentInformationToolStripMenuItem});
            this.depertmentToolStripMenuItem.Name = "depertmentToolStripMenuItem";
            this.depertmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.depertmentToolStripMenuItem.Text = "Depertment";
            // 
            // allDepartmentInformationToolStripMenuItem
            // 
            this.allDepartmentInformationToolStripMenuItem.Name = "allDepartmentInformationToolStripMenuItem";
            this.allDepartmentInformationToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.allDepartmentInformationToolStripMenuItem.Text = "All Department Information";
            this.allDepartmentInformationToolStripMenuItem.Click += new System.EventHandler(this.allDepartmentInformationToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeEntryToolStripMenuItem,
            this.employeeUpdateDeleteToolStripMenuItem,
            this.employeeViewToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // employeeEntryToolStripMenuItem
            // 
            this.employeeEntryToolStripMenuItem.Name = "employeeEntryToolStripMenuItem";
            this.employeeEntryToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.employeeEntryToolStripMenuItem.Text = "Employee Entry";
            this.employeeEntryToolStripMenuItem.Click += new System.EventHandler(this.employeeEntryToolStripMenuItem_Click);
            // 
            // employeeUpdateDeleteToolStripMenuItem
            // 
            this.employeeUpdateDeleteToolStripMenuItem.Name = "employeeUpdateDeleteToolStripMenuItem";
            this.employeeUpdateDeleteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.employeeUpdateDeleteToolStripMenuItem.Text = "Employee Update/Delete";
            this.employeeUpdateDeleteToolStripMenuItem.Click += new System.EventHandler(this.employeeUpdateDeleteToolStripMenuItem_Click);
            // 
            // employeeViewToolStripMenuItem
            // 
            this.employeeViewToolStripMenuItem.Name = "employeeViewToolStripMenuItem";
            this.employeeViewToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.employeeViewToolStripMenuItem.Text = "Employee View";
            this.employeeViewToolStripMenuItem.Click += new System.EventHandler(this.employeeViewToolStripMenuItem_Click);
            // 
            // fullEmployeeReportToolStripMenuItem
            // 
            this.fullEmployeeReportToolStripMenuItem.Name = "fullEmployeeReportToolStripMenuItem";
            this.fullEmployeeReportToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.fullEmployeeReportToolStripMenuItem.Text = "Full Employee report";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depertmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDepartmentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeUpdateDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullEmployeeReportToolStripMenuItem;
    }
}

