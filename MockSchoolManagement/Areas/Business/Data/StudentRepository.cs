﻿using MockSchoolManagement.Areas.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSchoolManagement.Areas.Business.Data
{
    public class StudentRepository : IStudentRepository
    {
        #region inisialize
        private List<Student> _studentList;
        public StudentRepository()
        {
            _studentList = new List<Student>
            {
                new Student
                {
                    Id=1,
                    Name="张三",
                    Major="计算机科学",
                    Email="zhangsan@test.com"
                },
                 new Student
                {
                    Id=2,
                    Name="李四",
                    Major="物流",
                    Email="lisi@test.com"
                },
                  new Student
                {
                    Id=3,
                    Name="赵六",
                    Major="电子商务",
                    Email="zhaoliu@test.com"
                }
            };
        }
        #endregion
        public Student GetStudent(int id)
        {
            return _studentList.FirstOrDefault(s => s.Id == id);
        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
