#pragma checksum "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\Home\RegisterResponse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9b9c9ac40e50a7ba3dcb8177038188a4b1b2159"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegisterResponse), @"mvc.1.0.view", @"/Views/Home/RegisterResponse.cshtml")]
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
#line 1 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\_ViewImports.cshtml"
using Lab11._3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\_ViewImports.cshtml"
using Lab11._3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9b9c9ac40e50a7ba3dcb8177038188a4b1b2159", @"/Views/Home/RegisterResponse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1833681048c19863619a2f844d55e2b40dc7dc55", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegisterResponse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\Home\RegisterResponse.cshtml"
  
    ViewData["Title"] = "RegisterResponse";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"heading2\">Thank you for joining!</h1>\r\n<div>\r\n    <p class=\"p\">\r\n        Welcome to our Coffee Cult, ");
#nullable restore
#line 9 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\Home\RegisterResponse.cshtml"
                               Write(ViewData["FN"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\Home\RegisterResponse.cshtml"
                                               Write(ViewData["LN"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("! <br />\r\n        ");
#nullable restore
#line 10 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\Home\RegisterResponse.cshtml"
   Write(ViewData["EM"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" will be your username. We will send you weekly deals to the phone number you provided, ");
#nullable restore
#line 10 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\Home\RegisterResponse.cshtml"
                                                                                                          Write(ViewData["PN"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n    </p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591