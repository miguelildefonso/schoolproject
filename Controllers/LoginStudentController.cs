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
    public class LoginStudentController : Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;
        public LoginStudentController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }

        [HttpGet]
        [Route("/School/LoginStudent")]
        public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [Route("/School/Student")]
         public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Student form)
        {  
           var user = _context.student
                   .Where(u => u.username == form.username && u.password == form.password)
                   .FirstOrDefault();
            if(user == null)
            {
                ViewBag.error = "Login error!";
                return View("InitForm");
            }
            else
            {
                var studid = _context.student
                   .Where(u => u.username == form.username)
                   .Select(u => u.student_id)
                   .FirstOrDefault();
                httpContext.Session.SetString("username",form.username);
                httpContext.Session.SetInt32("uid",studid);
                return View();
            }
        }   
        [Route("studlogout")]
        [HttpGet]
        public IActionResult studLogout()
        {
            HttpContext.Session.Remove("username");
            httpContext.Session.Remove("uid");
            return RedirectToAction("InitForm");
        }       
    }
}