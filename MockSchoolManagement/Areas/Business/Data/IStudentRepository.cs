using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockSchoolManagement.Areas.Business.Models;

namespace MockSchoolManagement.Areas.Business.Data
{
    public interface IStudentRepository
    {
        Student GetStudent(int id);
        void Save(Student student);
    }
}
