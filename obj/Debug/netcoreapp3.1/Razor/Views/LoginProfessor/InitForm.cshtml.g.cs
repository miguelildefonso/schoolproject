#pragma checksum "C:\SchoolProject\Views\LoginProfessor\InitForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f29db1d020cb8b3ddef0faf5cffbb9aaf2d9ffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoginProfessor_InitForm), @"mvc.1.0.view", @"/Views/LoginProfessor/InitForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f29db1d020cb8b3ddef0faf5cffbb9aaf2d9ffa", @"/Views/LoginProfessor/InitForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d12c450783518b7e0fe3b644f2c1dd72934afd1", @"/Views/_ViewImports.cshtml")]
    public class Views_LoginProfessor_InitForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolProject.Models.Form.Professor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f29db1d020cb8b3ddef0faf5cffbb9aaf2d9ffa3883", async() => {
                WriteLiteral(@"
	<title>School</title>
	<meta charset=""UTF-8"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<!--===============================================================================================-->	
	<link rel=""icon"" type=""image/png"" href=""/img/icons/favicon.ico""/>
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/bootstrap/css/bootstrap.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/fonts/iconic/css/material-design-iconic-font.min.css"">
<!--===============================================================================================-->
	<link rel=""styleshee");
                WriteLiteral(@"t"" type=""text/css"" href=""/vendor/animate/animate.css"">
<!--===============================================================================================-->	
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/css-hamburgers/hamburgers.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/animsition/css/animsition.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/select2/select2.min.css"">
<!--===============================================================================================-->	
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/daterangepicker/daterangepicker.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/css/util.css"">
	<link rel=""stylesheet"" typ");
                WriteLiteral("e=\"text/css\" href=\"/css/main.css\">\r\n<!--===============================================================================================-->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f29db1d020cb8b3ddef0faf5cffbb9aaf2d9ffa7181", async() => {
                WriteLiteral("\r\n\t\r\n\t<div class=\"limiter\">\r\n\t\t<div class=\"container-login100\" style=\"background-image: url(\'/img/konkuk.jpg\');\">\r\n\t\t\t<div class=\"wrap-login100\">\r\n");
#nullable restore
#line 36 "C:\SchoolProject\Views\LoginProfessor\InitForm.cshtml"
                 using(Html.BeginForm("Professor", "School", FormMethod.Post))
    			{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f29db1d020cb8b3ddef0faf5cffbb9aaf2d9ffa7879", async() => {
                    WriteLiteral(@"
						<span class=""login100-form-logo"">
							<img src=""/img/teacher.png"" alt=""professor"" width=""50"" height=""50"">
						</span>

						<span class=""login100-form-title p-b-34 p-t-27"">
							Professor Login
						</span>

						<div class=""wrap-input100 validate-input"" data-validate = ""Enter username"">
							");
#nullable restore
#line 48 "C:\SchoolProject\Views\LoginProfessor\InitForm.cshtml"
                       Write(Html.TextBoxFor(m => m.username, new {@class="input100", @name="username", @placeholder="Username" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\t\t\t\t\t\t\t<span class=\"focus-input100\" data-placeholder=\"&#xf207;\"></span>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<div class=\"wrap-input100 validate-input\" data-validate=\"Enter password\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 53 "C:\SchoolProject\Views\LoginProfessor\InitForm.cshtml"
                       Write(Html.PasswordFor(m => m.password, new {@class="input100", @name="pass", @placeholder="Password"}));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\t\t\t\t\t\t\t<span class=\"focus-input100\" data-placeholder=\"&#xf191;\"></span>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<div class=\"container-login100-form-btn\">\r\n\t\t\t\t\t\t\t<button class=\"login100-form-btn\">\r\n\t\t\t\t\t\t\t\tLogin\r\n\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\SchoolProject\Views\LoginProfessor\InitForm.cshtml"
				}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"				<div>
					<br><span id=""span_role"">Not a professor?</span><br>
					<div id=""cont_role"">
						<a href = ""/School/LoginAdmin""><img src=""/img/engineer.png"" alt=""Admin"" width=""40"" height=""40"" id=""role""></a>
						<a href = ""/School/LoginStudent""><img src=""/img/students.png"" alt=""Student"" width=""40"" height=""40"" id=""role""></a>
						<a href = ""/School/LoginParent""><img src=""/img/parents.png"" alt=""Parent"" width=""40"" height=""40"" id=""role""></a>
					</div>
				</div>
			</div>
		</div>
	</div>
	

	<div id=""dropDownSelect1""></div>
	
<!--===============================================================================================-->
	<script src=""vendor/jquery/jquery-3.2.1.min.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/animsition/js/animsition.min.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/bootstrap/js/po");
                WriteLiteral(@"pper.js""></script>
	<script src=""vendor/bootstrap/js/bootstrap.min.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/select2/select2.min.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/daterangepicker/moment.min.js""></script>
	<script src=""vendor/daterangepicker/daterangepicker.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/countdowntime/countdowntime.js""></script>
<!--===============================================================================================-->
	<script src=""js/main.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolProject.Models.Form.Professor> Html { get; private set; }
    }
}
#pragma warning restore 1591
