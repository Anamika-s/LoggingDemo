#pragma checksum "C:\Users\adminvm.adminvm\source\repos\LoggingDemo\LoggingDemo\Views\Home\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3108852317bbd0ba0292cbc9bc0def6ceff0995"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index1), @"mvc.1.0.view", @"/Views/Home/Index1.cshtml")]
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
#line 1 "C:\Users\adminvm.adminvm\source\repos\LoggingDemo\LoggingDemo\Views\_ViewImports.cshtml"
using LoggingDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adminvm.adminvm\source\repos\LoggingDemo\LoggingDemo\Views\_ViewImports.cshtml"
using LoggingDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3108852317bbd0ba0292cbc9bc0def6ceff0995", @"/Views/Home/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"758a5d602b3a80341845b477dd985b291f1b5714", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\adminvm.adminvm\source\repos\LoggingDemo\LoggingDemo\Views\Home\Index1.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-left"">
    <p>
        <a href=""/NoSuchPage"">
            Request an endpoint that doesn't exist. Trigger a 404
        </a>.
    </p>
    <p><a href=""/home/index/1"">Trigger an exceptionn</a>.</p>
    <p><a href=""/home/index/2"">Return a 500 error.</a>.</p>
</div>
");
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
