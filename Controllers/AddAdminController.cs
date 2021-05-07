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
    public class AddAdminController : Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public AddAdminController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
         [HttpGet]
        [Route("/School/AddAdmin")]

         public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [Route("/School/AddAdmin")]
        public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Admin_User form)
        {
            Admin_User a = new Admin_User();
            a.admin_id = form.admin_id;
            a.firstname = form.firstname;
            a.lastname = form.lastname;
            a.username = form.username;
            a.password = form.password;
            a.type = form.type;
            _context.admin_user.Add(a);
            int rec = _context.SaveChanges();
            if(rec==1)
            {
                IQueryable<Admin_User> admin = from s in _context.admin_user
                                        select s;
                IQueryable<Professor> profe = from s in _context.professor
                                        select s;
                IQueryable<Programs> prog = from s in _context.program
                                        select s;
                ViewBag.admin_user = admin;
                ViewBag.professor = profe; 
                ViewBag.programs = prog; 
                return View();
            }
            return View("Error");
        }
        
    }
}