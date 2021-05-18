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
    public class StudentAttendanceController: Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public StudentAttendanceController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }

        [HttpGet]
        [Route("/School/Student/ViewAttendance")]

         public ViewResult InitForm([Bind] SchoolProject.Models.Form.Attendance form)
        {
            IQueryable<Attendance> a = _context.attendance
                .Where(s => s.student_id.Equals(httpContext.Session.GetInt32("uid")) && s.date.Equals(form.date));                         
            ViewBag.attendance = a;
            ViewBag.date = form.date;
            return View();
        }

        [HttpPost]
        [Route("/School/Student/ViewAttendance")]
        public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Attendance form)
        {
            IQueryable<Attendance> a = _context.attendance
                .Where(s => s.student_id.Equals(httpContext.Session.GetInt32("uid")) && s.date.Equals(form.date));                         
            ViewBag.attendance = a;
            ViewBag.date = form.date;
            return View();
        }
    }
}