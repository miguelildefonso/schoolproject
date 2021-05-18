using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using SchoolProject.Models.Data;

namespace SchoolProject.Controllers
{
    public class StudentProfileController: Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public StudentProfileController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
        
        [HttpGet]
        [Route("/School/Student/Profile")]
        public ViewResult InitForm()
        {
            IQueryable<Student> stud =  _context.student
                        .Where(s => s.student_id == httpContext.Session.GetInt32("uid"));
            ViewBag.student = stud;
            return View();
        }
        [HttpPost]
        [Route("/School/Student/Profile")]
         public ViewResult SubmitForm()
        {
            IQueryable<Student> stud =  _context.student
                        .Where(s => s.student_id == httpContext.Session.GetInt32("uid"));
            ViewBag.student = stud;
            return View();
        }     
    }
}