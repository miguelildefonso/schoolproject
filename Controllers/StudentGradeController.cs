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
    public class StudentGradeController : Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public StudentGradeController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }

        [HttpGet]
        [Route("/School/Student/ViewGrade")]

         public ViewResult InitForm([Bind] SchoolProject.Models.Form.Grades form)
        {
           // IQueryable<Grades> grade = from s in _context.grades
           //                             select s;
           var studid = HttpContext.Session.GetInt32("uid");
            IQueryable<Grades> grade = _context.grades.Where(s => s.student_id==studid);
            ViewBag.grades = grade;
            return View();
        }

        [HttpPost]
        [Route("/School/Student/ViewGrade")]
        public ViewResult SubmitForm()
        {
            var studid = HttpContext.Session.GetInt32("uid");
            IQueryable<Grades> grade = _context.grades.Where(s => s.student_id==studid);
            ViewBag.grades = grade;
            return View();
        }
    }
}