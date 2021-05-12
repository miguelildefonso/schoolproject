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
    public class LoginAdminController : Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;
        public LoginAdminController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }

        [HttpGet]
        [Route("/School/LoginAdmin")]
        public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [Route("/School/LoginAdmin")]
         public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Admin_User form)
        {  
            var pass = _context.admin_user
                   .Where(u => u.username == form.username)
                   .Select(u =>u.password)
                   .FirstOrDefault();
            ViewBag.p = pass;
            if(form.password.Equals(pass))
            {
                return View();
            }
            return View("Error");
        }     
    }
}