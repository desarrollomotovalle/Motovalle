#pragma checksum "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d97b5b95297664e9f58f5c6a6110aeda98bc3fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Models_Views_Petronas_PortafolioLubricantesDetalle), @"mvc.1.0.view", @"/Models/Views/Petronas/PortafolioLubricantesDetalle.cshtml")]
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
#line 1 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\_ViewImports.cshtml"
using motovalle.Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\_ViewImports.cshtml"
using motovalle.Ecommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\_ViewImports.cshtml"
using motovalle.Ecommerce.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\_ViewImports.cshtml"
using Ecommerce.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\_ViewImports.cshtml"
using motovalle.Ecommerce.Models.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
using motovalle.Ecommerce.Models.ViewModelsPetronas;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d97b5b95297664e9f58f5c6a6110aeda98bc3fa", @"/Models/Views/Petronas/PortafolioLubricantesDetalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d9751ebeea2a66464bceb63213afb7dc7c6723", @"/Models/Views/_ViewImports.cshtml")]
    public class Models_Views_Petronas_PortafolioLubricantesDetalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PortafolioDetalleViewModel>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
  
    ViewData["Title"] = "Petronas - Detalle Portafolio Automotriz";
    Layout = "~/Views/Shared/_LayoutPetronas.cshtml";

    //List<SelectListItem>
    //listaFormaFarmaceutica = ViewBag.ListaFormaFarmaceutica;

    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d97b5b95297664e9f58f5c6a6110aeda98bc3fa4961", async() => {
                WriteLiteral("\r\n        <div class=\"container\">\r\n");
#nullable restore
#line 17 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"row text-center mt-5\">\r\n");
                WriteLiteral("                    <img");
                BeginWriteAttribute("src", " src=\"", 758, "\"", 779, 1);
#nullable restore
#line 21 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
WriteAttributeValue("", 764, item.UrlImagen, 764, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Alternate Text\" />\r\n                </div>\r\n");
                WriteLiteral("                <div class=\"text-center\">\r\n                    <label class=\"titulo-portafolio-detalle px-3 px-lg-0\">");
#nullable restore
#line 26 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                                                     Write(item.portafolioLubricantesDetalle.TituloDetalle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <label class=\"subtitulo-portafolio-detalle px-3 px-lg-0 mt-5\">\r\n                        ");
#nullable restore
#line 28 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                   Write(item.portafolioLubricantesDetalle.DescripcionTituloDetalle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </label>\r\n\r\n                </div>\r\n");
                WriteLiteral("                <div class=\"mt-5\">\r\n                    <label class=\"subtitulo2-portafolio-detalle px-3 px-lg-0\">");
#nullable restore
#line 38 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                                                         Write(item.portafolioLubricantesDetalle.TituloDescripcionAplicaciones);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
                WriteLiteral("                    <p class=\"texto-portafolio mt-4 px-3 px-lg-0\">\r\n                        ");
#nullable restore
#line 41 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                   Write(item.portafolioLubricantesDetalle.DescripcionAplicaciones);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </p>\r\n                </div>\r\n");
                WriteLiteral("                <div class=\"mt-5\">\r\n                    <label class=\"subtitulo2-portafolio-detalle px-3 px-lg-0\">");
#nullable restore
#line 46 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                                                         Write(item.portafolioLubricantesDetalle.TituloCaracteristicas);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <div class=\"texto-portafolio px-3 px-lg-0\">\r\n                        <ul>\r\n\r\n");
#nullable restore
#line 50 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Caracteristica1 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 52 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Caracteristica1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 53 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Caracteristica2 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 56 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Caracteristica2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 57 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Caracteristica3 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 60 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Caracteristica3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 61 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Caracteristica4 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 64 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Caracteristica4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 65 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Caracteristica5 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 68 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Caracteristica5);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 69 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Caracteristica6 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 72 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Caracteristica6);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 73 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Caracteristica7 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 76 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Caracteristica7);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 77 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n");
                WriteLiteral("                <div class=\"mt-5\">\r\n                    <label class=\"subtitulo2-portafolio-detalle px-3 px-lg-0\">");
#nullable restore
#line 84 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                                                         Write(item.portafolioLubricantesDetalle.TituloEspecificaciones);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <div class=\"texto-portafolio px-3 px-lg-0\">\r\n                        <ul>\r\n\r\n");
#nullable restore
#line 88 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Especificacion1 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 90 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Especificacion1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 91 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Especificacion2 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 94 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Especificacion2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 95 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Especificacion3 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 98 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Especificacion3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 99 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Especificacion4 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 102 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Especificacion4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 103 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Especificacion5 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 106 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Especificacion5);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 107 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Especificacion6 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 110 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Especificacion6);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 111 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                             if (item.portafolioLubricantesDetalle.Especificacion7 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"p-2\">");
#nullable restore
#line 114 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                           Write(item.portafolioLubricantesDetalle.Especificacion7);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 115 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n");
                WriteLiteral("                <div class=\"mt-5\">\r\n                    <label class=\"subtitulo2-portafolio-detalle px-3 px-lg-0\">");
#nullable restore
#line 122 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                                                                         Write(item.portafolioLubricantesDetalle.TituloSeguridad);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n\r\n                    <p class=\"texto-portafolio mt-4 px-3 px-lg-0\">\r\n                        ");
#nullable restore
#line 125 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
                   Write(item.portafolioLubricantesDetalle.DescripcionSalud);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </p>\r\n                </div>\r\n");
#nullable restore
#line 128 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\PortafolioLubricantesDetalle.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n    ");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PortafolioDetalleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
