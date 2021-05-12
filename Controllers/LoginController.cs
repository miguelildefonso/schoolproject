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
     
    public class LoginController : Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;
        public LoginController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }
        [HttpGet]
        [Route("/School/Login")]

         public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken] 
        [Route("/School/Login")]
        public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Admin_User form)
        {
            SchoolProject.Models.Data.Admin_User user = new SchoolProject.Models.Data.Admin_User();
            user.username = form.username;
            user.password = form.password;

            var pass = _context.admin_user
                   .Where(u => u.username.Equals(form.username))
                   .Select(u => u.password)
                   .FirstOrDefault();
            if(form.password.Equals(pass))
            {
                return View();
            }
            else
            {
                ViewBag.p = pass;
                return View("Error");
            }
            
        }
    }
}