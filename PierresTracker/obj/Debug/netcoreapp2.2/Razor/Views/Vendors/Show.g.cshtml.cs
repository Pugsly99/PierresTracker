#pragma checksum "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72a96e3c74e6f8b76fab8b2d5679333fc0b3196a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72a96e3c74e6f8b76fab8b2d5679333fc0b3196a", @"/Views/Vendors/Show.cshtml")]
    public class Views_Vendors_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 62, true);
            WriteLiteral("\r\n<h3>Here are all the orders with this vendor:</h3>\r\n\r\n<ol>\r\n");
            EndContext();
#line 6 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
 foreach (Order order in @Model["orders"])
{

#line default
#line hidden
            BeginContext(140, 8, true);
            WriteLiteral("  <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 148, "\'", 201, 4);
            WriteAttributeValue("", 155, "/vendors/", 155, 9, true);
#line 8 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 164, Model["vendor"].Id, 164, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 183, "/orders/", 183, 8, true);
#line 8 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 191, vendor.Id, 191, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(202, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(204, 18, false);
#line 8 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
                                                          Write(vendor.Description);

#line default
#line hidden
            EndContext();
            BeginContext(222, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 9 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
}

#line default
#line hidden
            BeginContext(236, 14, true);
            WriteLiteral("</ol>\r\n\r\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 250, "\'", 296, 3);
            WriteAttributeValue("", 257, "/vendors/", 257, 9, true);
#line 12 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 266, Model["vendor"].Id, 266, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 285, "/orders/new", 285, 11, true);
            EndWriteAttribute();
            BeginContext(297, 122, true);
            WriteLiteral(">Add a new vendor</a></p>\r\n<p><a href=\'/vendors\'>Return to vendor list</a></p>\r\n<p><a href=\'/\'>Return to Main Page</a></p>");
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
