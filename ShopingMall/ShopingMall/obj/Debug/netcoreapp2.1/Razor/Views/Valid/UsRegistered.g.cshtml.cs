#pragma checksum "C:\Users\Andy\source\repos\ShopingMall\ShopingMall\Views\Valid\UsRegistered.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2284a9377043a31461dd8e8b6c8725500b8c5ffe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Valid_UsRegistered), @"mvc.1.0.view", @"/Views/Valid/UsRegistered.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Valid/UsRegistered.cshtml", typeof(AspNetCore.Views_Valid_UsRegistered))]
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
#line 1 "C:\Users\Andy\source\repos\ShopingMall\ShopingMall\Views\_ViewImports.cshtml"
using ShopingMall;

#line default
#line hidden
#line 2 "C:\Users\Andy\source\repos\ShopingMall\ShopingMall\Views\_ViewImports.cshtml"
using ShopingMall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2284a9377043a31461dd8e8b6c8725500b8c5ffe", @"/Views/Valid/UsRegistered.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a109291f51fee138f79284e3e7ff814cdb93d1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Valid_UsRegistered : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShopingMall.Models.UserProfile>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Andy\source\repos\ShopingMall\ShopingMall\Views\Valid\UsRegistered.cshtml"
  
    ViewData["Title"] = "UsRegistered";

#line default
#line hidden
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1630, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(10258, 12, true);
            WriteLiteral("\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(10270, 410, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73077b182bf0483c93964ac8c5fa8247", async() => {
                BeginContext(10276, 397, true);
                WriteLiteral(@"

    <table width=""100%"" border=""1"">
        <tr>
            <th>Month</th>
            <th>Savings</th>
            <th>Savings for holiday!</th>
        </tr>
        <tr>
            <td>January</td>
            <td>$100</td>
            <td rowspan=""2"">$50</td>
        </tr>
        <tr>
            <td>February</td>
            <td>$80</td>
        </tr>
    </table>

");
                EndContext();
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
            EndContext();
            BeginContext(10680, 39, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShopingMall.Models.UserProfile>> Html { get; private set; }
    }
}
#pragma warning restore 1591