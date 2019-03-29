#pragma checksum "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/Movies/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cc08e6c648eae88fd183f9d7ff4e1d362c72216"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Index.cshtml", typeof(AspNetCore.Views_Movies_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cc08e6c648eae88fd183f9d7ff4e1d362c72216", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"717162ba05973d4e82d9f41d57f5d71df1ba9b9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 91, true);
            WriteLiteral("<div class=\"container\">\n    <!--Title and information-->\n    <div class=\"row\">\n        <h1>");
            EndContext();
            BeginContext(110, 11, false);
#line 5 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/Movies/Index.cshtml"
       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(121, 98, true);
            WriteLiteral("</h1>\n    </div>\n    <div class=\"row\">\n        <div class=\"col-md-4\">\n            <img width=\"250\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 219, "\"", 241, 1);
#line 9 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/Movies/Index.cshtml"
WriteAttributeValue("", 225, Model.ImgSource, 225, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(242, 94, true);
            WriteLiteral(" />\n        </div>\n        <div class=\"col-md-4\">\n            <iframe width=\"480\" height=\"375\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 336, "\"", 362, 1);
#line 12 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/Movies/Index.cshtml"
WriteAttributeValue("", 342, Model.TrailerSource, 342, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(363, 106, true);
            WriteLiteral("></iframe>\n        </div>\n    </div>\n    <div class=\"row\">\n        <div class=\"col-md-12\">\n            <p>");
            EndContext();
            BeginContext(470, 17, false);
#line 17 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/Movies/Index.cshtml"
          Write(Model.ReleaseDate);

#line default
#line hidden
            EndContext();
            BeginContext(487, 1158, true);
            WriteLiteral(@"</p>
        </div>
    </div>

    <div class=""bs-stepper"" id=""stepper"">
        <div class=""bs-stepper-header"">
            <!-- your steps here -->
            <div class=""step"" data-target=""#MovieInformation"">
                <button type=""button"" class=""btn btn-link step-trigger"" role=""tab"" aria-controls=""MovieInformation-part"" id=""MovieInformation-trigger"">
                    <span class=""bs-stepper-circle"">1</span>
                    <span class=""bs-stepper-label"">Information</span>
                </button>
            </div>
            <div class=""line""></div>
            <div class=""step"" data-target=""#MovieTimings"">
                <button type=""button"" class=""btn btn-link step-trigger"" role=""tab"" aria-controls=""MovieTimings-part"" id=""MovieTimings-trigger"">
                    <span class=""bs-stepper-circle"">2</span>
                    <span class=""bs-stepper-label"">Timings</span>
                </button>
            </div>
        </div>
        <div class=""bs-stepper-content"">
            <!");
            WriteLiteral("-- your steps content here -->\n           \n        </div>\n    </div>\n    <!--TODO: add order ticket & check if available-->\n</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591