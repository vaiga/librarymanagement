#pragma checksum "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "327cb70bdc79909311a82b5d798030a7d697374c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"327cb70bdc79909311a82b5d798030a7d697374c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a3794e563ac1812bf6f971b55f012b819d5b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Librarymanagement.Models.UserDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(90, 33, true);
            WriteLiteral("\r\n<h2>WELCOME TO LIBRARY</h2>\r\n\r\n");
            EndContext();
            BeginContext(124, 47, false);
#line 8 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\Home\Index.cshtml"
Write(Html.ActionLink("Register", "Register", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(171, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(174, 41, false);
#line 9 "C:\Users\Administrator\source\repos\Librarymanagement\Librarymanagement\Views\Home\Index.cshtml"
Write(Html.ActionLink("Login", "Login", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(215, 40, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Librarymanagement.Models.UserDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
