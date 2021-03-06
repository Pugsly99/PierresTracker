#pragma checksum "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33e0e92984e6a5c80bf030a763661b5c855b1f0f"
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
#line 1 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
using PierresTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e0e92984e6a5c80bf030a763661b5c855b1f0f", @"/Views/Vendors/Show.cshtml")]
    public class Views_Vendors_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 56, true);
            WriteLiteral("\r\n<h3>Here are all the orders with this vendor:</h3>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
 if (@Model["orders"].Count == 0)
{

#line default
#line hidden
            BeginContext(125, 43, true);
            WriteLiteral("  <h3>No orders have been added yet!</h3>\r\n");
            EndContext();
#line 8 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
}

#line default
#line hidden
            BeginContext(171, 8, true);
            WriteLiteral("\r\n<ol>\r\n");
            EndContext();
#line 11 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
   foreach (Order order in @Model["orders"])
  {

#line default
#line hidden
            BeginContext(230, 10, true);
            WriteLiteral("    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 240, "\'", 292, 4);
            WriteAttributeValue("", 247, "/vendors/", 247, 9, true);
#line 13 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 256, Model["vendor"].Id, 256, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 275, "/orders/", 275, 8, true);
#line 13 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 283, order.Id, 283, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(293, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(295, 11, false);
#line 13 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
                                                           Write(order.Title);

#line default
#line hidden
            EndContext();
            BeginContext(306, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 14 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
  }

#line default
#line hidden
            BeginContext(322, 14, true);
            WriteLiteral("</ol>\r\n\r\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 336, "\'", 382, 3);
            WriteAttributeValue("", 343, "/vendors/", 343, 9, true);
#line 17 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 352, Model["vendor"].Id, 352, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 371, "/orders/new", 371, 11, true);
            EndWriteAttribute();
            BeginContext(383, 33, true);
            WriteLiteral(">Add a new order</a></p>\r\n\r\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 416, "\'", 454, 3);
            WriteAttributeValue("", 425, "/vendors/", 425, 9, true);
#line 19 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 434, Model["vendor"].Id, 434, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 453, "/", 453, 1, true);
            EndWriteAttribute();
            BeginContext(455, 67, true);
            WriteLiteral(" method=\"post\">\r\n<button type=\"submit\">Delete all orders belonging ");
            EndContext();
            BeginContext(523, 20, false);
#line 20 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
                                             Write(Model["vendor"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(543, 117, true);
            WriteLiteral("</button>\r\n</form>\r\n\r\n<p><a href=\'/vendors\'>Return to vendor list</a></p>\r\n<p><a href=\'/\'>Return to Main Page</a></p>");
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
