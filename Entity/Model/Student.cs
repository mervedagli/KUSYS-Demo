using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public  class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsDeleted { get; set; }
        public int CourseID { get; set; }
        public Course? Course { get; set; }
    }
}
