#pragma checksum "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/Partials/MoviesToday.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "721f851315af959fbc8bd4f8a35a9e2782b3afb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials_MoviesToday), @"mvc.1.0.view", @"/Views/Partials/MoviesToday.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partials/MoviesToday.cshtml", typeof(AspNetCore.Views_Partials_MoviesToday))]
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
#line 1 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/_ViewImports.cshtml"
using dotnet_core_theater;

#line default
#line hidden
#line 3 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/_ViewImports.cshtml"
using dotnet_core_theater.Data;

#line default
#line hidden
#line 4 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/_ViewImports.cshtml"
using dotnet_core_theater.Controllers;

#line default
#line hidden
#line 5 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/_ViewImports.cshtml"
using dotnet_core_theater.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721f851315af959fbc8bd4f8a35a9e2782b3afb1", @"/Views/Partials/MoviesToday.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"717162ba05973d4e82d9f41d57f5d71df1ba9b9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials_MoviesToday : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ScheduleModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(145, 74, true);
            WriteLiteral("\n\n<div class=\"container\">\n    <div class=\"row\" style=\"margin-left:50px;\">\n");
            EndContext();
#line 8 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/Partials/MoviesToday.cshtml"
         foreach (ScheduleModel schedule in Model.Where(i=>i.Starttime.Date == DateTime.Today).ToList())
        {

#line default
#line hidden
            BeginContext(334, 51, true);
            WriteLiteral("            <div class=\"col-md-4\">\n                ");
            EndContext();
            BeginContext(386, 103, false);
#line 11 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/Partials/MoviesToday.cshtml"
           Write(await Html.PartialAsync("~/Views/Partials/MovieCard.cshtml", MovieModel.GetModelByID(schedule.MovieID)));

#line default
#line hidden
            EndContext();
            BeginContext(489, 20, true);
            WriteLiteral("\n            </div>\n");
            EndContext();
#line 13 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/Partials/MoviesToday.cshtml"
        }

#line default
#line hidden
            BeginContext(519, 18, true);
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ScheduleModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
