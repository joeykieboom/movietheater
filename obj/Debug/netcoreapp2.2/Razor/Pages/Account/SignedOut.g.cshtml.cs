#pragma checksum "/Users/joeykieboom/Desktop/dot-net-core-theater/Pages/Account/SignedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7090e65f9920659ee62fd141a190be977e6a0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(dotnet_core_theater.Pages.Account.Pages_Account_SignedOut), @"mvc.1.0.razor-page", @"/Pages/Account/SignedOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Account/SignedOut.cshtml", typeof(dotnet_core_theater.Pages.Account.Pages_Account_SignedOut), null)]
namespace dotnet_core_theater.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/joeykieboom/Desktop/dot-net-core-theater/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/joeykieboom/Desktop/dot-net-core-theater/Pages/_ViewImports.cshtml"
using dotnet_core_theater;

#line default
#line hidden
#line 3 "/Users/joeykieboom/Desktop/dot-net-core-theater/Pages/_ViewImports.cshtml"
using dotnet_core_theater.Data;

#line default
#line hidden
#line 1 "/Users/joeykieboom/Desktop/dot-net-core-theater/Pages/Account/_ViewImports.cshtml"
using dotnet_core_theater.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c7090e65f9920659ee62fd141a190be977e6a0b", @"/Pages/Account/SignedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb204d90565b3f50d5ad77db749844a5a6bfc24", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3afc9ba12e03a806366ac45e5f8466b184e6754d", @"/Pages/Account/_ViewImports.cshtml")]
    public class Pages_Account_SignedOut : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/joeykieboom/Desktop/dot-net-core-theater/Pages/Account/SignedOut.cshtml"
  
    ViewData["Title"] = "Signed out";

#line default
#line hidden
            BeginContext(71, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(77, 17, false);
#line 7 "/Users/joeykieboom/Desktop/dot-net-core-theater/Pages/Account/SignedOut.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 53, true);
            WriteLiteral("</h2>\n<p>\n    You have successfully signed out.\n</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignedOutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SignedOutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SignedOutModel>)PageContext?.ViewData;
        public SignedOutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
