#pragma checksum "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69ba74aa846b6cdfe6cae3b82816584fb12846c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Show), @"mvc.1.0.view", @"/Views/Vendors/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Show.cshtml", typeof(AspNetCore.Views_Vendors_Show))]
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
#line 5 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Show.cshtml"
using VendorOrders.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69ba74aa846b6cdfe6cae3b82816584fb12846c7", @"/Views/Vendors/Show.cshtml")]
    public class Views_Vendors_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Show.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(63, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(70, 20, false);
#line 7 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Show.cshtml"
Write(Model["vendor"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(90, 24, true);
            WriteLiteral("</h1>\r\n<h3>Description: ");
            EndContext();
            BeginContext(115, 27, false);
#line 8 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Show.cshtml"
            Write(Model["vendor"].Description);

#line default
#line hidden
            EndContext();
            BeginContext(142, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Show.cshtml"
 if (@Model["orders"].Count == 0)
{

#line default
#line hidden
            BeginContext(189, 47, true);
            WriteLiteral("    <h3>This Vendor has no active Orders</h3>\r\n");
            EndContext();
#line 13 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Show.cshtml"
}

#line default
#line hidden
            BeginContext(239, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Show.cshtml"
 if(@Model["orders"].Count != 0)
{
    

#line default
#line hidden
#line 17 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Show.cshtml"
     foreach (Order order in @Model["orders"])
    {

#line default
#line hidden
            BeginContext(333, 30, true);
            WriteLiteral("        <ul>\r\n            <li>");
            EndContext();
            BeginContext(364, 11, false);
#line 20 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Show.cshtml"
           Write(order.Title);

#line default
#line hidden
            EndContext();
            BeginContext(375, 22, true);
            WriteLiteral("</li>\r\n        </ul>\r\n");
            EndContext();
#line 22 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Show.cshtml"
    }

#line default
#line hidden
#line 22 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Show.cshtml"
     
}

#line default
#line hidden
            BeginContext(407, 4, true);
            WriteLiteral("\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 411, "\'", 457, 3);
            WriteAttributeValue("", 418, "/vendors/", 418, 9, true);
#line 25 "C:\Users\Eric Endsley\OneDrive\Desktop\VendorOrders.Solution\VendorOrders\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 427, Model["vendor"].Id, 427, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 446, "/orders/new", 446, 11, true);
            EndWriteAttribute();
            BeginContext(458, 22, true);
            WriteLiteral(">Add a new Order</a>\r\n");
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
