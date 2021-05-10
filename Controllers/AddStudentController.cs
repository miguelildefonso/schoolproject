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
        public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Student form)
        {
            Student st = new Student();
            st.student_id = form.student_id;
            st.lastname = form.lastname;
            st.firstname = form.firstname;
            st.middlename = form.middlename;
            st.program = form.program;
            st.status = form.status;
            st.academic_year = form.academic_year;
            st.yearlevel = form.yearlevel;
            st.username = form.username;
            st.password = form.password;
            st.sem = form.sem;
            st.birthday = form.birthday;
            
            _context.student.Add(st);
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
                ViewBag.subject = subj;
                ViewBag.student = stud;
                ViewBag.admin_user = admin;
                ViewBag.professor = profe; 
                ViewBag.programs = prog; 
                return View();
            }else
            {
                return View("Error");
            }
        }
    }
}