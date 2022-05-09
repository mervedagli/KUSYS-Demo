using DataAccessLayer.Abstract;
using DataAccessLayer.Data;
using DataAccessLayer.Repositories;
using Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfStudentRepository : GenericRepository<Student>, IStudentDal
    {
        public List<Student> GetListWithCourse()
        {
            using (var c = new Context())
            {
                return c.Students.Include(x => x.Course).ToList();
            }
        }
    }
}
