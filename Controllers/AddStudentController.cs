using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Models.Data;
using SchoolProject.Models.Form;

namespace SchoolProject.Controllers
{
    public class AddStudentController : Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public AddStudentController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
        [HttpGet]
        [Route("/School/AddStudent")]

         public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [Route("/School/AddStudent")]
        public ViewResult SubmitForm()
        {
            return View();
        }
    }
}