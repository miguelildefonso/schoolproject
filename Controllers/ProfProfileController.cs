using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using SchoolProject.Models.Data;

namespace SchoolProject.Controllers
{
    public class ProfProfileController: Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public ProfProfileController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
        
        [HttpGet]
        [Route("/School/Professor/Profile")]
        public ViewResult InitForm()
        {
            IQueryable<Professor> p =  _context.professor
                        .Where(s => s.professor_id == httpContext.Session.GetInt32("uid"));
            ViewBag.professor = p;
            return View();
        }
        [HttpPost]
        [Route("/School/Professor/Profile")]
         public ViewResult SubmitForm()
        {
            IQueryable<Professor> p =  _context.professor
                        .Where(s => s.professor_id == httpContext.Session.GetInt32("uid"));
            ViewBag.professor = p;
            return View();
        }     
    }
}