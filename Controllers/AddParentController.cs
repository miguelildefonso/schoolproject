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
    public class AddParentController: Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public AddParentController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
         [HttpGet]
        [Route("/School/AddParent")]

         public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [Route("/School/AddParent")]
        public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Parent_User form)
        {
            Parent_User a = new Parent_User();
            a.parent_id = form.parent_id;
            a.firstname = form.firstname;
            a.lastname = form.lastname;
            a.username = form.username;
            a.password = form.password;
            _context.parent_user.Add(a);
            int rec = _context.SaveChanges();
            if(rec==1)
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
                return View();
            }
            return View("Error");
        }
    }
}