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
    public class AddProfessorController : Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public AddProfessorController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
         [HttpGet]
        [Route("/School/AddProfessor")]

         public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [Route("/School/AddProfessor")]
        public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Professor form)
        {
           Professor prof = new Professor(); 
           prof.professor_id = form.professor_id;
           prof.professor_no = form.professor_no;
           prof.professor_name = form.professor_name;
           prof.gender = form.gender;
           prof.status = form.status;
           prof.birthdate = form.birthdate;
           prof.username = form.username;
           prof.password = form.password;

            _context.professor.Add(prof);
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