#pragma checksum "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e96f3461df1976fb477efd192198905ddc5aece"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RawCritic2.Pages.Games.Pages_Games_PC), @"mvc.1.0.razor-page", @"/Pages/Games/PC.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Games/PC.cshtml", typeof(RawCritic2.Pages.Games.Pages_Games_PC), null)]
namespace RawCritic2.Pages.Games
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\_ViewImports.cshtml"
using RawCritic2;

#line default
#line hidden
#line 3 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\_ViewImports.cshtml"
using RawCritic2.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e96f3461df1976fb477efd192198905ddc5aece", @"/Pages/Games/PC.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"185c77d0acefff6792caad9824ecd22452d3f882", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Games_PC : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
  
    ViewData["name"] = "Index";

#line default
#line hidden
            BeginContext(88, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 9 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(132, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(149, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "001163867e8643a4a8550f3141bbb75f", async() => {
                BeginContext(170, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(184, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 14 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
}

#line default
#line hidden
            BeginContext(199, 143, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n\r\n    <div class=\"col-md-9 right\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n\r\n");
            EndContext();
            BeginContext(792, 101, true);
            WriteLiteral("\r\n\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                 foreach (var item in Model.Data)
                {
                    var rating = item.AggregatedRating.ToString("N0");

#line default
#line hidden
            BeginContext(1035, 58, true);
            WriteLiteral("                    <tr>\r\n\r\n                        <td>\r\n");
            EndContext();
#line 49 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                             if (item.AggregatedRating != 0)
                            {
                                

#line default
#line hidden
            BeginContext(1219, 6, false);
#line 51 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                           Write(rating);

#line default
#line hidden
            EndContext();
#line 51 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                                       
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1323, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1357, 3, true);
            WriteLiteral("?\r\n");
            EndContext();
#line 56 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                            }

#line default
#line hidden
            BeginContext(1391, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1419, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81a5cb8afe6c46c784b7d5b33c158a5d", async() => {
                BeginContext(1471, 2, true);
                WriteLiteral("  ");
                EndContext();
                BeginContext(1474, 40, false);
#line 57 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                                                                             Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                                                      WriteLiteral(item.GameID);

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
            BeginContext(1518, 93, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n\r\n                            ");
            EndContext();
            BeginContext(1612, 46, false);
#line 61 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1658, 95, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1753, "\"", 1770, 1);
#line 64 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
WriteAttributeValue("", 1759, item.Cover, 1759, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1771, 82, true);
            WriteLiteral(" height=\" 100\" />\r\n                        </td>\r\n\r\n                        <th>\r\n");
            EndContext();
#line 68 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                               string platforms = Model.GetPlatforms(item.platforms);

#line default
#line hidden
            BeginContext(1941, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1970, 54, false);
#line 69 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                       Write(Html.Raw(System.Web.HttpUtility.HtmlEncode(platforms)));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 33, true);
            WriteLiteral("\r\n                        </th>\r\n");
            EndContext();
#line 71 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
            BeginContext(2145, 66, true);
            WriteLiteral("                            <td>\r\n                                ");
            EndContext();
            BeginContext(2211, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee3996ade33c44c38464d2de3c536007", async() => {
                BeginContext(2256, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
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
            BeginContext(2264, 38, true);
            WriteLiteral(" |\r\n\r\n                                ");
            EndContext();
            BeginContext(2302, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53f86052334e4496bfe855555f4ae320", async() => {
                BeginContext(2349, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
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
            BeginContext(2359, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 78 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                        }

#line default
#line hidden
            BeginContext(2423, 27, true);
            WriteLiteral("                    </tr>\r\n");
            EndContext();
#line 80 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                }

#line default
#line hidden
            BeginContext(2469, 200, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    <div class=\"col-md-3\">\r\n        <div class=\"sidebar-nav pull-right\">\r\n            <div class=\"well\">\r\n                <h2>Available now</h2>\r\n");
            EndContext();
#line 89 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                 foreach (var item in Model.GetGames(5))
                {
                    var rating = item.AggregatedRating.ToString("N0");

#line default
#line hidden
            BeginContext(2818, 62, true);
            WriteLiteral("                    <ul class=\"nav\">\r\n                        ");
            EndContext();
            BeginContext(2880, 655, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9cbf904a74a43bdad765bedfa694b62", async() => {
                BeginContext(2932, 36, true);
                WriteLiteral("\r\n                            <li>\r\n");
                EndContext();
#line 95 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                                 if (item.AggregatedRating != 0 || item.AggregatedRating != null)
                                {
                                    

#line default
#line hidden
                BeginContext(3139, 6, false);
#line 97 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                               Write(rating);

#line default
#line hidden
                EndContext();
#line 97 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                                           
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(3255, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(3293, 3, true);
                WriteLiteral("?\r\n");
                EndContext();
#line 102 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                                }

#line default
#line hidden
                BeginContext(3329, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(3331, 40, false);
#line 102 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                             Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
                BeginContext(3371, 38, true);
                WriteLiteral("\r\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3409, "\"", 3426, 1);
#line 103 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
WriteAttributeValue("", 3415, item.Cover, 3415, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3427, 104, true);
                WriteLiteral(" height=\" 50\" style=\"border-radius: 60%\" />\r\n                            </li>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                                                  WriteLiteral(item.GameID);

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
            BeginContext(3535, 64, true);
            WriteLiteral("\r\n\r\n\r\n                        <li>\r\n                            ");
            EndContext();
            BeginContext(3600, 43, false);
#line 109 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Platform));

#line default
#line hidden
            EndContext();
            BeginContext(3643, 91, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            ");
            EndContext();
            BeginContext(3735, 44, false);
#line 112 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Developer));

#line default
#line hidden
            EndContext();
            BeginContext(3779, 60, true);
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n");
            EndContext();
#line 115 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                }

#line default
#line hidden
            BeginContext(3858, 22, true);
            WriteLiteral("            </div>\r\n\r\n");
            EndContext();
            BeginContext(5803, 76, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<div>\r\n    <ul class=\"pagination\">\r\n");
            EndContext();
#line 172 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
         for (var i = 1; i <= Model.TotalPages; i++)
        {

#line default
#line hidden
            BeginContext(5944, 15, true);
            WriteLiteral("            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5959, "\"", 6018, 2);
            WriteAttributeValue("", 5967, "page-item", 5967, 9, true);
#line 174 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
WriteAttributeValue(" ", 5976, i == Model.CurrentPage ? "active" : "", 5977, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6019, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(6038, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beaa8cb514474bf98de79c7de7b8f12f", async() => {
                BeginContext(6106, 1, false);
#line 175 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                                                                              Write(i);

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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentpage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 175 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
                                                 WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentpage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentpage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentpage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6111, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 177 "C:\Users\siust\Desktop\GitHub\RawCritic-Aggregator\RawCritic2\Pages\Games\PC.cshtml"
        }

#line default
#line hidden
            BeginContext(6143, 17, true);
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RawCritic2.Pages.Games.PCModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RawCritic2.Pages.Games.PCModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RawCritic2.Pages.Games.PCModel>)PageContext?.ViewData;
        public RawCritic2.Pages.Games.PCModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
