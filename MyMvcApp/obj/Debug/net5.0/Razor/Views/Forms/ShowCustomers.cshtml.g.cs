#pragma checksum "C:\Users\sajit\OneDrive\Documents\Asp.net\Git-PC\Net 5\MyMvcApp\Views\Forms\ShowCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2497d306ffcd71aaa949f87a193af1725c9b501"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forms_ShowCustomers), @"mvc.1.0.view", @"/Views/Forms/ShowCustomers.cshtml")]
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
#line 1 "C:\Users\sajit\OneDrive\Documents\Asp.net\Git-PC\Net 5\MyMvcApp\Views\_ViewImports.cshtml"
using MyMvcApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sajit\OneDrive\Documents\Asp.net\Git-PC\Net 5\MyMvcApp\Views\_ViewImports.cshtml"
using MyMvcApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2497d306ffcd71aaa949f87a193af1725c9b501", @"/Views/Forms/ShowCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26db36bd847b90d15a602f19fbeb25b0edb35a91", @"/Views/_ViewImports.cshtml")]
    public class Views_Forms_ShowCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyMvcApp.Models.CustomerModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Customers</h2>

<table class=""table"">
    <thead>
        <tr>
            <td>Customer NIC</td>
            <td>Customer Name</td>
            <td>Customer Address</td>
            <td>Contact NO</td>
            
        </tr>
        <tbody>
");
#nullable restore
#line 15 "C:\Users\sajit\OneDrive\Documents\Asp.net\Git-PC\Net 5\MyMvcApp\Views\Forms\ShowCustomers.cshtml"
             foreach (var customer in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\sajit\OneDrive\Documents\Asp.net\Git-PC\Net 5\MyMvcApp\Views\Forms\ShowCustomers.cshtml"
                   Write(customer.NIC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\sajit\OneDrive\Documents\Asp.net\Git-PC\Net 5\MyMvcApp\Views\Forms\ShowCustomers.cshtml"
                   Write(customer.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\sajit\OneDrive\Documents\Asp.net\Git-PC\Net 5\MyMvcApp\Views\Forms\ShowCustomers.cshtml"
                   Write(customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\sajit\OneDrive\Documents\Asp.net\Git-PC\Net 5\MyMvcApp\Views\Forms\ShowCustomers.cshtml"
                   Write(customer.ContactNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    \r\n                </tr>\r\n");
#nullable restore
#line 24 "C:\Users\sajit\OneDrive\Documents\Asp.net\Git-PC\Net 5\MyMvcApp\Views\Forms\ShowCustomers.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </thead>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyMvcApp.Models.CustomerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
