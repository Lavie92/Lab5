using Lab5.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class frmStudentManager : Form
    {
        
        public frmStudentManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentContext studentContext = new StudentContext();
            List<Student> listStudent = studentContext.Students.ToList();

            List<StudentReport> listReport = new List<StudentReport>();

            foreach (Student i in listStudent)
            {
                StudentReport temp = new StudentReport();
                temp.StudentID = i.StudentID;
                temp.StudentName = i.StudentName;
                temp.AverageScore = (float)i.AverageScore;
                temp.FacultyName = i.Faculty.FacultyName;
                listReport.Add(temp);
            }
            this.reportViewer1.LocalReport.ReportPath = "D:/TH_Winform/Lab5/Lab5/Lab5/rptStudentReport.rdlc";
            var reportDataSource = new ReportDataSource("StudentDataSet", listReport);
            this.reportViewer1.LocalReport.DataSources.Clear(); //clear
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
