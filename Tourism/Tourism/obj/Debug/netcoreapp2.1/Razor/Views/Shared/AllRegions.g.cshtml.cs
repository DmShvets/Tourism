#pragma checksum "D:\C#\Tourism\Tourism\Tourism\Views\Shared\AllRegions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50467bc43adabf87f3986ca75571846a55628d35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllRegions), @"mvc.1.0.view", @"/Views/Shared/AllRegions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/AllRegions.cshtml", typeof(AspNetCore.Views_Shared_AllRegions))]
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
#line 1 "D:\C#\Tourism\Tourism\Tourism\Views\_ViewImports.cshtml"
using Tourism.ViewModels;

#line default
#line hidden
#line 2 "D:\C#\Tourism\Tourism\Tourism\Views\_ViewImports.cshtml"
using Tourism.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50467bc43adabf87f3986ca75571846a55628d35", @"/Views/Shared/AllRegions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae47864ffb5aac3f7af70908e2ed5600b4864add", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AllRegions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tourism.Data.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 26, true);
            WriteLiteral("\r\n<a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 63, "\"", 103, 2);
            WriteAttributeValue("", 70, "/Regions/List/", 70, 14, true);
#line 3 "D:\C#\Tourism\Tourism\Tourism\Views\Shared\AllRegions.cshtml"
WriteAttributeValue("", 84, Model.categoryName, 84, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(104, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(107, 18, false);
#line 3 "D:\C#\Tourism\Tourism\Tourism\Views\Shared\AllRegions.cshtml"
                                                              Write(Model.categoryName);

#line default
#line hidden
            EndContext();
            BeginContext(125, 42, true);
            WriteLiteral("</a>\r\n<div class=\"dropdown-divider\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tourism.Data.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591