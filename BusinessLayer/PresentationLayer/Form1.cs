using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly StudentBusiness studentBusiness;

        public Form1()
        {
            this.studentBusiness = new StudentBusiness();
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.IndexNumber = textBoxIndex.Text;
            s.Name = textBoxName.Text;
            s.AverageMark = Convert.ToDecimal(textBoxAverageMark.Text);

            this.studentBusiness.InsertStudent(s);
            RefreshData();

        }
        public void RefreshData()
        {
            List<Student> student = this.studentBusiness.students();
            
            foreach(Student s in student)
            {
                listBoxStudents.Items.Add(s.Id + ". " + s.Name + " (" + s.IndexNumber + ") -" + s.AverageMark);
            }
        }
    }
}
