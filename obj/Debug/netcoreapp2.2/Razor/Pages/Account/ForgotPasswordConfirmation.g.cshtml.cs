#pragma checksum "/Users/joeykieboom/Desktop/dot-net-core-theater/Pages/Account/ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a37c467fca105bef9c92556a70a3d27b47fecce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(dotnet_core_theater.Pages.Account.Pages_Account_ForgotPasswordConfirmation), @"mvc.1.0.razor-page", @"/Pages/Account/ForgotPasswordConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Account/ForgotPasswordConfirmation.cshtml", typeof(dotnet_core_theater.Pages.Account.Pages_Account_ForgotPasswordConfirmation), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a37c467fca105bef9c92556a70a3d27b47fecce", @"/Pages/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb204d90565b3f50d5ad77db749844a5a6bfc24", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3afc9ba12e03a806366ac45e5f8466b184e6754d", @"/Pages/Account/_ViewImports.cshtml")]
    public class Pages_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/joeykieboom/Desktop/dot-net-core-theater/Pages/Account/ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Reset confirmation";

#line default
#line hidden
            BeginContext(96, 149, true);
            WriteLiteral("\n<div class=\"login-box-body\">\n    <p class=\"login-box-msg\">Please check your email to reset your password.</p>\n</div>\n<!-- /.login-box-body -->\n    \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForgotPasswordConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmationModel>)PageContext?.ViewData;
        public ForgotPasswordConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591