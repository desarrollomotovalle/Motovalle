#pragma checksum "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "358501052ae281d3d3cb648dfc6dcaf6a896c771"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Petronas_PortafolioMotocicletasDetalle), @"mvc.1.0.view", @"/Views/Petronas/PortafolioMotocicletasDetalle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"358501052ae281d3d3cb648dfc6dcaf6a896c771", @"/Views/Petronas/PortafolioMotocicletasDetalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d9751ebeea2a66464bceb63213afb7dc7c6723", @"/Views/_ViewImports.cshtml")]
    public class Views_Petronas_PortafolioMotocicletasDetalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<motovalle.Ecommerce.Models.PortafolioLubricantesDetalle>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
  
    ViewData["Title"] = "Petronas - Detalle Portafolio Automotriz";
    Layout = "~/Views/Shared/_LayoutPetronas.cshtml";

    List<SelectListItem> listaFormaFarmaceutica = ViewBag.ListaFormaFarmaceutica;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "358501052ae281d3d3cb648dfc6dcaf6a896c7714608", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row text-center mt-5\">\r\n");
                WriteLiteral("        </div>\r\n\r\n\r\n        <div class=\"text-center\">\r\n            <label class=\"titulo-portafolio-detalle px-3 px-lg-0\">");
#nullable restore
#line 20 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                                             Write(Model.TituloDetalle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <label class=\"subtitulo-portafolio-detalle px-3 px-lg-0 mt-5\">\r\n                ");
#nullable restore
#line 22 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
           Write(Model.DescripcionTituloDetalle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </label>\r\n\r\n        </div>\r\n");
                WriteLiteral("        <div class=\"mt-5\">\r\n            <label class=\"subtitulo2-portafolio-detalle px-3 px-lg-0\">");
#nullable restore
#line 32 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                                                 Write(Model.TituloDescripcionAplicaciones);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
                WriteLiteral("            <p class=\"texto-portafolio mt-4 px-3 px-lg-0\">\r\n                ");
#nullable restore
#line 35 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
           Write(Model.DescripcionAplicaciones);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n\r\n        <div class=\"mt-5\">\r\n            <label class=\"subtitulo2-portafolio-detalle px-3 px-lg-0\">");
#nullable restore
#line 40 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                                                 Write(Model.TituloCaracteristicas);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <div class=\"texto-portafolio px-3 px-lg-0\">\r\n                <ul>\r\n\r\n");
#nullable restore
#line 44 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Caracteristica1 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 46 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Caracteristica1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 47 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Caracteristica2 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 50 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Caracteristica2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 51 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Caracteristica3 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 54 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Caracteristica3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 55 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Caracteristica4 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 58 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Caracteristica4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 59 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Caracteristica5 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 62 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Caracteristica5);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 63 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Caracteristica6 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 66 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Caracteristica6);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 67 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Caracteristica7 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 70 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Caracteristica7);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 71 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </ul>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"mt-5\">\r\n            <label class=\"subtitulo2-portafolio-detalle px-3 px-lg-0\">");
#nullable restore
#line 78 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                                                 Write(Model.TituloEspecificaciones);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            <div class=\"texto-portafolio px-3 px-lg-0\">\r\n                <ul>\r\n\r\n");
#nullable restore
#line 82 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Especificacion1 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 84 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Especificacion1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 85 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Especificacion2 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 88 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Especificacion2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 89 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Especificacion3 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 92 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Especificacion3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 93 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Especificacion4 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 96 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Especificacion4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 97 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Especificacion5 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 100 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Especificacion5);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 101 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Especificacion6 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 104 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Especificacion6);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 105 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                     if (Model.Especificacion7 != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"p-2\">");
#nullable restore
#line 108 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                   Write(Model.Especificacion7);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 109 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </ul>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"mt-5\">\r\n            <label class=\"subtitulo2-portafolio-detalle px-3 px-lg-0\">");
#nullable restore
#line 116 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
                                                                 Write(Model.TituloSeguridad);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n\r\n            <p class=\"texto-portafolio mt-4 px-3 px-lg-0\">\r\n                ");
#nullable restore
#line 119 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioMotocicletasDetalle.cshtml"
           Write(Model.DescripcionSalud);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<motovalle.Ecommerce.Models.PortafolioLubricantesDetalle> Html { get; private set; }
    }
}
#pragma warning restore 1591
