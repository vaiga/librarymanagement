#pragma checksum "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e46a0665388df76e81c062ae8dcf87113514d60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_books_delete), @"mvc.1.0.view", @"/Views/books/delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/books/delete.cshtml", typeof(AspNetCore.Views_books_delete))]
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
#line 1 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\_ViewImports.cshtml"
using Librarymanagement;

#line default
#line hidden
#line 2 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\_ViewImports.cshtml"
using Librarymanagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e46a0665388df76e81c062ae8dcf87113514d60", @"/Views/books/delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a3794e563ac1812bf6f971b55f012b819d5b74", @"/Views/_ViewImports.cshtml")]
    public class Views_books_delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Librarymanagement.Models.librarymodel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BOOKS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(88, 52, true);
            WriteLiteral("\r\n<h2>DELETE</h2>\r\n\r\n\r\n<div>\r\n    \r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(140, 1525, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab9697fb8b1d4009aadcffc3f9796e27", async() => {
                BeginContext(166, 72, true);
                WriteLiteral("\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(239, 42, false);
#line 16 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.DisplayNameFor(model => model.BookId));

#line default
#line hidden
                EndContext();
                BeginContext(281, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(300, 37, false);
#line 17 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.HiddenFor(model => model.BookId));

#line default
#line hidden
                EndContext();
                BeginContext(337, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(393, 38, false);
#line 20 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.DisplayFor(model => model.BookId));

#line default
#line hidden
                EndContext();
                BeginContext(431, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(487, 44, false);
#line 23 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.DisplayNameFor(model => model.BookName));

#line default
#line hidden
                EndContext();
                BeginContext(531, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(550, 39, false);
#line 24 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.HiddenFor(model => model.BookName));

#line default
#line hidden
                EndContext();
                BeginContext(589, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(645, 40, false);
#line 27 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.DisplayFor(model => model.BookName));

#line default
#line hidden
                EndContext();
                BeginContext(685, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(741, 53, false);
#line 30 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.DisplayNameFor(model => model.BookPublishedYear));

#line default
#line hidden
                EndContext();
                BeginContext(794, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(813, 48, false);
#line 31 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.HiddenFor(model => model.BookPublishedYear));

#line default
#line hidden
                EndContext();
                BeginContext(861, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(917, 49, false);
#line 34 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.DisplayFor(model => model.BookPublishedYear));

#line default
#line hidden
                EndContext();
                BeginContext(966, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1022, 46, false);
#line 37 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.DisplayNameFor(model => model.BookAuthor));

#line default
#line hidden
                EndContext();
                BeginContext(1068, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1087, 41, false);
#line 38 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.HiddenFor(model => model.BookAuthor));

#line default
#line hidden
                EndContext();
                BeginContext(1128, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1184, 42, false);
#line 41 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.DisplayFor(model => model.BookAuthor));

#line default
#line hidden
                EndContext();
                BeginContext(1226, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1282, 48, false);
#line 44 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.DisplayNameFor(model => model.BookCategory));

#line default
#line hidden
                EndContext();
                BeginContext(1330, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1349, 43, false);
#line 45 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.HiddenFor(model => model.BookCategory));

#line default
#line hidden
                EndContext();
                BeginContext(1392, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1448, 44, false);
#line 48 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\books\delete.cshtml"
           Write(Html.DisplayFor(model => model.BookCategory));

#line default
#line hidden
                EndContext();
                BeginContext(1492, 121, true);
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        <input type=\"submit\" value=\"Delete\"  class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1613, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcbac0212aed44b6b406bdbf06ae352d", async() => {
                    BeginContext(1635, 13, true);
                    WriteLiteral("BACK TO BOOKS");
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
                BeginContext(1652, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1665, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Librarymanagement.Models.librarymodel> Html { get; private set; }
    }
}
#pragma warning restore 1591
