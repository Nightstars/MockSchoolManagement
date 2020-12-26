using MockSchoolManagement.Areas.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSchoolManagement.Areas.Business.Data
{
    public class StudentRepository : IStudentRepository
    {
        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
