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
    public class AddProgramController : Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public AddProgramController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }

        [HttpGet]
        [Route("/School/AddProgram")]

         public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [Route("/School/AddProgram")]
        public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Programs form)
        {
            Programs p = new Programs(){program_id=form.program_id,program_code=form.program_code,program_title=form.program_title,major=form.major};
            _context.program.Add(p);
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