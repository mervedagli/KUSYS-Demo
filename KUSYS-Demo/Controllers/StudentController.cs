using Business.Concrete;
using DataAccessLayer.EntityFramework;
using Entity.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KUSYS_Demo.Controllers
{
    public class StudentController : Controller
    {
        StudentManager studentManager = new StudentManager(new EfStudentRepository());
        CourseManager cm = new CourseManager(new EfCourseRepository());
        public IActionResult Index()
        {
            var values = studentManager.GetStudentListWithCategory();
            return View(values);
        }
        [Authorize(Roles = "US-1")]
        [HttpGet]
        public IActionResult AddStudent()
        {
            
            List<SelectListItem> courses = (from x in cm.GetAllCourses()
                                            select new SelectListItem
                                            {
                                                Text=x.CourseName,
                                                Value=x.CourseID.ToString(),
                                            }).ToList();
            ViewBag.course = courses;
            return View();  
        }
        [Authorize(Roles = "US-1")]
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                studentManager.AddStudent(student);
            }
            else
            {
                return Json(new { succ = false, msg = "Hatalı Kayıt!!!" });
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "US-1")]
        public IActionResult DeleteStudent(int id)
        {
            var student= studentManager.GetStudentById(id);
            student.IsDeleted = true;
            if (ModelState.IsValid)
            {
                studentManager.UpdateStudent(student);
            }
            else
            {
                return Json(new { succ = false, msg = "Hatalı Kayıt!!!" });
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var student=studentManager.GetStudentById(id);


            List<SelectListItem> courses = (from x in cm.GetAllCourses()
                                            select new SelectListItem
                                            {
                                                Text = x.CourseName,
                                                Value = x.CourseID.ToString(),
                                            }).ToList();
            ViewBag.course = courses;

            return View(student);
        }

        [HttpPost]
        public IActionResult EditStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                studentManager.UpdateStudent(student);
            }
            else
            {
                return Json(new { succ = false, msg = "Hatalı Kayıt!!!" });
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles="US-2")]
        [HttpGet]
        public ActionResult Partial_Detail(int id)
        {
            var student = studentManager.GetStudentById(id);


            List<SelectListItem> courses = (from x in cm.GetAllCourses()
                                            select new SelectListItem
                                            {
                                                Text = x.CourseName,
                                                Value = x.CourseID.ToString(),
                                            }).ToList();
            ViewBag.course = courses;

            return PartialView("Partial_Detail", student);
        }

    }
}
