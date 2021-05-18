using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using SchoolProject.Models.Data;

namespace SchoolProject.Controllers
{
    public class ParentHomeController: Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;

        public ParentHomeController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
        
        [HttpGet]
        [Route("/School/Parent")]
        public ViewResult InitForm()
        {
            return View();
        }   
    }
}