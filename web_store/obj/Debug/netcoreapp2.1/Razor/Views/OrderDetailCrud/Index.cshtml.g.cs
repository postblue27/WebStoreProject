#pragma checksum "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "355564fc20dbbebfd42bfc337e3cfc551e00bb72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetailCrud_Index), @"mvc.1.0.view", @"/Views/OrderDetailCrud/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderDetailCrud/Index.cshtml", typeof(AspNetCore.Views_OrderDetailCrud_Index))]
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
#line 1 "c:\Users\nazar\Desktop\web_store\Views\_ViewImports.cshtml"
using web_store;

#line default
#line hidden
#line 2 "c:\Users\nazar\Desktop\web_store\Views\_ViewImports.cshtml"
using web_store.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"355564fc20dbbebfd42bfc337e3cfc551e00bb72", @"/Views/OrderDetailCrud/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ad3b04c7f2246e0e9f726190845c8e8951978e", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderDetailCrud_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<web_store.Models.OrderDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_CrudLayout.cshtml";

#line default
#line hidden
            BeginContext(138, 82, true);
            WriteLiteral("\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(221, 42, false);
#line 13 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(263, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(316, 41, false);
#line 16 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(357, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(410, 43, false);
#line 19 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
            EndContext();
            BeginContext(453, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(506, 49, false);
#line 22 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Order.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(555, 58, true);
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 27 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
   decimal totalPrice = 0;

#line default
#line hidden
#line 28 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(672, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(719, 41, false);
#line 32 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(760, 36, true);
            WriteLiteral("\n            </td>\n            <td>\n");
            EndContext();
#line 35 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
                  var Total = item.Price * item.Amount;

#line default
#line hidden
            BeginContext(853, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(870, 5, false);
#line 36 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
           Write(Total);

#line default
#line hidden
            EndContext();
            BeginContext(875, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(928, 47, false);
#line 39 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(975, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1028, 48, false);
#line 42 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Order.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 36, true);
            WriteLiteral("\n            </td>\n            <td>\n");
            EndContext();
#line 45 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
                  totalPrice += Total;

#line default
#line hidden
            BeginContext(1152, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 49 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1187, 59, true);
            WriteLiteral("        <tr>\n            <th>\n                Total price: ");
            EndContext();
            BeginContext(1247, 10, false);
#line 52 "c:\Users\nazar\Desktop\web_store\Views\OrderDetailCrud\Index.cshtml"
                        Write(totalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1257, 55, true);
            WriteLiteral("\n            </th>\n        </tr>\n    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<web_store.Models.OrderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
