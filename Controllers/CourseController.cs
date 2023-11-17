using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCourse.Controllers
{
    public class CourseController:Controller
    {
          public IActionResult Index(){
            return View();
          }

        public IActionResult Apply()
        {
            return View();
        }
    }
}