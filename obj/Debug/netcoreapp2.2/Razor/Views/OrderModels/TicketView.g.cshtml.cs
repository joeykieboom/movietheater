#pragma checksum "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/TicketView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf0977e1b07dd30d26906b7ec5033cbf9a5a56b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderModels_TicketView), @"mvc.1.0.view", @"/Views/OrderModels/TicketView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderModels/TicketView.cshtml", typeof(AspNetCore.Views_OrderModels_TicketView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0977e1b07dd30d26906b7ec5033cbf9a5a56b2", @"/Views/OrderModels/TicketView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"717162ba05973d4e82d9f41d57f5d71df1ba9b9f", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderModels_TicketView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dotnet_core_theater.ViewModels.TicketViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/credit/visa.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Visa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/credit/mastercard.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Mastercard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/credit/american-express.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("American Express"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/credit/paypal2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Paypal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/TicketView.cshtml"
  
    ViewData["Title"] = "TicketView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 269, true);
            WriteLiteral(@"
<!-- Main content -->
<section class=""invoice"">
    <!-- title row -->
    <div class=""row"">
        <div class=""col-xs-12"">
            <h2 class=""page-header"">
                <i class=""fa fa-globe""></i> MovieTheater
                <small class=""pull-right"">Datum: ");
            EndContext();
            BeginContext(414, 19, false);
#line 15 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/TicketView.cshtml"
                                            Write(DateTime.Today.Date);

#line default
#line hidden
            EndContext();
            BeginContext(433, 228, true);
            WriteLiteral("</small>\n            </h2>\n        </div>\n        <!-- /.col -->\n    </div>\n    <!-- info row -->\n    <div class=\"row invoice-info\">\n        <!-- /.col -->\n        <div class=\"col-sm-4 invoice-col\">\n            <b>Order ID:</b> ");
            EndContext();
            BeginContext(662, 32, false);
#line 24 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/TicketView.cshtml"
                        Write(Model.OrderModel.OrderTrackingID);

#line default
#line hidden
            EndContext();
            BeginContext(694, 545, true);
            WriteLiteral(@"<br>
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->
    <!-- Table row -->
    <div class=""row"">
        <div class=""col-xs-12 table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Product</th>
                        <th>Film nummer #</th>
                        <th>Rij</th>
                        <th>Stoel</th>
                        <th>Subtotal</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 43 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/TicketView.cshtml"
                     foreach (TicketModel ticket in Model.OrderModel.Tickets)
                    {

#line default
#line hidden
            BeginContext(1339, 94, true);
            WriteLiteral("                        <tr>\n                            \n                                <td>");
            EndContext();
            BeginContext(1434, 88, false);
#line 47 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/TicketView.cshtml"
                               Write(dotnet_core_theater.Classes.TmdbApi.Instance.GetMovieByID(ticket.Schedule.MovieID).Title);

#line default
#line hidden
            EndContext();
            BeginContext(1522, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1561, 23, false);
#line 48 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/TicketView.cshtml"
                           Write(ticket.Schedule.MovieID);

#line default
#line hidden
            EndContext();
            BeginContext(1584, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1623, 16, false);
#line 49 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/TicketView.cshtml"
                           Write(ticket.TicketRow);

#line default
#line hidden
            EndContext();
            BeginContext(1639, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1678, 17, false);
#line 50 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/TicketView.cshtml"
                           Write(ticket.TicketSeat);

#line default
#line hidden
            EndContext();
            BeginContext(1695, 49, true);
            WriteLiteral("</td>\n                            <td id=\"price\">");
            EndContext();
            BeginContext(1745, 12, false);
#line 51 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/TicketView.cshtml"
                                      Write(ticket.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1757, 36, true);
            WriteLiteral("</td>\n                        </tr>\n");
            EndContext();
#line 53 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/TicketView.cshtml"
                    }

#line default
#line hidden
            BeginContext(1815, 271, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->

    <div class=""row"">
        <!-- accepted payments column -->
        <div class=""col-xs-6"">
            <p class=""lead"">Payment Methods:</p>
            ");
            EndContext();
            BeginContext(2086, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf0977e1b07dd30d26906b7ec5033cbf9a5a56b211585", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2130, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(2143, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf0977e1b07dd30d26906b7ec5033cbf9a5a56b212832", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2199, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(2212, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf0977e1b07dd30d26906b7ec5033cbf9a5a56b214079", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2280, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(2293, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf0977e1b07dd30d26906b7ec5033cbf9a5a56b215326", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2342, 244, true);
            WriteLiteral("\n        </div>\n        <!-- /.col -->\n        <div class=\"col-xs-6\">\n            <div class=\"table-responsive\">\n                <table class=\"table\">\n                    <tr>\n                        <th>Total:</th>\n                        <td>");
            EndContext();
            BeginContext(2587, 11, false);
#line 76 "/Users/joeykieboom/Desktop/dot-net-core-theater/Views/OrderModels/TicketView.cshtml"
                       Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(2598, 808, true);
            WriteLiteral(@"</td>
                    </tr>
                </table>
            </div>
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->
    <!-- this row will not appear when printing -->
    <div class=""row no-print"">
        <div class=""col-xs-12"">
            <a href=""#"" target=""_blank"" class=""btn btn-default"" onclick=""window.print();""><i class=""fa fa-print""></i> Print</a>
            <button type=""button"" class=""btn btn-success pull-right"">
                <i class=""fa fa-credit-card""></i> Submit Payment
            </button>
            <button type=""button"" class=""btn btn-primary pull-right"" style=""margin-right: 5px;"">
                <i class=""fa fa-download""></i> Generate PDF
            </button>
        </div>
    </div>
</section>
<!-- /.content -->
<div class=""clearfix""></div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dotnet_core_theater.ViewModels.TicketViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591