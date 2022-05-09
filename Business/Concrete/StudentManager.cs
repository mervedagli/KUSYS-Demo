using Business.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void AddStudent(Student student)
        {
            _studentDal.Insert(student);
        }

        public void DeleteStudent(Student student)
        {
            _studentDal.Delete(student);    
        }

        public List<Student> GetAllStudents()
        {
            return _studentDal.GetAll();
        }

        public Student GetStudentById(int id)
        {
            return _studentDal.GetByID(id);
        }

        public List<Student> GetStudentListWithCategory()
        {
            return _studentDal.GetListWithCourse();
        }

        public void UpdateStudent(Student student)
        {
            _studentDal.Update(student);
        }
    }
}
