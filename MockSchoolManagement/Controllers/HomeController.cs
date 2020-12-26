using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSchoolManagement.Controllers
{
    public class HomeController : Controller
    {
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
