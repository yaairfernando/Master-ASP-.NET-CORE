#pragma checksum "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\SubCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afafec50424a7453865a9869be8ef4642f014865"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SubCategory_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SubCategory/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SubCategory/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_SubCategory_Index))]
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
#line 1 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#line 2 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afafec50424a7453865a9869be8ef4642f014865", @"/Areas/Admin/Views/SubCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1390ba8093fb4c2e21d25b459146d9962f6bcb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SubCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SubCategory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\SubCategory\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(123, 226, true);
            WriteLiteral("\r\n<br />\r\n<div class=\"border backgroundWhite\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-info\">Sub Category List</h2>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            ");
            EndContext();
            BeginContext(349, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "afafec50424a7453865a9869be8ef4642f0148654659", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(388, 62, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div class=\"\">\r\n");
            EndContext();
#line 20 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\SubCategory\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
            BeginContext(494, 126, true);
            WriteLiteral("            <table class=\"table table-striped border\">\r\n                <tr class=\"table-secondary\">\r\n                    <th>");
            EndContext();
            BeginContext(621, 32, false);
#line 24 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\SubCategory\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(653, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(685, 41, false);
#line 25 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\SubCategory\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(726, 92, true);
            WriteLiteral("</th>\r\n                    <th></th>\r\n                    <th></th>\r\n                </tr>\r\n");
            EndContext();
#line 29 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\SubCategory\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(883, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(930, 31, false);
#line 32 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\SubCategory\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(961, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(993, 40, false);
#line 33 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\SubCategory\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1064, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "afafec50424a7453865a9869be8ef4642f0148658637", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 34 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\SubCategory\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1118, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 36 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\SubCategory\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1167, 22, true);
            WriteLiteral("            </table>\r\n");
            EndContext();
#line 38 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\SubCategory\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1225, 46, true);
            WriteLiteral("            <p>No Sub Category exists...</p>\r\n");
            EndContext();
#line 42 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\SubCategory\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1282, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SubCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
