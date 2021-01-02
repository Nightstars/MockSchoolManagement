using Microsoft.AspNetCore.Mvc;
using MockSchoolManagement.Areas.Business.Data;
using MockSchoolManagement.Areas.Business.Models;
using MockSchoolManagement.Areas.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSchoolManagement.Areas.Business.Controllers
{
    [Area("Business")]
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
            //查询所有学生信息
            var model = _studentRepository.GetAllStudents();
            //将学生信息传递给View方法
            return View(model);
        }
        #endregion

        #region Details
        /// <summary>
        /// Details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Student/Details/{id?}")]
        public IActionResult Details(int id)
        {
            Student student = _studentRepository.GetStudent(id);
            //实例化StudentDetailsViewModel并存储Stuent详细信息和PageTitle
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel
            {
                student = student,
                PageTitle= "学生详情"
            };
            return View(studentDetailsViewModel);
        }
        #endregion
    }
}
