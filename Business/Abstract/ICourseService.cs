using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        void AddCourse(Course course);
        void DeleteCourse(Course course);
        void UpdateCourse(Course course);
        List<Course> GetAllCourses();
        Course GetCourseById(int id);
    }
}
