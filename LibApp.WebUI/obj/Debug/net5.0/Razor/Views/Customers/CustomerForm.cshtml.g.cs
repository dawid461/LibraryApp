#pragma checksum "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8df8fd649d1f4c41c8b9152d55d9580f121fdd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_CustomerForm), @"mvc.1.0.view", @"/Views/Customers/CustomerForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8df8fd649d1f4c41c8b9152d55d9580f121fdd1", @"/Views/Customers/CustomerForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a965c0ffe2b9fb9c737ae41142c57f17cfebab4", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_CustomerForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibApp.WebUI.Models.AddOrUpdateCustomerFormModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";

    var membershipTypes = ViewBag.MembershipTypes as ICollection<LibApp.Application.Core.Dtos.MembershipTypeDto>;
    var title = @Model.Id != 0 ? "Edit customer" : "Update customer";

    ViewBag.Title = title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>");
#nullable restore
#line 13 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n");
#nullable restore
#line 15 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
 using (Html.BeginForm("Save", "Customers"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8df8fd649d1f4c41c8b9152d55d9580f121fdd17102", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 17 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 19 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
   Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 20 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
   Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control form-control-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 21 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
   Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 24 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
   Write(Html.LabelFor(m => m.Birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 25 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
   Write(Html.TextBoxFor(m => m.Birthdate, new { @class = "form-control form-control-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 26 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
   Write(Html.ValidationMessageFor(m => m.Birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 29 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
   Write(Html.LabelFor(m => m.MembershipTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 30 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
   Write(Html.DropDownListFor(m => m.MembershipTypeId, new SelectList(@membershipTypes, "Id", "Name"), "Select Membership Type", new { @class = "form-control form-control-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 31 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
   Write(Html.ValidationMessageFor(m => m.MembershipTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"form-group\">\n        <label class=\"form-check-label\">\n            ");
#nullable restore
#line 35 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
       Write(Html.CheckBoxFor(m => m.HasNewsletterSubscribed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            Subscribed to Newsletter?\n        </label>\n    </div>\n");
#nullable restore
#line 40 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <button type=\"submit\" class=\"btn btn-danger btn-sm\">Save</button>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8df8fd649d1f4c41c8b9152d55d9580f121fdd113185", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 46 "C:\Users\Dawid Czuba\Desktop\zaliczenia uczelnia 2022\projekt asp.net\ASP-LibApp-main\ASP-LibApp-main\LibApp.WebUI\Views\Customers\CustomerForm.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8df8fd649d1f4c41c8b9152d55d9580f121fdd114797", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8df8fd649d1f4c41c8b9152d55d9580f121fdd115895", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibApp.WebUI.Models.AddOrUpdateCustomerFormModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
