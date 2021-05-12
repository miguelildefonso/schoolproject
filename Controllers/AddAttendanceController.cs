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
    public class AddAttendanceController : Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public AddAttendanceController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
        [HttpGet]
        [Route("/School/AddAttendance")]

         public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [Route("/School/AddAttendance")]
        public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Attendance form)
        {
            Attendance a = new Attendance();
            a.attendance_id = form.attendance_id;
            a.date = form.date;
            a.subject_code = form.subject_code;
            a.student_id = form.student_id;
            a.comment = form.comment;

            _context.attendance.Add(a);
            int rec = _context.SaveChanges();

            if(rec==1)
            {
                return View();
            }
            return View("Error");
        }
    }
}