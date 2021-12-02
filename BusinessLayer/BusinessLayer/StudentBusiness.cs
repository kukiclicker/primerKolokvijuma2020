using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBusiness
    {
        private readonly StudentRepository studentRepository;

        public StudentBusiness()
        {
            this.studentRepository = new StudentRepository();
        }
        public List<Student> students()
        {
            return this.studentRepository.GetAllStudents();
        }
        public bool InsertStudent(Student s)
        {
            if(this.studentRepository.InsertStudent(s)>0)
            {
                return true; 
            }
            else { return false; }
        }
        public List<Student> GetStudentsGTAvg(decimal avgMark)
        {
            
            return this.studentRepository.GetAllStudents().Where(s=>s.AverageMark>avgMark).ToList();
            
            
        }
    }
}
