using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class UserRoleMap
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int UserRoleID { get; set; }


    }
}
