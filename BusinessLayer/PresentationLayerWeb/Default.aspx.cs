using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayerWeb
{
    public partial class _Default : Page
    {
        private  StudentBusiness studentBusiness;
        public _Default()
        {
            this.studentBusiness = new StudentBusiness();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Student> student = this.studentBusiness.students();

            foreach (Student s in student)
            {
                listBoxStudents.Items.Add(s.Id + ". " + s.Name + " (" + s.IndexNumber + ") -" + s.AverageMark);
            }
        }
    }
}