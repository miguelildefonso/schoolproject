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
    public class ParentAttendanceController: Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public ParentAttendanceController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }

        [HttpGet]
        [Route("/School/Parent/ViewAttendance")]

         public ViewResult InitForm([Bind] SchoolProject.Models.Form.Attendance form)
        {
            IQueryable<Attendance> a = _context.attendance
                .Where(s => s.student_id.Equals(form.student_id) && s.date.Equals(form.date));                         
            ViewBag.attendance = a;
            ViewBag.date = form.date;
            return View();
        }

        [HttpPost]
        [Route("/School/Parent/ViewAttendance")]
        public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Attendance form)
        {
            IQueryable<Attendance> a = _context.attendance
                .Where(s => s.student_id.Equals(form.student_id) && s.date.Equals(form.date));                         
            ViewBag.attendance = a;
            ViewBag.date = form.date;
            return View();
        }
    }
}