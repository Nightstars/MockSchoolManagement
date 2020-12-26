using Microsoft.AspNetCore.Mvc;
using MockSchoolManagement.Areas.Business.Data;
using MockSchoolManagement.Areas.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSchoolManagement.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        #region initialize
        
        #endregion

        #region Index
        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public string Index()
        {
            return "Hello from MVC";
        }
        #endregion
    }
}
