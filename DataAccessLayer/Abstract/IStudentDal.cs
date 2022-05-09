using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IStudentDal:IGenericDal<Student>
    {
        List<Student> GetListWithCourse();
    }
}
