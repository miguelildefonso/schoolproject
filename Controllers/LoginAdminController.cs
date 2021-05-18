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
    public class LoginAdminController : Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;
        public LoginAdminController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }

        [HttpGet]
        [Route("/School/LoginAdmin")]
        public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [Route("/School/Admin")]
         public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Admin_User form)
        {  
            var user = _context.admin_user
                   .Where(u => u.username == form.username && u.password == form.password)
                   .FirstOrDefault();
            if(user == null)
            {
                ViewBag.error = "Login error!";
                return View("InitForm");
            }
            else
            {
                httpContext.Session.SetString("username",form.username);
                ShowData();
                return View();
            }
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("InitForm");
        }

        public void ShowData()
        {
            IQueryable<Admin_User> admin = from s in _context.admin_user
                                        select s;
            IQueryable<Professor> profe = from s in _context.professor
                                        select s;
            IQueryable<Programs> prog = from s in _context.program
                                        select s;
            IQueryable<Student> stud = from s in _context.student
                                        select s;
            IQueryable<Subject> subj = from s in _context.subject
                                        select s;
            IQueryable<Parent_User> par = from s in _context.parent_user
                                        select s;
            ViewBag.parent_user = par;
            ViewBag.subject = subj;  
            ViewBag.student = stud;
            ViewBag.admin_user = admin;
            ViewBag.professor = profe; 
            ViewBag.programs = prog; 
        }     
    }
}