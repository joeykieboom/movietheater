#pragma checksum "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee77cc79ad0ea64871a3fc6aac8cb0c3b73b4c50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderModels_Create), @"mvc.1.0.view", @"/Views/OrderModels/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderModels/Create.cshtml", typeof(AspNetCore.Views_OrderModels_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee77cc79ad0ea64871a3fc6aac8cb0c3b73b4c50", @"/Views/OrderModels/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"717162ba05973d4e82d9f41d57f5d71df1ba9b9f", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderModels_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dotnet_core_theater.ViewModels.OrderCreateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrderModels", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 114, true);
            WriteLiteral("<div class=\"container\">\n    <div class=\"row\" style=\"margin-left:50px;\">\n        <div class=\"row\">\n            <h1>");
            EndContext();
            BeginContext(260, 22, false);
#line 10 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
           Write(Model.MovieModel.Title);

#line default
#line hidden
            EndContext();
            BeginContext(282, 114, true);
            WriteLiteral("</h1>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-md-4\">\n                <img width=\"250\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 396, "\"", 429, 1);
#line 14 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
WriteAttributeValue("", 402, Model.MovieModel.ImgSource, 402, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(430, 106, true);
            WriteLiteral(" />\n            </div>\n            <div class=\"col-md-4\">\n                <iframe width=\"480\" height=\"375\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 536, "\"", 573, 1);
#line 17 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
WriteAttributeValue("", 542, Model.MovieModel.TrailerSource, 542, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(574, 126, true);
            WriteLiteral("></iframe>\n            </div>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-md-12\">\n                <p>");
            EndContext();
            BeginContext(701, 28, false);
#line 22 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
              Write(Model.MovieModel.ReleaseDate);

#line default
#line hidden
            EndContext();
            BeginContext(729, 632, true);
            WriteLiteral(@"</p>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""nav-tabs-custom"">
                <ul class=""nav nav-tabs"">
                    <li class=""active""><a href=""#tab_1"" data-toggle=""tab"">Informatie</a></li>
                    <li><a href=""#tab_2"" data-toggle=""tab"">Tijden</a></li>
                </ul>
                <div class=""tab-content"">
                    <div class=""tab-pane active"" id=""tab_1"">
                        <div id=""MovieInformation"" class=""content"">
                            <div class=""row"">
                                <h3>");
            EndContext();
            BeginContext(1362, 28, false);
#line 37 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
                               Write(Model.MovieModel.Information);

#line default
#line hidden
            EndContext();
            BeginContext(1390, 92, true);
            WriteLiteral("</h3>\n                                <br />\n                                <h2>Cast:</h2>\n");
            EndContext();
#line 40 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
                                 foreach (TMDbLib.Objects.Movies.Cast cast in Model.MovieModel.Cast)
                                {

#line default
#line hidden
            BeginContext(1617, 39, true);
            WriteLiteral("                                    <p>");
            EndContext();
            BeginContext(1657, 9, false);
#line 42 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
                                  Write(cast.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1666, 4, true);
            WriteLiteral(" -- ");
            EndContext();
            BeginContext(1671, 14, false);
#line 42 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
                                                Write(cast.Character);

#line default
#line hidden
            EndContext();
            BeginContext(1685, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 43 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
                                }

#line default
#line hidden
            BeginContext(1724, 242, true);
            WriteLiteral("                            </div>\n                    \n                        </div>\n                    </div>\n                    <div class=\"tab-pane\" id=\"tab_2\">\n                        <h3>Deze film draait op de volgende tijden:</h3>\n\n");
            EndContext();
#line 51 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
                         foreach (ScheduleModel schedule in Model.SchedulesModel)
                        {

#line default
#line hidden
            BeginContext(2074, 79, true);
            WriteLiteral("                            <div class=\"row\">\n\n                                ");
            EndContext();
            BeginContext(2153, 656, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee77cc79ad0ea64871a3fc6aac8cb0c3b73b4c5010079", async() => {
                BeginContext(2222, 104, true);
                WriteLiteral("\n                                    <div class=\"col-md-2\">\n                                        <h4>");
                EndContext();
                BeginContext(2327, 28, false);
#line 57 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
                                       Write(schedule.Starttime.TimeOfDay);

#line default
#line hidden
                EndContext();
                BeginContext(2355, 10, true);
                WriteLiteral(" in zaal: ");
                EndContext();
                BeginContext(2366, 24, false);
#line 57 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
                                                                              Write(schedule.Hall.HallNumber);

#line default
#line hidden
                EndContext();
                BeginContext(2390, 186, true);
                WriteLiteral("</h4>\n                                    </div>\n                                    <div class=\"col-md-2\">\n                                        <input type=\"hidden\" name=\"scheduleID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2576, "\"", 2604, 1);
#line 60 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
WriteAttributeValue("", 2584, schedule.ScheduleID, 2584, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2605, 47, true);
                WriteLiteral(" />\n                                    </div>\n");
                EndContext();
#line 62 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
                                      await Html.RenderPartialAsync("~/Views/Partials/SeatPicker.cshtml", schedule);

#line default
#line hidden
                BeginContext(2770, 32, true);
                WriteLiteral("                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2809, 36, true);
            WriteLiteral("\n                            </div>\n");
            EndContext();
#line 65 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/Create.cshtml"
                        }

#line default
#line hidden
            BeginContext(2871, 171, true);
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n    <div class=\"row\" style=\"margin-left:50px;\">\n        \n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dotnet_core_theater.ViewModels.OrderCreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591