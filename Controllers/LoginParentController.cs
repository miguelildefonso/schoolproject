using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Models.Data;

namespace SchoolProject.Controllers
{
    public class LoginParentController : Controller
    {
        [HttpGet]
        [Route("/School/LoginParent")]
        public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [Route("/School/LoginParent")]
         public ViewResult SubmitForm()
        {  
            return View();
        }     
    }
}