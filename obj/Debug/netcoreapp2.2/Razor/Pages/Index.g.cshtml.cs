#pragma checksum "/Users/joeykieboom/Desktop/dot-net-core-theater/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df1166c85f6b0bfa0ee5c5ad12197dbde0b46b2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(dotnet_core_theater.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(dotnet_core_theater.Pages.Pages_Index), null)]
namespace dotnet_core_theater.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df1166c85f6b0bfa0ee5c5ad12197dbde0b46b2e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb204d90565b3f50d5ad77db749844a5a6bfc24", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/joeykieboom/Desktop/dot-net-core-theater/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(66, 1328, true);
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Blank page
        <small>it all starts here</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li><a href=""#"">Examples</a></li>
        <li class=""active"">Blank page</li>
    </ol>
</section>

<!-- Main content -->
<section class=""content"">

    <!-- Default box -->
    <div class=""box"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Title</h3>

            <div class=""box-tools pull-right"">
                <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"" data-toggle=""tooltip""
                        title=""Collapse"">
                    <i class=""fa fa-minus""></i>
                </button>
                <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove"" data-toggle=""tooltip"" title=""Remove"">
                    <i class=""fa fa-times""></i>
                </button>
            <");
            WriteLiteral(@"/div>
        </div>
        <div class=""box-body"">
            Start creating your amazing application!
        </div>
        <!-- /.box-body -->
        <div class=""box-footer"">
            Footer
        </div>
        <!-- /.box-footer-->
    </div>
    <!-- /.box -->

</section>
<!-- /.content -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591