using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using SchoolProject.Models.Data;

namespace SchoolProject.Controllers
{
    public class StudentHomeController: Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public StudentHomeController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
        
        [HttpGet]
        [Route("/School/Student")]
        public ViewResult InitForm()
        {
            return View();
        }  
    }
}