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
    public class ParentGradeController: Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public ParentGradeController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }

        [HttpGet]
        [Route("/School/Parent/ViewGrade")]

         public ViewResult InitForm([Bind] SchoolProject.Models.Form.Grades form)
        {
            IQueryable<Grades> grade = _context.grades.Where(s => s.student_id.Equals(form.student_id));                         
            ViewBag.grades = grade;
            return View();
        }

        [HttpPost]
        [Route("/School/Parent/ViewGrade")]
        public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Grades form)
        {
            IQueryable<Grades> grade = _context.grades.Where(s => s.student_id.Equals(form.student_id));                         
            ViewBag.grades = grade;
            return View();
        }
    }
}