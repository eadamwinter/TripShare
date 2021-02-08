#pragma checksum "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af48ebe6e526768aeb3b40c5863e374981c7946e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af48ebe6e526768aeb3b40c5863e374981c7946e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bffb0b8c9fc2c7e8c8b43c228cf42c91a1d6830", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Adam PRO-ROB\source\gitrepos\GitTripShare\WebTripShare\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-1""></div>
        <div class=""col-10"">
            <h2 class=""text-center p-3"">Welcome in TripShare!</h2>
            
            <p class=""text-justify"">It's a simple application that allows to calculate expenses shared by a group.</p>
            
            <p class=""text-justify"">First of all you have to create your own group, add its name and members. You can 
            do it by pressing <i>Create group</i> in the navigation bar. For now the application doesn't allow to add/delete/modify
            members of already created groups. Sorry for the inconvenience.</p>

            <p class=""text-justify"">Once you've created your group you will be able to add some expenses.
            Information that are included in every expense are:
                <ul class=""font-weight-bold"">
                    <li>Name: the person who pays the cost</li>
                    <li>Amount: the amount of the expense will be shared among chosen members</li>");
            WriteLiteral(@"
                    <li>Date and time: this field will be generated automatically</li>
                    <li>Members invloved: names of the members you want to share the cost with</li>
                    <li>Comment: this is optional field to write down some note</li>
                </ul>
            </p>

            <p class=""text-justify"">Next please go to <i>All groups</i>, choose one and press 
            <i>Show results</i>. There you can find calculated share results. They are telling in a clean and simple
            manner which member or members own how much and to whom. For more specyfics you can also check 
            <i>View details</i> There you will see the whole list of added expenses.</p>

            <p class=""text-justify"">I hope you will enjoy TripShare. You can also visit <i>About</i> in the footer for
            more information about the author and other applications.</p>

        </div>
        <div class=""col-1""></div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
