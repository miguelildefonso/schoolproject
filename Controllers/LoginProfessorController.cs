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
        [Route("/School/Professor")]
         public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Professor form)
        {  
            var user = _context.professor
                   .Where(u => u.username == form.username && u.password == form.password)
                   .FirstOrDefault();
            if(user == null)
            {
                ViewBag.error = "Login error!";
                return View("InitForm");
            }
            else
            {
                var profid = _context.professor
                    .Where(u => u.username == form.username)
                    .Select(u => u.professor_id)
                    .FirstOrDefault();
                httpContext.Session.SetString("username",form.username);
                httpContext.Session.SetInt32("uid",profid);
                return View();
            }
        }     

        [Route("proflogout")]
        [HttpGet]
        public IActionResult profLogout()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("uid");
            return RedirectToAction("InitForm");
        }
    }
}