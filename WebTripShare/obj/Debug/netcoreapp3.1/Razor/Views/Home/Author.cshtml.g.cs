#pragma checksum "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Home\Author.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd14c093e4bfa28f1df058854fc0c22960d27adc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Author), @"mvc.1.0.view", @"/Views/Home/Author.cshtml")]
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
#line 1 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\_ViewImports.cshtml"
using WebTripShare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\_ViewImports.cshtml"
using WebTripShare.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd14c093e4bfa28f1df058854fc0c22960d27adc", @"/Views/Home/Author.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bffb0b8c9fc2c7e8c8b43c228cf42c91a1d6830", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Author : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Csharp_Logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("C#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 1 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Home\Author.cshtml"
  
    ViewData["Title"] = "About author and privacy policy";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""container p-2"">
        <div class=""row"">
            <div class=""col-md-12"">
                <p>Place for site's privacy policy.</p>

                <p class=""text-justify"">
                    Hi! My name is Adam Wiener and I'm an ASP.NET junior candidate. Thank you for checking my
                    simple web app. I hope you enjoyed it. As mentioned I'm just the beginner and looking forward to know your opinion.
                    I appreciate any constructive criticism ;)
                </p>

                <p class=""text-justify"">During my work besides ASP.NET technologies I was using:</p>
            </div>
        </div>
        <div class=""row"">

            <div class=""col-md-4""></div>
            <div class=""col-md-4"">
                <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">

                    <!-- Wrapper for slides -->
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active""");
            WriteLiteral(@">
                            <div class=""obraz"">
                                <i class=""fab fa-8x fa-bootstrap"" style=""color:darkmagenta""></i>
                            </div>
                        </div>

                        <div class=""carousel-item"">
                            <div class=""obraz"">
                                <i class=""fab fa-8x fa-js"" style=""color:yellow""></i>
                            </div>
                        </div>

                        <div class=""carousel-item"">
                            <div class=""obraz"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bd14c093e4bfa28f1df058854fc0c22960d27adc5767", async() => {
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
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <!-- Left and right controls -->
                    <a class=""carousel-control-prev"" href=""#myCarousel"" data-slide=""prev"">
                        <i class=""fas fa-arrow-left"" style=""color:gray"" aria-hidden=""true""></i>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#myCarousel"" data-slide=""next"">
                        <i class=""fas fa-arrow-right"" aria-hidden=""true"" style=""color:gray""></i>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>

            <div class=""col-md-4""></div>
        </div>

        


        <div class=""row"">
            <div class=""col-md-12"">

                <h4>Contact info</h4>
                <p>Email: eadamwinter@gmail.com</p>
                <link>GitHub: <a href=""");
            WriteLiteral(@"https://github.com/eadamwinter"">https://github.com/eadamwinter</a>

            </div>

            <div class=""col-md-12 mt-1"">
                <div id=""license"" onclick=""showinfo()"">
                    <h5 style=""display:inline"">Show license information</h5>
                </div>
                <div id=""content"" style=""display:none"">
                    <p>The content on this website is licensed under a MIT License.</p>
                    <p class=""text-justify"">
                        Images used in TripShare:
                        <ul>
                            <li>
                                Andres15alvarez, license: CC-BY-SA 4.0 (https://commons.wikimedia.org/wiki/File:Csharp_Logo.png)
                            </li>
                            <li>
                                pinclipart.com, license: Personal Use
                            </li>
                        </ul>
                    </p>
                </div>
            </div>

        </div>
");
            WriteLiteral("    </div>\r\n\r\n<script>\r\n    function showinfo() {\r\n        $(\'#content\').slideToggle();\r\n    }\r\n</script>");
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
