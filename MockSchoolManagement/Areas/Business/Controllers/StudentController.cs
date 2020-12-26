using Microsoft.AspNetCore.Mvc;
using MockSchoolManagement.Areas.Business.Data;
using MockSchoolManagement.Areas.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSchoolManagement.Areas.Business.Controllers
{
    [Area("Business")]
    [Route("[controller]/[action]")]
    public class StudentController : Controller
    {
        #region initialize
        private readonly IStudentRepository _studentRepository;
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
            Student student = _studentRepository.GetStudent(id);
            //使用ViewData将PageTitle和Student模型传递给View
            //使用动态属性PageTitle和Student
            ViewBag.PageTitle = "学生详情";
            ViewBag.Student = student;
            return View();
        }
        #endregion
    }
}
