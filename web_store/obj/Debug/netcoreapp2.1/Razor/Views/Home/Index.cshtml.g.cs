#pragma checksum "c:\Users\nazar\Desktop\web_store\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daa15c4c65e28f515323c29609f00f420268963c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daa15c4c65e28f515323c29609f00f420268963c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ad3b04c7f2246e0e9f726190845c8e8951978e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<web_store.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(45, 35, false);
#line 4 "c:\Users\nazar\Desktop\web_store\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("Carousel"));

#line default
#line hidden
            EndContext();
            BeginContext(80, 141, true);
            WriteLiteral("\n\n<div>\n    <h2 class=\"text-center\">Recommended products</h2>\n    <h4 class=\"text-center\">Our selection for you</h4>\n\n    <div class=\"row\">\n\n");
            EndContext();
#line 12 "c:\Users\nazar\Desktop\web_store\Views\Home\Index.cshtml"
         foreach (var product in Model.SuggestedProducts)
        {
            

#line default
#line hidden
            BeginContext(302, 60, false);
#line 14 "c:\Users\nazar\Desktop\web_store\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("SuggestedProductsSummary", product));

#line default
#line hidden
            EndContext();
#line 14 "c:\Users\nazar\Desktop\web_store\Views\Home\Index.cshtml"
                                                                         
        }

#line default
#line hidden
            BeginContext(373, 18, true);
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<web_store.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591