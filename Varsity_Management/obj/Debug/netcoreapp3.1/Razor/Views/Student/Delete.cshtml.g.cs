#pragma checksum "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78e01901233d02c552c9cf93a254152919e2e88d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Delete), @"mvc.1.0.view", @"/Views/Student/Delete.cshtml")]
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
#line 1 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\_ViewImports.cshtml"
using Varsity_Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\_ViewImports.cshtml"
using Varsity_Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78e01901233d02c552c9cf93a254152919e2e88d", @"/Views/Student/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"242239064e65ca64363c3531ad42027ec00acdde", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Varsity_Management.Models.Student>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.First_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.First_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Last_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Last_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Full_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Full_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Father_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Father_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mother_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mother_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mobile_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Thana));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Thana));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 64 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 70 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Date_Of_Birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Date_Of_Birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 76 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Religions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Religions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 82 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 88 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nationlity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nationlity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 94 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id_card));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id_card));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 100 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Identification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Identification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 106 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 109 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78e01901233d02c552c9cf93a254152919e2e88d16323", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "78e01901233d02c552c9cf93a254152919e2e88d16590", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 115 "C:\Users\Zubayer\Downloads\Varsity_Management\Varsity_Management\Varsity_Management\Views\Student\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78e01901233d02c552c9cf93a254152919e2e88d18410", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Varsity_Management.Models.Student> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
