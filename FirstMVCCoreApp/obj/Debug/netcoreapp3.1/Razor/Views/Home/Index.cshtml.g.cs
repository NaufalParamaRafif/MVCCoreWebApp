#pragma checksum "D:\learn-practice\mvc\FirstMVCCoreApp\FirstMVCCoreApp\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3191a5bba2efd2dd9be33c7254ecede1a6f3692512d1c91e049ce1da90f9b5e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\learn-practice\mvc\FirstMVCCoreApp\FirstMVCCoreApp\Views\_ViewImports.cshtml"
using FirstMVCCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\learn-practice\mvc\FirstMVCCoreApp\FirstMVCCoreApp\Views\_ViewImports.cshtml"
using FirstMVCCoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3191a5bba2efd2dd9be33c7254ecede1a6f3692512d1c91e049ce1da90f9b5e6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ecaa34800a24c29b9ed6b29ccbb963686030f87a70c80ad98f25efb49406ed56", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/user.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\learn-practice\mvc\FirstMVCCoreApp\FirstMVCCoreApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\"\r\n          href=\"https://cdn.jsdelivr.net/npm/sweetalert2@11/dist/sweetalert2.min.css\"\r\n          id=\"theme-styles\" />\r\n    <link href=\"https://unpkg.com/bootstrap-table@1.22.1/dist/bootstrap-table.min.css\" rel=\"stylesheet\">\r\n");
            }
            );
            WriteLiteral(@"<div>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""form-group"">
                <label for=""txtUsername"">Username</label>
                <input type=""text"" class=""form-control"" id=""txtUsername"" aria-describedby=""txtUsername"" placeholder=""Username"">
            </div>
            <div class=""form-group"">
                <label for=""txtPassword"">Password</label>
                <input type=""password"" class=""form-control"" id=""txtPassword"" placeholder=""Password"">
            </div>
            <div class=""form-check"">
                <input type=""checkbox"" class=""form-check-input"" id=""isEnabled"">
                <label class=""form-check-label"" for=""exampleCheck1"">Is Enabled</label>
            </div>
            <button type=""submit"" class=""btn btn-primary"" id=""btnSubmit"">Submit</button>
            <button type=""submit"" class=""btn btn-success"" id=""btnUpdate"" style=""display: none"">Update</button>
            <button type=""submit"" class=""btn btn-warning"" id=""btnCl");
            WriteLiteral(@"ear"">Clear</button>
        </div>
        <div class=""col-md-12"">
            <div class=""table-responsive"">
                <table id=""tblMaster""
                       data-unique-id=""id""
                       data-toggle=""table""
                       data-toolbar=""#toolbar"">
                    <thead>
                        <tr>
                            <th data-field=""id"">ID</th>
                            <th data-field=""username"">User Name</th>
                            <th data-field=""password"">Password</th>
                            <th data-field=""is_enabled"">Is Enabled</th>
                            <th data-formatter=""viewButton"">Action</th>
                        </tr>
                    </thead>
                </table>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("js", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/sweetalert2@11\"></script>\r\n    <script src=\"https://unpkg.com/bootstrap-table@1.22.1/dist/bootstrap-table.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3191a5bba2efd2dd9be33c7254ecede1a6f3692512d1c91e049ce1da90f9b5e66536", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
