#pragma checksum "C:\SchoolProject\Views\AddStudent\InitForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c66c8d0e22047f92805b9a09e85aa6c5c8257b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AddStudent_InitForm), @"mvc.1.0.view", @"/Views/AddStudent/InitForm.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\SchoolProject\Views\_ViewImports.cshtml"
using SchoolProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SchoolProject\Views\_ViewImports.cshtml"
using SchoolProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
using SchoolProject.Models.Form;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c66c8d0e22047f92805b9a09e85aa6c5c8257b8", @"/Views/AddStudent/InitForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d12c450783518b7e0fe3b644f2c1dd72934afd1", @"/Views/_ViewImports.cshtml")]
    public class Views_AddStudent_InitForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolProject.Models.Form.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/adminstudent.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/engineer.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c66c8d0e22047f92805b9a09e85aa6c5c8257b85564", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"sidenav\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1c66c8d0e22047f92805b9a09e85aa6c5c8257b86711", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
  <h4>Admin Menu</h4><br><br>
  <a href=""/School/Admin"">Home</a>
  <a href=""/School/AddStudent"">Add Student</a>
  <a href=""/School/AddProfessor"">Add Professor</a>
  <a href=""/School/AddProgram"">Add Program</a>
  <a href=""/School/AddSubject"">Add Subject</a>
  <a href=""/School/AddAdmin"">Add Admin</a>
  <a href=""/School/LoginAdmin"" id=""logout"">Logout</a>
</div>

<div class=""main"">
  <nav class=""navbar navbar-expand-lg navbar-light"">
    <div class=""collapse navbar-collapse"" id=""navbarNav"">
      <ul class=""navbar-nav"" style=""margin-left: auto;"">
        <li class=""nav-item"">
");
            WriteLiteral("            <a class=\"navbar-brand\">");
#nullable restore
#line 23 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
                               Write(DateTime.Now.ToString("dddd , MMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral("        </li>\r\n      </ul>\r\n    </div>\r\n  </nav>\r\n  <h4 style=\"margin-top: 20px; margin-bottom: 30px;\">Add Student</h4>\r\n");
#nullable restore
#line 30 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
   using(Html.BeginForm("SubmitForm", "AddStudent", FormMethod.Post))
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c66c8d0e22047f92805b9a09e85aa6c5c8257b89344", async() => {
                WriteLiteral("\r\n      <div class=\"form-group row\">\r\n        <div class=\"col-xs-3\">\r\n          <label for=\"exampleInputEmail1\">Student Number</label>\r\n          ");
#nullable restore
#line 36 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
     Write(Html.TextBoxFor(m => m.student_id, new{@class="form-control",  @placeholder="Enter Student Number"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n      </div>\r\n      <div class=\"form-group row\">\r\n        <div class=\"col-xs-3\">\r\n          <label for=\"exampleInputEmail1\">Last Name</label>\r\n          ");
#nullable restore
#line 42 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
     Write(Html.TextBoxFor(m => m.lastname, new{@class="form-control",  @placeholder="Enter Last Name"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-xs-3\">\r\n          <label for=\"exampleInputEmail1\">First Name</label>\r\n          ");
#nullable restore
#line 46 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
     Write(Html.TextBoxFor(m => m.firstname, new{@class="form-control",  @placeholder="Enter First Name"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-xs-3\">\r\n          <label for=\"exampleInputEmail1\">Middle Name</label>\r\n          ");
#nullable restore
#line 50 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
     Write(Html.TextBoxFor(m => m.middlename, new{@class="form-control",  @placeholder="Enter Middle Name"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n      </div>\r\n      <div class=\"form-group row\">\r\n        <div class=\"col-xs-3\">\r\n          <label for=\"exampleInputEmail1\">Birthday</label>\r\n          ");
#nullable restore
#line 56 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
     Write(Html.TextBoxFor(m => m.birthday,new {@class="form-control", @Id="SelectedDate"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <!-- Bootstrap -->
            <script type=""text/javascript"" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
            <script type=""text/javascript"" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
            <!-- Bootstrap DatePicker -->
            <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/css/bootstrap-datepicker.css""type=""text/css""/>
            <script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/js/bootstrap-datepicker.js""type=""text/javascript""></script>
            <!-- Bootstrap DatePicker -->
            <script type=""text/javascript"">
              $(function () {
                  $('#SelectedDate').datepicker({
                      changeMonth: true,
                      changeYear: true,
                      format: ""yyyy-mm-dd"",
                      language: ""tr""
                  });
              });
");
                WriteLiteral("            </script>\r\n        </div>\r\n      </div>\r\n\r\n      <div class=\"form-group row\">\r\n        <div class=\"col-xs-3\">\r\n          <label for=\"exampleFormControlSelect1\">Program</label>\r\n          ");
#nullable restore
#line 80 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
     Write(Html.DropDownListFor(m => m.program, 
              new SelectList(Enum.GetValues(typeof(Stud_Program))), new{@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-xs-3\">\r\n          <label for=\"exampleFormControlSelect1\">Status</label>\r\n          ");
#nullable restore
#line 85 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
     Write(Html.DropDownListFor(m => m.status, 
              new SelectList(Enum.GetValues(typeof(StudStatus))), new{@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-xs-3\">\r\n          <label for=\"exampleFormControlSelect1\">Academic Year</label>\r\n          ");
#nullable restore
#line 90 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
     Write(Html.TextBoxFor(m => m.academic_year,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-xs-3\">\r\n          <label for=\"exampleFormControlSelect1\">Semester</label>\r\n          ");
#nullable restore
#line 94 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
     Write(Html.DropDownListFor(m => m.sem, 
              new SelectList(Enum.GetValues(typeof(Sem))), new{@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-xs-3\">\r\n          <label for=\"exampleFormControlSelect1\">Year Level</label>\r\n          ");
#nullable restore
#line 99 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
     Write(Html.TextBoxFor(m => m.yearlevel,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n      </div>\r\n      <div class=\"form-group row\">\r\n        <div class=\"col-xs-3\">\r\n          <label for=\"exampleFormControlSelect1\">Username</label>\r\n          ");
#nullable restore
#line 105 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
     Write(Html.TextBoxFor(m => m.username,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-xs-3\">\r\n          <label for=\"exampleFormControlSelect1\">Password</label>\r\n          ");
#nullable restore
#line 109 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
     Write(Html.TextBoxFor(m => m.password,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n      </div>\r\n      <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 114 "C:\SchoolProject\Views\AddStudent\InitForm.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolProject.Models.Form.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
