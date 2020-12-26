using Microsoft.AspNetCore.Mvc;
using MockSchoolManagement.Areas.Business.Data;
using MockSchoolManagement.Areas.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSchoolManagement.Areas.Business.Controllers
{
    public class StudentController : Controller
    {
        #region initialize
        private IStudentRepository _studentRepository;
        /// <summary>
        /// StudentController
        /// </summary>
        /// <param name="studentRepository"></param>
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        #endregion

        #region Index
        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Details
        /// <summary>
        /// Details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Details(int id)
        {
            Student student = new Student
            {
                Id=1,
                Name="张三",
                Major="计算机"
            };
            return View(student);
        }
        #endregion
    }
}
