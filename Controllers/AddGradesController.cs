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
    public class AddGradesController : Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public AddGradesController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
        [HttpGet]
        [Route("/School/AddGrades")]

         public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [Route("/School/AddGrades")]
        public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Grades form)
        {
            Grades gr = new Grades();
            gr.grade_id = form.grade_id;
            gr.student_id = form.student_id;
            gr.subject_title = form.subject_title;
            gr.grade = form.grade;
            gr.remarks = form.remarks;
            gr.comment = form.comment;
            DateTime dateNow = DateTime.Now;
            gr.date_modified = dateNow;

            _context.grades.Add(gr);
            int rec = _context.SaveChanges();

            if(rec==1)
            {
                return View();
            }
            return View("Error");
        }
    }
}