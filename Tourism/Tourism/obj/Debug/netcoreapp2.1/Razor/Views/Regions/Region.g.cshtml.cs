#pragma checksum "D:\C#\Tourism\Tourism\Tourism\Views\Regions\Region.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b65517f99699c1559302ec0bc8d5d270311d80dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Regions_Region), @"mvc.1.0.view", @"/Views/Regions/Region.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Regions/Region.cshtml", typeof(AspNetCore.Views_Regions_Region))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b65517f99699c1559302ec0bc8d5d270311d80dd", @"/Views/Regions/Region.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae47864ffb5aac3f7af70908e2ed5600b4864add", @"/Views/_ViewImports.cshtml")]
    public class Views_Regions_Region : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tourism.Data.Models.Region>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/church_kyiv.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/park_odessa.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/hotel_zaporozhye.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/resorts_dnipropetrovsk.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/castle_odessa.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/museum_kharkiv.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 100, true);
            WriteLiteral("\r\n<div class=\"jumbotron jumbotron-fluid height100p content\">\r\n    <div class=\"region\">\r\n        <h1>");
            EndContext();
            BeginContext(136, 10, false);
#line 5 "D:\C#\Tourism\Tourism\Tourism\Views\Regions\Region.cshtml"
       Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(146, 211, true);
            WriteLiteral("</h1>\r\n    </div>\r\n    <div id=\"carouselExampleSlidesOnly\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <div class=\"carousel-inner\">\r\n            <div class=\"carousel-item active\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 357, "\"", 378, 2);
            WriteAttributeValue("", 363, "/img/", 363, 5, true);
#line 10 "D:\C#\Tourism\Tourism\Tourism\Views\Regions\Region.cshtml"
WriteAttributeValue("", 368, Model.img, 368, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(379, 715, true);
            WriteLiteral(@" class=""d-block w-100"" alt=""..."">
            </div>
            <!--<div class=""carousel-item"">
                  <img src=""../img/' . $name . '_slider2.jpg"" class=""d-block w-100"" alt=""..."">
            </div>
              <div class=""carousel-item"">
                  <img src=""../img/' . $name . '_slider3.jpg"" class=""d-block w-100"" alt=""..."">
              </div>
              -->
        </div>
    </div>
</div>
<section class=""sec1"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-4"" data-aos=""fade-up""
                 data-aos-duration=""1000""
                 data-aos-delay=""1000"">
                <div class=""placeBox Box1"">
                    ");
            EndContext();
            BeginContext(1095, 9, false);
#line 29 "D:\C#\Tourism\Tourism\Tourism\Views\Regions\Region.cshtml"
               Write(Model.map);

#line default
#line hidden
            EndContext();
            BeginContext(1104, 299, true);
            WriteLiteral(@"
                </div>
            </div>

            <div class=""col-sm-4"" data-aos=""fade-up""
                 data-aos-duration=""1000""
                 data-aos-delay=""1000"">
                <div class=""placeBox Box2"">
                    <div class=""info"">
                        <h2>");
            EndContext();
            BeginContext(1404, 10, false);
#line 38 "D:\C#\Tourism\Tourism\Tourism\Views\Regions\Region.cshtml"
                       Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(1414, 34, true);
            WriteLiteral("</h2>\r\n                        <p>");
            EndContext();
            BeginContext(1449, 17, false);
#line 39 "D:\C#\Tourism\Tourism\Tourism\Views\Regions\Region.cshtml"
                      Write(Model.description);

#line default
#line hidden
            EndContext();
            BeginContext(1466, 847, true);
            WriteLiteral(@"<p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""blog"">
    <div class=""container"">
        <div class=""row"">
            <div class=""offset-sm-2 col-sm-8"">
                <div class=""headerText"">
                    <h2 data-aos=""fade-up""
                        data-aos-duration=""1000""
                        data-aos-delay=""0"">
                        ???? ????????????????
                    </h2>
                    <p></p>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-sm-6"" data-aos=""fade-up""
                 data-aos-duration=""250""
                 data-aos-delay=""500"">
                <div class=""blogpost"">
                    <div class=""imgBx"">
                        ");
            EndContext();
            BeginContext(2313, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8ffe441c3854fe9b0609d98b347c1a5", async() => {
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
            BeginContext(2364, 595, true);
            WriteLiteral(@"
                    </div>
                    <div class=""content"">
                        <h1>??????????</h1>
                        <p>?????????????? ??????????????</p>
                        <a href=""#"" class=""btn btnD2"">??????????</a>
                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6"" data-aos=""fade-down""
                 data-aos-duration=""250""
                 data-aos-delay=""500"">
                <div class=""blogpost"">
                    <div class=""imgBx"">
                        ");
            EndContext();
            BeginContext(2959, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a89074fad31449c3af59636392c73e7c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3010, 596, true);
            WriteLiteral(@"
                    </div>
                    <div class=""content"">
                        <h1>??????????</h1>
                        <p>???????????????? ??????????????</p>
                        <a href=""#"" class=""btn btnD2"">??????????</a>
                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6"" data-aos=""fade-down""
                 data-aos-duration=""250""
                 data-aos-delay=""500"">
                <div class=""blogpost"">
                    <div class=""imgBx"">
                        ");
            EndContext();
            BeginContext(3606, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "33efa17f86874f53851c7d871f0ef8c1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3662, 595, true);
            WriteLiteral(@"
                    </div>
                    <div class=""content"">
                        <h1>????????????</h1>
                        <p>???? ????????????????????????</p>
                        <a href=""#"" class=""btn btnD2"">????????????</a>
                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6"" data-aos=""fade-up""
                 data-aos-duration=""250""
                 data-aos-delay=""500"">
                <div class=""blogpost"">
                    <div class=""imgBx"">
                        ");
            EndContext();
            BeginContext(4257, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3cb6f5615a8466d9892246c1cf57957", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4319, 599, true);
            WriteLiteral(@"

                    </div>
                    <div class=""content"">
                        <h1>??????????????</h1>
                        <p>?????????? ??????????????????</p>
                        <a href=""#"" class=""btn btnD2"">??????????????</a>
                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6"" data-aos=""fade-up""
                 data-aos-duration=""250""
                 data-aos-delay=""500"">
                <div class=""blogpost"">
                    <div class=""imgBx"">
                        ");
            EndContext();
            BeginContext(4918, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "49e6ede6e209400790cbc9717a896134", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4971, 603, true);
            WriteLiteral(@"

                    </div>
                    <div class=""content"">
                        <h1>??????????????</h1>
                        <p>???????????? ???? ??????????????</p>
                        <a href=""#"" class=""btn btnD2"">??????????????</a>
                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6"" data-aos=""fade-down""
                 data-aos-duration=""250""
                 data-aos-delay=""500"">
                <div class=""blogpost"">
                    <div class=""imgBx"">
                        ");
            EndContext();
            BeginContext(5574, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6e313445c8104174a11a0ff3d8db20ca", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5628, 400, true);
            WriteLiteral(@"

                    </div>
                    <div class=""content"">
                        <h1>??????????</h1>
                        <p>?????????? ???? ????????????????????</p>
                        <a href=""#"" class=""btn btnD2"">??????????</a>
                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tourism.Data.Models.Region> Html { get; private set; }
    }
}
#pragma warning restore 1591
