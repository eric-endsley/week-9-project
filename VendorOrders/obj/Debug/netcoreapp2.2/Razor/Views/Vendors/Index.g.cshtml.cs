#pragma checksum "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e5bb001a52c72d9f48dbbc02a02a97bdefd95e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Index), @"mvc.1.0.view", @"/Views/Vendors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Index.cshtml", typeof(AspNetCore.Views_Vendors_Index))]
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
#line 5 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Index.cshtml"
using VendorOrders.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e5bb001a52c72d9f48dbbc02a02a97bdefd95e7", @"/Views/Vendors/Index.cshtml")]
    public class Views_Vendors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(63, 26, true);
            WriteLiteral("\r\n<h1>All Vendors</h1>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(117, 65, true);
            WriteLiteral("    <h3>There are currently no vendors with active orders</h3> \r\n");
            EndContext();
#line 12 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Index.cshtml"
}

#line default
#line hidden
            BeginContext(185, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Index.cshtml"
 foreach (Vendor vendor in Model)
{

#line default
#line hidden
            BeginContext(225, 10, true);
            WriteLiteral("    <h3><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 235, "\"", 261, 2);
            WriteAttributeValue("", 242, "/vendors/", 242, 9, true);
#line 16 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Index.cshtml"
WriteAttributeValue("", 251, vendor.Id, 251, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(262, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(264, 11, false);
#line 16 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Index.cshtml"
                                 Write(vendor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(275, 12, true);
            WriteLiteral("></a></h3>\r\n");
            EndContext();
#line 17 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Index.cshtml"
}

#line default
#line hidden
            BeginContext(290, 47, true);
            WriteLiteral("\r\n<a href=\"/vendors/new\">Add a new Vendor</a>\r\n");
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
