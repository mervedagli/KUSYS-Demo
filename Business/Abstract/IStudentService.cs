using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        void DeleteStudent(Student student);    
        void UpdateStudent(Student student);
        List<Student> GetAllStudents(); 
        List<Student> GetStudentListWithCategory();
        Student GetStudentById(int id);
    }
}
