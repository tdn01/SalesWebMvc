#pragma checksum "C:\Users\tiago\Documents\Informatica\Curso C#\C# udemy\19_ASP_NET_Core_MVC_EntityFramework\SalesWebMvc\SalesWebMvc\Views\Departments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eed4756fa9f9899f217d4f4f5ed3bf8f3ae10e8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_Index), @"mvc.1.0.view", @"/Views/Departments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Departments/Index.cshtml", typeof(AspNetCore.Views_Departments_Index))]
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
#line 1 "C:\Users\tiago\Documents\Informatica\Curso C#\C# udemy\19_ASP_NET_Core_MVC_EntityFramework\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\Users\tiago\Documents\Informatica\Curso C#\C# udemy\19_ASP_NET_Core_MVC_EntityFramework\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eed4756fa9f9899f217d4f4f5ed3bf8f3ae10e8a", @"/Views/Departments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMvc.Models.Department>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 6, true);
            WriteLiteral("    \r\n");
            EndContext();
#line 3 "C:\Users\tiago\Documents\Informatica\Curso C#\C# udemy\19_ASP_NET_Core_MVC_EntityFramework\SalesWebMvc\SalesWebMvc\Views\Departments\Index.cshtml"
  
    ViewData["Title"] = "Departments";

#line default
#line hidden
            BeginContext(104, 35, true);
            WriteLiteral("\r\n<h2>Departments</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(139, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82a824fb5e7849039fd631b2114fe805", async() => {
                BeginContext(162, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(176, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(269, 38, false);
#line 16 "C:\Users\tiago\Documents\Informatica\Curso C#\C# udemy\19_ASP_NET_Core_MVC_EntityFramework\SalesWebMvc\SalesWebMvc\Views\Departments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(307, 75, true);
            WriteLiteral("            \r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 21 "C:\Users\tiago\Documents\Informatica\Curso C#\C# udemy\19_ASP_NET_Core_MVC_EntityFramework\SalesWebMvc\SalesWebMvc\Views\Departments\Index.cshtml"
        foreach(var item in Model)
       {

#line default
#line hidden
            BeginContext(428, 54, true);
            WriteLiteral("          <tr>\r\n              <td>\r\n                  ");
            EndContext();
            BeginContext(483, 37, false);
#line 25 "C:\Users\tiago\Documents\Informatica\Curso C#\C# udemy\19_ASP_NET_Core_MVC_EntityFramework\SalesWebMvc\SalesWebMvc\Views\Departments\Index.cshtml"
             Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(520, 61, true);
            WriteLiteral("\r\n              </td>\r\n              <td>\r\n                  ");
            EndContext();
            BeginContext(582, 39, false);
#line 28 "C:\Users\tiago\Documents\Informatica\Curso C#\C# udemy\19_ASP_NET_Core_MVC_EntityFramework\SalesWebMvc\SalesWebMvc\Views\Departments\Index.cshtml"
             Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(621, 61, true);
            WriteLiteral("\r\n              </td>\r\n              <td>\r\n                  ");
            EndContext();
            BeginContext(683, 40, false);
#line 31 "C:\Users\tiago\Documents\Informatica\Curso C#\C# udemy\19_ASP_NET_Core_MVC_EntityFramework\SalesWebMvc\SalesWebMvc\Views\Departments\Index.cshtml"
             Write(Html.ActionLink("Edit", "Edit", new { }));

#line default
#line hidden
            EndContext();
            BeginContext(723, 20, true);
            WriteLiteral("\r\n                  ");
            EndContext();
            BeginContext(744, 46, false);
#line 32 "C:\Users\tiago\Documents\Informatica\Curso C#\C# udemy\19_ASP_NET_Core_MVC_EntityFramework\SalesWebMvc\SalesWebMvc\Views\Departments\Index.cshtml"
             Write(Html.ActionLink("Details", "Details", new { }));

#line default
#line hidden
            EndContext();
            BeginContext(790, 20, true);
            WriteLiteral("\r\n                  ");
            EndContext();
            BeginContext(811, 44, false);
#line 33 "C:\Users\tiago\Documents\Informatica\Curso C#\C# udemy\19_ASP_NET_Core_MVC_EntityFramework\SalesWebMvc\SalesWebMvc\Views\Departments\Index.cshtml"
             Write(Html.ActionLink("Delete", "delete", new { }));

#line default
#line hidden
            EndContext();
            BeginContext(855, 40, true);
            WriteLiteral("\r\n              </td>\r\n          </tr>\r\n");
            EndContext();
#line 36 "C:\Users\tiago\Documents\Informatica\Curso C#\C# udemy\19_ASP_NET_Core_MVC_EntityFramework\SalesWebMvc\SalesWebMvc\Views\Departments\Index.cshtml"
       }

#line default
#line hidden
            BeginContext(905, 24, true);
            WriteLiteral("    </tbody>  \r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMvc.Models.Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
