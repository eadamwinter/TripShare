#pragma checksum "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "240543eef47a34e1f692b98a09b1a5f9a3524087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table_Success), @"mvc.1.0.view", @"/Views/Table/Success.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"240543eef47a34e1f692b98a09b1a5f9a3524087", @"/Views/Table/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bffb0b8c9fc2c7e8c8b43c228cf42c91a1d6830", @"/Views/_ViewImports.cshtml")]
    public class Views_Table_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""container-fluid p-2"">
    <div class=""row justify-content-center"">
        <div class=""col-md-12 text-center"">
            <h2>Congratulations, you've just created a group.</h2>
            <h5>
                Now you can add expenses and view share results. 
                Go to the list of groups to find and checkout your group.
            </h5>
        </div>
        <div class=""col-md-12"">
            <button type=""submit"" class=""btn btn-dark""");
            BeginWriteAttribute("value", " value=\"", 482, "\"", 490, 0);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", "\r\n                    onclick=\"", 491, "\"", 571, 3);
            WriteAttributeValue("", 522, "location.href=\'", 522, 15, true);
#nullable restore
#line 15 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\Success.cshtml"
WriteAttributeValue("", 537, Url.Action("Alltables", "Table"), 537, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 570, "\'", 570, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                Go to the group list\r\n            </button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
