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
    public class LoginParentController : Controller
    {
        private readonly SchoolContext _context;
        IHttpContextAccessor httpContextAccessor;
        HttpContext httpContext;
        public LoginParentController(SchoolContext context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.httpContext = this.httpContextAccessor.HttpContext;
        }

        [HttpGet]
        [Route("/School/LoginParent")]
        public ViewResult InitForm()
        {
            return View();
        }
        [HttpPost]
        [Route("/School/Parent")]
         public ViewResult SubmitForm([Bind] SchoolProject.Models.Form.Parent_User form)
        {  
           var user = _context.parent_user
                   .Where(u => u.username == form.username && u.password == form.password)
                   .FirstOrDefault();
            if(user == null)
            {
                ViewBag.error = "Login error!";
                return View("InitForm");
            }
            else
            {
                var parentid = _context.parent_user
                    .Where(u => u.username == form.username)
                    .Select(u => u.parent_id)
                    .FirstOrDefault();
                httpContext.Session.SetString("username",form.username);
                httpContext.Session.SetInt32("uid",parentid);
                return View();
            }
        }

        [Route("parlogout")]
        [HttpGet]
        public IActionResult parLogout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("InitForm");
        }     
    }
}