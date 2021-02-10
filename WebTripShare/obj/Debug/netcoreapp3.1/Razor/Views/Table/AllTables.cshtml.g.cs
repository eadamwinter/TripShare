#pragma checksum "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\AllTables.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac01282551bf65fc3f27475bd1ef37edba4db276"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table_AllTables), @"mvc.1.0.view", @"/Views/Table/AllTables.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac01282551bf65fc3f27475bd1ef37edba4db276", @"/Views/Table/AllTables.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bffb0b8c9fc2c7e8c8b43c228cf42c91a1d6830", @"/Views/_ViewImports.cshtml")]
    public class Views_Table_AllTables : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TripShare.TableInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Table", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\AllTables.cshtml"
   
    ViewData["Title"] = "All groups";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""jumbotron jumbotron-fluid p-5"" style=""background-color:lightgray"">
        <div class=""container"">
            <p class=""text-justify"">
                Below You will find all groups created in application to share trip costs between its members.
                Please press the button ""Show results"" for more information about each specific group.
            </p>
");
#nullable restore
#line 13 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\AllTables.cshtml"
             if(Model.Count>1) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"text-justify\">Currently there are ");
#nullable restore
#line 14 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\AllTables.cshtml"
                                                       Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" groups in the database.</p>\r\n");
#nullable restore
#line 15 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\AllTables.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"text-justify\">Currently there is only ");
#nullable restore
#line 17 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\AllTables.cshtml"
                                                           Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" group in the database.</p>\r\n");
#nullable restore
#line 18 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\AllTables.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row justify-content-around\">\r\n");
#nullable restore
#line 25 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\AllTables.cshtml"
             foreach (var table in Model)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 text-center border border-secondary m-2\">\r\n                    <p>Group id: ");
#nullable restore
#line 29 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\AllTables.cshtml"
                            Write(table.TableInfoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h4>Name: ");
#nullable restore
#line 30 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\AllTables.cshtml"
                         Write(table.TableName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac01282551bf65fc3f27475bd1ef37edba4db2767563", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac01282551bf65fc3f27475bd1ef37edba4db2767845", async() => {
                    WriteLiteral("Show results");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\AllTables.cshtml"
                                                                                                WriteLiteral(table.TableInfoId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 35 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Table\AllTables.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TripShare.TableInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
