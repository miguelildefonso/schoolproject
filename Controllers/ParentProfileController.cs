using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using SchoolProject.Models.Data;

namespace SchoolProject.Controllers
{
    public class ParentProfileController: Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public ParentProfileController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
        
        [HttpGet]
        [Route("/School/Parent/Profile")]
        public ViewResult InitForm()
        {
            IQueryable<Parent_User> p =  _context.parent_user
                        .Where(s => s.parent_id == httpContext.Session.GetInt32("uid"));
            ViewBag.parent_user = p;
            return View();
        }
        [HttpPost]
        [Route("/School/Parent/Profile")]
         public ViewResult SubmitForm()
        {
            return View();
        }     
    }
}