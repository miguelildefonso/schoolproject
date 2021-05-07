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
    public class AdminHomeController: Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public AdminHomeController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
        
        [HttpGet]
        [Route("/School/Admin")]
        public ViewResult InitForm()
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
        [HttpPost]
        [Route("/School/Admin")]
         public ViewResult SubmitForm()
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
    }
}