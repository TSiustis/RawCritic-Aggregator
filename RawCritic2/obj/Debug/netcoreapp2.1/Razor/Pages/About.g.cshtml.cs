#pragma checksum "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c17821ad5114c8ef51c712988e514e28d4f63ed4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RawCritic2.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(RawCritic2.Pages.Pages_About), null)]
namespace RawCritic2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\_ViewImports.cshtml"
using RawCritic2;

#line default
#line hidden
#line 3 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\_ViewImports.cshtml"
using RawCritic2.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c17821ad5114c8ef51c712988e514e28d4f63ed4", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"185c77d0acefff6792caad9824ecd22452d3f882", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(84, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(89, 17, false);
#line 6 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(106, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(142, 59, true);
            WriteLiteral("\r\n<p>Use this area to provide additional information.</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RawCritic2.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RawCritic2.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RawCritic2.Pages.AboutModel>)PageContext?.ViewData;
        public RawCritic2.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
