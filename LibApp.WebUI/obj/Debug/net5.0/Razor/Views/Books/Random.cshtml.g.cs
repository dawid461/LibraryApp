#pragma checksum "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Random.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc5469bd543b54f2ed131d0fa0c33ab16a8c92f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Random), @"mvc.1.0.view", @"/Views/Books/Random.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5469bd543b54f2ed131d0fa0c33ab16a8c92f0", @"/Views/Books/Random.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a965c0ffe2b9fb9c737ae41142c57f17cfebab4", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Random : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibApp.WebUI.ViewModels.RandomBookViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Random.cshtml"
  
    ViewBag.Title = "Random";
    Layout = "~/Views/Shared/_Layout.cshtml";

    var className = Model.Customers.Count > 5 ? "popular" : null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2");
            BeginWriteAttribute("class", " class=\"", 204, "\"", 222, 1);
#nullable restore
#line 10 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Random.cshtml"
WriteAttributeValue("", 212, className, 212, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Random.cshtml"
                  Write(Model.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n");
#nullable restore
#line 12 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Random.cshtml"
 if (Model.Customers.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No one has borrowed this book before</p>\n");
#nullable restore
#line 15 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Random.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\n");
#nullable restore
#line 19 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Random.cshtml"
         foreach (var customer in Model.Customers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 21 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Random.cshtml"
           Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 22 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Random.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n");
#nullable restore
#line 24 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Books\Random.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibApp.WebUI.ViewModels.RandomBookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
