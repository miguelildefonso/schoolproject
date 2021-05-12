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
    public class LoginProfessorController : Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;
        public LoginProfessorController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
        [HttpGet]
        [Route("/School/LoginProfessor")]
        public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [Route("/School/LoginProfessor")]
         public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Professor form)
        {  
            var pass = _context.professor
                   .Where(u => u.username.Equals(form.username))
                   .Select(u => u.password)
                   .FirstOrDefault();
            if(form.password.Equals(pass))
            {
                return View();
            }
            else
            {
                ViewBag.p = pass;
                return View("Error");
            }
        }     
    }
}