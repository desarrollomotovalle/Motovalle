#pragma checksum "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f3e01128b621afa1af7f2d514007aa54fa87c9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ShoppingCartCheckout_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ShoppingCartCheckout/Default.cshtml")]
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
#line 1 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\_ViewImports.cshtml"
using motovalle.Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\_ViewImports.cshtml"
using motovalle.Ecommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\_ViewImports.cshtml"
using motovalle.Ecommerce.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\_ViewImports.cshtml"
using motovalle.Ecommerce.Models.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3e01128b621afa1af7f2d514007aa54fa87c9c", @"/Views/Shared/Components/ShoppingCartCheckout/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d9751ebeea2a66464bceb63213afb7dc7c6723", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ShoppingCartCheckout_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppingCartCheckoutViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 25px; padding: 1rem 0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
  
    var count = Model.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"shoppingItemRecordsDisplayId\">\r\n");
#nullable restore
#line 7 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
     if (Model.Count() > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"product-removal\" style=\"margin-bottom:1em;\">\r\n                <div class=\"b-items__cars-one wow zoomInUp\" data-wow-delay=\"0.1s\">\r\n                    <div class=\"b-items__cars-one-img\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 457, "\"", 499, 1);
#nullable restore
#line 14 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
WriteAttributeValue("", 463, Url.Content($"~/{item.PictureUrl}"), 463, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\'", 500, "\'", 523, 1);
#nullable restore
#line 14 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
WriteAttributeValue("", 506, item.ProductName, 506, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:230px; max-height:230px;\" />\r\n                    </div>\r\n                    <div class=\"b-items__cars-one-info\">\r\n                        <header class=\"b-items__cars-one-info-header s-lineDownLeft\">\r\n                            <h2>");
#nullable restore
#line 18 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <span>");
#nullable restore
#line 19 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
                             Write(item.SalesPriceInventory.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </header>\r\n                        <p>\r\n                            ");
#nullable restore
#line 22 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
                       Write(item.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <div class=\"b-items__cars-one-info-details\">\r\n                            <div class=\"b-featured__item-links\">\r\n                                <a href=\"#\">");
#nullable restore
#line 26 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
                                       Write(item.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                <a href=\"#\">");
#nullable restore
#line 27 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
                                       Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                <a href=\"#\">");
#nullable restore
#line 28 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
                                       Write(item.TransmissionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                <a href=\"#\">");
#nullable restore
#line 29 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
                                       Write(item.Passengers.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Pasajeros</a>\r\n                                <a href=\"#\">");
#nullable restore
#line 30 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
                                       Write(item.Doors.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Puertas</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"pull-right\">\r\n                        <button class=\"btn btn-danger\" style=\"border-radius:25px;\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1763, "\"", 1820, 3);
            WriteAttributeValue("", 1773, "removeItemFromCart(", 1773, 19, true);
#nullable restore
#line 35 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
WriteAttributeValue("", 1792, item.ShoppingCartRecordsId, 1792, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1819, ")", 1819, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span class=\"fa fa-times\"></span>\r\n                            Eliminar\r\n                        </button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 42 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
                                                                                                                                                                                                                           
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""alert alert-info text-center wow zoomInUp"" role=""alert"" data-wow-delay=""0.2s"">
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
            <strong>No hay registros para mostrar</strong> &#128577;
        </div>
        <div class=""text-center wow zoomInUp"" data-wow-delay=""0.1s"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f3e01128b621afa1af7f2d514007aa54fa87c9c12268", async() => {
                WriteLiteral("<b>Seguir comprando</b> <span class=\"fa fa-home\"></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n");
#nullable restore
#line 58 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Shared\Components\ShoppingCartCheckout\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<style>\r\n    #shoppingItemRecordsDisplayId {\r\n        height: 70vh;\r\n        width: 100%;\r\n        overflow: auto;\r\n        margin-bottom: 1rem;\r\n    }\r\n\r\n    ");
            WriteLiteral("@media (min-width: 1367px) {\r\n        #shoppingItemRecordsDisplayId {\r\n            height: 55vh;\r\n        }\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShoppingCartCheckoutViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
