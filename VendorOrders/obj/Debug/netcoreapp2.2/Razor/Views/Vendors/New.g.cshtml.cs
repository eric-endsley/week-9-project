#pragma checksum "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f6f14a7b11a77eb097b226cb0744f75434b0290"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_New), @"mvc.1.0.view", @"/Views/Vendors/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/New.cshtml", typeof(AspNetCore.Views_Vendors_New))]
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
#line 5 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\New.cshtml"
using VendorOrders.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f6f14a7b11a77eb097b226cb0744f75434b0290", @"/Views/Vendors/New.cshtml")]
    public class Views_Vendors_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\New.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(63, 442, true);
            WriteLiteral(@"
<h1>Add a new Vendor</h1>
<p>Fill out the form fields to add a new Vendor</p>

<form action=""/vendors"" method=""post"">
    <label for=""vendorName"">Vendor's name</label>
    <input id=""vendorName"" name=""vendorName"" type=""text"">
    <label for=""vendorDescription"">Brief description of this vendor:</label>
    <input id=""vendorDescription"" name=""vendorDescription"" type=""text"">
    <button type=""submit"">Submit Vendor</button>
</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
