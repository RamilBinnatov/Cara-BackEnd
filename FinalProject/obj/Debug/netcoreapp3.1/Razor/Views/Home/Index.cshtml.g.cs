#pragma checksum "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8c1f775948c5dc76264959f8fbeed13a58b6903"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels.Basket;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8c1f775948c5dc76264959f8fbeed13a58b6903", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"001c5272ec52ac5cfee52c119643cb31b9d72b75", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shopdetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
 foreach (var item in Model.Heroes)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section id=\"hero\"");
            BeginWriteAttribute("style", " style=\"", 79, "\"", 141, 4);
            WriteAttributeValue("", 87, "background-image:", 87, 17, true);
            WriteAttributeValue(" ", 104, "url(../assets/img/hero/", 105, 24, true);
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 128, item.Image, 128, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 139, ");", 139, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h4>");
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
       Write(Html.Raw(item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h2>");
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
       Write(Html.Raw(item.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h1>");
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
       Write(Html.Raw(item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p>");
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
      Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <button>Shop Now</button>\r\n    </section>\r\n");
#nullable restore
#line 12 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Service"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<section id=\"product1\" class=\"section-p1\">\r\n    <h2>Best Selling</h2>\r\n    <p>Summer Collection New Modern Design</p>\r\n    <div class=\"pro-container\">\r\n\r\n");
#nullable restore
#line 22 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
         foreach (var item in Model.BestSelling)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"pro godzilla\"");
            BeginWriteAttribute("Cart-id", " Cart-id=\"", 665, "\"", 683, 1);
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 675, item.Id, 675, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 684, "\"", 697, 1);
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 689, item.Id, 689, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <input type=\"hidden\" class=\"product-id\"");
            BeginWriteAttribute("value", " value=\"", 756, "\"", 772, 1);
#nullable restore
#line 25 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 764, item.Id, 764, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8c1f775948c5dc76264959f8fbeed13a58b69038918", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b8c1f775948c5dc76264959f8fbeed13a58b69039193", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 900, "~/assets/img/products/", 900, 22, true);
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 922, item.ProductImages.FirstOrDefault(m=>m.IsMain)?.Image, 922, 54, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                <div class=\"des\">\r\n                    <span>");
#nullable restore
#line 30 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
                     Write(item.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <h5>");
#nullable restore
#line 31 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    <div class=""star"">
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                    </div>
                    <h4>$");
#nullable restore
#line 39 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                <a class=\"salam12321\"");
            BeginWriteAttribute("cart-id", " cart-id=\"", 1574, "\"", 1592, 1);
#nullable restore
#line 41 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1584, item.Id, 1584, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"addToCart\"><i class=\"ri-shopping-cart-2-line cart\"></i></a>\r\n            </div>\r\n");
#nullable restore
#line 43 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</section>\r\n\r\n");
#nullable restore
#line 48 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
 foreach (var item in Model.Boards)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section id=\"banner\" class=\"section-m1\"");
            BeginWriteAttribute("style", " style=\"", 1801, "\"", 1863, 4);
            WriteAttributeValue("", 1809, "background-image:", 1809, 17, true);
            WriteAttributeValue(" ", 1826, "url(../assets/img/hero/", 1827, 24, true);
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1850, item.Image, 1850, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1861, ");", 1861, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h4>");
#nullable restore
#line 51 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h2>");
#nullable restore
#line 52 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <button class=\"normal\">Explore More</button>\r\n    </section>\r\n");
#nullable restore
#line 55 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"product1\" class=\"section-p1\">\r\n    <h2>New Arrivals</h2>\r\n    <p>Summer Collection New Modern Design</p>\r\n    <div class=\"pro-container\">\r\n\r\n");
#nullable restore
#line 62 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
         foreach (var item in Model.NewArrivals)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"pro godzilla\"");
            BeginWriteAttribute("id", " id=\"", 2260, "\"", 2273, 1);
#nullable restore
#line 64 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 2265, item.Id, 2265, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8c1f775948c5dc76264959f8fbeed13a58b690317464", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b8c1f775948c5dc76264959f8fbeed13a58b690317740", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2399, "~/assets/img/products/", 2399, 22, true);
#nullable restore
#line 66 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2421, item.ProductImages.FirstOrDefault(m=>m.IsMain)?.Image, 2421, 54, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                <div class=\"des\">\r\n                    <span>");
#nullable restore
#line 69 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
                     Write(item.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <h5>");
#nullable restore
#line 70 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    <div class=""star"">
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                        <i class=""fas fa-star""></i>
                    </div>
                    <h4>$");
#nullable restore
#line 78 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                <a class=\"salam12321\"><i class=\"ri-shopping-cart-2-line cart\"></i></a>\r\n            </div>\r\n");
#nullable restore
#line 82 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</section>\r\n\r\n<section id=\"sm-banner\" class=\"section-p1\">\r\n");
#nullable restore
#line 89 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
     foreach (var item in Model.Posters)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"banner-box\"");
            BeginWriteAttribute("style", " style=\"", 3310, "\"", 3372, 4);
            WriteAttributeValue("", 3318, "background-image:", 3318, 17, true);
            WriteAttributeValue(" ", 3335, "url(../assets/img/hero/", 3336, 24, true);
#nullable restore
#line 91 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 3359, item.Image, 3359, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3370, ");", 3370, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h4>");
#nullable restore
#line 92 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <h2>");
#nullable restore
#line 93 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
           Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <span>");
#nullable restore
#line 94 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
             Write(item.Descrption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <button class=\"white\">Learn More</button>\r\n        </div>\r\n");
#nullable restore
#line 97 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n\r\n<section id=\"banner3\">\r\n\r\n");
#nullable restore
#line 102 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
     foreach (var item in Model.Banners)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"banner-box\"");
            BeginWriteAttribute("style", " style=\"", 3686, "\"", 3748, 4);
            WriteAttributeValue("", 3694, "background-image:", 3694, 17, true);
            WriteAttributeValue(" ", 3711, "url(../assets/img/hero/", 3712, 24, true);
#nullable restore
#line 104 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 3735, item.Image, 3735, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3746, ");", 3746, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h2>");
#nullable restore
#line 105 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
           Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h3>");
#nullable restore
#line 106 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n");
#nullable restore
#line 108 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>\r\n\r\n");
#nullable restore
#line 112 "C:\Users\ASUS\Desktop\Projects\FinalProject\FinalProject\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("NewsLetter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.5/jquery.validate.min.js"" integrity=""sha512-rstIgDs0xPgmG6RX1Aba4KV5cWJbAMcvRCVmglpam9SoHZiUCyQVDdH2LPlxoHtrv17XWblE/V/PP+Tr04hbtA=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/4.0.0/jquery.validate.unobtrusive.min.js"" integrity=""sha512-x+Vm8jC94ynOikewaQXMEkJIOBp7iArs3IhFWSWdRT3Pq8wFz46p+ZDFAR7kHnSFf+zUv52B3prRYnbDRdgog=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <script src=""https://code.jquery.com/jquery-3.5.1.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@7.12.15/dist/sweetalert2.all.min.js""></script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
