using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSchoolManagement.Areas.Business.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public string Email { get; set; }
    }
}
