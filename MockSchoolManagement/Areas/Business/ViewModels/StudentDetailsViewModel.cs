using MockSchoolManagement.Areas.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSchoolManagement.Areas.Business.ViewModels
{
    public class StudentDetailsViewModel
    {
        public Student student { get; set; }
        public string PageTitle { get; set; }
    }
}
