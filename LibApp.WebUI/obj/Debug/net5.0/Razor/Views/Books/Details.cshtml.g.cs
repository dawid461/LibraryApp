#pragma checksum "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eacab620d3e93f4c7946fbd566f04d50c455e939"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
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
#line 1 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\_ViewImports.cshtml"
using LibApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\_ViewImports.cshtml"
using LibApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\_ViewImports.cshtml"
using LibApp.Domain.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eacab620d3e93f4c7946fbd566f04d50c455e939", @"/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a965c0ffe2b9fb9c737ae41142c57f17cfebab4", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibApp.Application.Core.Dtos.BookDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Details.cshtml"
  
    ViewBag.Title = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>");
#nullable restore
#line 7 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<ul>\n    <li>Author Name: ");
#nullable restore
#line 10 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Details.cshtml"
                Write(Model.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li>Genre: ");
#nullable restore
#line 11 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Details.cshtml"
          Write(Model.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li>Release Date: ");
#nullable restore
#line 12 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Details.cshtml"
                 Write(Model.ReleaseDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li>Date Added: ");
#nullable restore
#line 13 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Details.cshtml"
               Write(Model.DateAdded.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li>Numbers in Stock: ");
#nullable restore
#line 14 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Details.cshtml"
                     Write(Model.NumberInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n</ul>\n\n<div class=\"row\">\n    <div class=\"col-12\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eacab620d3e93f4c7946fbd566f04d50c455e9396763", async() => {
                WriteLiteral("Back to book page");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibApp.Application.Core.Dtos.BookDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
