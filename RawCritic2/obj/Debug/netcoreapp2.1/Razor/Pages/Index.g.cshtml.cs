#pragma checksum "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79f5d0fad8993c5d2379ed1fdcd129c7c5469b3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RawCritic2.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(RawCritic2.Pages.Pages_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79f5d0fad8993c5d2379ed1fdcd129c7c5469b3c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"185c77d0acefff6792caad9824ecd22452d3f882", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Games/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banner3.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Microsoft Azure"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", ".Games/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(88, 428, true);
            WriteLiteral(@"


<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"" role=""listbox"">
        <div class=""item active""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 516, "\"", 576, 4);
            WriteAttributeValue(" ", 524, "=background-image:", 525, 19, true);
            WriteAttributeValue(" ", 543, "url(", 544, 5, true);
#line 16 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
WriteAttributeValue("", 548, Model.GetGame(4).BigCover, 548, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 574, ");", 574, 2, true);
            EndWriteAttribute();
            BeginContext(577, 19, true);
            WriteLiteral(">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 596, "\"", 628, 1);
#line 17 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
WriteAttributeValue("", 602, Model.GetGame(4).BigCover, 602, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(629, 148, true);
            WriteLiteral(" class=\"img-responsive\" style=\"width:auto\" />\r\n            <div class=\"carousel-caption\" role=\"option\">\r\n                <p>\r\n                    \r\n");
            EndContext();
#line 21 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                      var releasedate = Model.GetGame(4).ReleaseDate; 

#line default
#line hidden
            BeginContext(850, 33, true);
            WriteLiteral("                  Release Date:  ");
            EndContext();
            BeginContext(884, 46, false);
#line 22 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                            Write(Html.DisplayFor(m => m.GetGame(4).ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(930, 46, true);
            WriteLiteral("\r\n                    \r\n\r\n                    ");
            EndContext();
            BeginContext(976, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbb9dfb15e0a4ffda031eb5199ddad2c", async() => {
                BeginContext(1046, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                                                    WriteLiteral(Model.GetGame(4).GameID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1057, 104, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <div class=\"item\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1161, "\"", 1193, 1);
#line 30 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
WriteAttributeValue("", 1167, Model.GetGame(5).BigCover, 1167, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1194, 142, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n            <div class=\"carousel-caption\" role=\"option\">\r\n                <p>\r\n                    Release Date:  ");
            EndContext();
            BeginContext(1337, 46, false);
#line 33 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                              Write(Html.DisplayFor(m => m.GetGame(5).ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 24, true);
            WriteLiteral("\r\n\r\n                    ");
            EndContext();
            BeginContext(1407, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4553f11617754909a6eba02d1b969bed", async() => {
                BeginContext(1477, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                                                    WriteLiteral(Model.GetGame(5).GameID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1488, 100, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <div class=\"item\">\r\n            ");
            EndContext();
            BeginContext(1588, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9819a47799e4edcb2d77f4b8b55e580", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1667, 988, true);
            WriteLiteral(@"
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Learn how Microsoft's Azure cloud platform allows you to build, deploy, and scale web apps.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525027&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
    </div>
    <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<div class=""row"">
    <div class=""col-md-3"">
        <h2>Available now</h2>
");
            EndContext();
#line 64 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
        foreach (var item in Model.GetGames(3))
        {

#line default
#line hidden
            BeginContext(2715, 68, true);
            WriteLiteral("            <ul>\r\n                <li>\r\n                    <nobr>\r\n");
            EndContext();
#line 69 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                         if (item.AggregatedRating != 0)
                        {
                            

#line default
#line hidden
            BeginContext(2897, 51, false);
#line 71 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AggregatedRating));

#line default
#line hidden
            EndContext();
#line 71 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                                                                                
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3034, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(3064, 3, true);
            WriteLiteral("?\r\n");
            EndContext();
#line 76 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3092, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3093, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b933a6ed5394ef8aa3867e9799dd83a", async() => {
                BeginContext(3146, 6, true);
                WriteLiteral("      ");
                EndContext();
                BeginContext(3153, 40, false);
#line 76 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                                                                                Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3197, 5, true);
            WriteLiteral(" <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3202, "\"", 3219, 1);
#line 76 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
WriteAttributeValue("", 3208, item.Cover, 3208, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3220, 159, true);
            WriteLiteral(" height=\" 50\" style=\"border-radius: 60%\" />\r\n                    </nobr>\r\n                </li>\r\n\r\n                \r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(3380, 43, false);
#line 82 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Platform));

#line default
#line hidden
            EndContext();
            BeginContext(3423, 67, true);
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(3491, 44, false);
#line 85 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Developer));

#line default
#line hidden
            EndContext();
            BeginContext(3535, 48, true);
            WriteLiteral("\r\n                </li>\r\n                </ul>\r\n");
            EndContext();
#line 88 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3602, 80, true);
            WriteLiteral("        </div>\r\n    <div class=\"col-md-3\">\r\n        <h2>Upcoming Releases</h2>\r\n");
            EndContext();
#line 92 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
         foreach (var item in Model.GetUpcoming(3))
        {

#line default
#line hidden
            BeginContext(3746, 68, true);
            WriteLiteral("            <ul>\r\n                <li>\r\n                    <nobr>\r\n");
            EndContext();
#line 97 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                         if (item.AggregatedRating != 0)
                        {
                            

#line default
#line hidden
            BeginContext(3928, 51, false);
#line 99 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AggregatedRating));

#line default
#line hidden
            EndContext();
#line 99 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                                                                                
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4065, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(4095, 3, true);
            WriteLiteral("?\r\n");
            EndContext();
#line 104 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4123, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69eac33722184e44adccdcabb696ece9", async() => {
                BeginContext(4176, 6, true);
                WriteLiteral("      ");
                EndContext();
                BeginContext(4183, 40, false);
#line 104 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                                                                               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 104 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                                                        WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4227, 5, true);
            WriteLiteral(" <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4232, "\"", 4249, 1);
#line 104 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
WriteAttributeValue("", 4238, item.Cover, 4238, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4250, 156, true);
            WriteLiteral(" height=\" 50\" style=\"border-radius: 60%\" />\r\n                    </nobr>\r\n                </li>\r\n               \r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(4407, 43, false);
#line 109 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Platform));

#line default
#line hidden
            EndContext();
            BeginContext(4450, 67, true);
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(4518, 44, false);
#line 112 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Developer));

#line default
#line hidden
            EndContext();
            BeginContext(4562, 44, true);
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n");
            EndContext();
#line 115 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(4617, 77, true);
            WriteLiteral("        </div>\r\n    <div class=\"col-md-3\">\r\n        <h2>Reviewed today</h2>\r\n");
            EndContext();
#line 119 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
         foreach (var item in Model.GetReviewedToday(5))
        {

#line default
#line hidden
            BeginContext(4763, 69, true);
            WriteLiteral("            <ul>\r\n                <li>\r\n\r\n                    <nobr> ");
            EndContext();
#line 124 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                            if (item.AggregatedRating != 0)
                    {
                        

#line default
#line hidden
            BeginContext(4914, 67, false);
#line 126 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AggregatedRating.ToString("N0") ));

#line default
#line hidden
            EndContext();
#line 126 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                                                                                            
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(5055, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(5081, 3, true);
            WriteLiteral("?\r\n");
            EndContext();
#line 131 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(5105, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "944ee8cf1c0148779a6b75ffd613bae9", async() => {
                BeginContext(5158, 2, true);
                WriteLiteral("  ");
                EndContext();
                BeginContext(5161, 40, false);
#line 131 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                                                                       Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
                BeginContext(5201, 2, true);
                WriteLiteral("  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 131 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5207, 4, true);
            WriteLiteral("<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5211, "\"", 5228, 1);
#line 131 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
WriteAttributeValue("", 5217, item.Cover, 5217, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5229, 134, true);
            WriteLiteral(" height=\" 50\" style=\"border-radius: 60%\" /></nobr>\r\n                </li>\r\n               \r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(5364, 43, false);
#line 135 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Platform));

#line default
#line hidden
            EndContext();
            BeginContext(5407, 67, true);
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(5475, 44, false);
#line 138 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Developer));

#line default
#line hidden
            EndContext();
            BeginContext(5519, 44, true);
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n");
            EndContext();
#line 141 "C:\Users\siust\Desktop\GitHub\RawCritic2\RawCritic2\Pages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(5574, 26, true);
            WriteLiteral("    </div>\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RawCritic2.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RawCritic2.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RawCritic2.Pages.IndexModel>)PageContext?.ViewData;
        public RawCritic2.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
