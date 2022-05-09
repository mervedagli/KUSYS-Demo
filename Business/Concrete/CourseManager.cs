using Business.Abstract;
using DataAccessLayer.Abstract;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void AddCourse(Course course)
        {
            _courseDal.Insert(course);
        }

        public void DeleteCourse(Course course)
        {
            _courseDal.Delete(course);  
        }

        public List<Course> GetAllCourses()
        {
            return _courseDal.GetAll();
        }

        public Course GetCourseById(int id)
        {
            return _courseDal.GetByID(id);  
        }

        public void UpdateCourse(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
