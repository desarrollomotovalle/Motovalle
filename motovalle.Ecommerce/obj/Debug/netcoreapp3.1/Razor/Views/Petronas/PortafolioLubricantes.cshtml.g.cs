#pragma checksum "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "122583d818ccbc4158210225bc56bf352a4e9a14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Petronas_PortafolioLubricantes), @"mvc.1.0.view", @"/Views/Petronas/PortafolioLubricantes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"122583d818ccbc4158210225bc56bf352a4e9a14", @"/Views/Petronas/PortafolioLubricantes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d9751ebeea2a66464bceb63213afb7dc7c6723", @"/Views/_ViewImports.cshtml")]
    public class Views_Petronas_PortafolioLubricantes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PortafolioLubricantes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fmrEnviarGamaProductos"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background: #F6F6F6;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fmrEnviarTipoAceite"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fmrEnviarViscosidad"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PortafolioLubricantesDetalle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Petronas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
  
    ViewData["Title"] = "Petronas - Portafolio Automotriz";
    Layout = "~/Views/Shared/_LayoutPetronas.cshtml";

    List<SelectListItem> listaGamaProductos = ViewBag.ListaGamaProductos;
    List<SelectListItem> listaTipoAceite = ViewBag.ListaTipoAceite;
    List<SelectListItem> listaViscosidad = ViewBag.ListaViscosidad;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "122583d818ccbc4158210225bc56bf352a4e9a148466", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n");
                WriteLiteral(@"        <div class=""row"">
            <div class=""@*comprimir*@ col-lg-4 col-10 offset-1 offset-lg-0"">
                <div class=""card mt-5 tarjeta-portafolio"">
                    <div class=""card-body"">
                        <div class="" mt-3"">
                            <h5 class=""titulo-filtro""> BÚSQUEDA DE LUBRICANTES </h5>
                        </div>
                        <div>
                            <p class=""texto-filtro"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc vulputate libero et velit interdum.</p>
                        </div>

                        <div class=""card mt-3 "">
                            <div class=""p-3 border"">
                                GAMA DE PRODUCTOS
                                <img style=""float: right;"" src=""/Image/portafolio-icono-informacion.png"" alt=""Alternate Text"" />
                            </div>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "122583d818ccbc4158210225bc56bf352a4e9a149759", async() => {
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 33 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                           Write(Html.DropDownList("GamaProducto", listaGamaProductos, new { @class = "form-control form-control-sm border-0", @style= "background-color:#F6F6F6;" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>

                        <div class=""card mt-3 "">
                            <div class=""p-3 border"">
                                TIPO DE ACEITE
                                <img style=""float: right;"" src=""/Image/portafolio-icono-informacion.png"" alt=""Alternate Text"" />
                            </div>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "122583d818ccbc4158210225bc56bf352a4e9a1412162", async() => {
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 43 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                           Write(Html.DropDownList("TipoAceite", listaTipoAceite, new { @class = "form-control form-control-sm border-0", @style = "background-color:#F6F6F6;" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>

                        <div class=""card mt-3 "">
                            <div class=""p-3 border"">
                                VISCOSIDAD
                                <img style=""float: right;"" src=""/Image/portafolio-icono-informacion.png"" alt=""Alternate Text"" />
                            </div>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "122583d818ccbc4158210225bc56bf352a4e9a1414558", async() => {
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 53 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                           Write(Html.DropDownList("ViscosidadAceite", listaViscosidad, new { @class = "form-control form-control-sm border-0", @style = "background-color:#F6F6F6;" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n\r\n\r\n            <div class=\"col-12 col-lg-8 mt-5 \">\r\n");
#nullable restore
#line 63 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "122583d818ccbc4158210225bc56bf352a4e9a1417042", async() => {
                    WriteLiteral("\r\n                        <div class=\"card mb-3 tarjeta-portafolio\">\r\n\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "122583d818ccbc4158210225bc56bf352a4e9a1417413", async() => {
                        WriteLiteral("\r\n                                <div class=\"row g-0\">\r\n                                    <div class=\"col-md-4  text-center text-lg-start mt-5\">\r\n                                        <img");
                        BeginWriteAttribute("src", " src=\"", 3795, "\"", 3816, 1);
#nullable restore
#line 71 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
WriteAttributeValue("", 3801, item.UrlImagen, 3801, 15, false);

#line default
#line hidden
#nullable disable
                        EndWriteAttribute();
                        WriteLiteral(@" class=""img-fluid  rounded-start"" alt=""..."">
                                    </div>
                                    <div class=""col-md-8"">
                                        <div class=""card-body"">
                                            <p class=""card-text text-center text-lg-start ""><small class=""text-muted texto-titulo-portafolio"">");
#nullable restore
#line 75 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                                                                                                         Write(item.TipoAceite);

#line default
#line hidden
#nullable disable
                        WriteLiteral("</small></p>\r\n                                            <h5 class=\"card-title text-center text-lg-start titulo-portafolio-tarjeta\">");
#nullable restore
#line 76 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                                                                                  Write(item.ReferenciaProducto);

#line default
#line hidden
#nullable disable
                        WriteLiteral("</h5>\r\n                                            <div class=\"linea-portafolio-tarjeta\"> </div>\r\n\r\n                                            <ul class=\"card-text mt-3  texto-tarjeta-portafolio\" style=\"text-align: center;\">\r\n");
#nullable restore
#line 80 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                 if (item.DescripcionProducto1 != null)
                                                {

#line default
#line hidden
#nullable disable
                        WriteLiteral("                                                    <li class=\"text-center text-lg-start\">");
#nullable restore
#line 82 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                                                     Write(item.DescripcionProducto1);

#line default
#line hidden
#nullable disable
                        WriteLiteral("</li>\r\n");
#nullable restore
#line 83 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                 if (item.DescripcionProducto2 != null)
                                                {

#line default
#line hidden
#nullable disable
                        WriteLiteral("                                                    <li class=\"text-center text-lg-start mt-lg-2\">");
#nullable restore
#line 86 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                                                             Write(item.DescripcionProducto2);

#line default
#line hidden
#nullable disable
                        WriteLiteral("</li>\r\n");
#nullable restore
#line 87 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                 if (item.DescripcionProducto3 != null)
                                                {

#line default
#line hidden
#nullable disable
                        WriteLiteral("                                                    <li class=\"text-center text-lg-start mt-lg-2\">");
#nullable restore
#line 90 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                                                             Write(item.DescripcionProducto3);

#line default
#line hidden
#nullable disable
                        WriteLiteral("</li>\r\n");
#nullable restore
#line 91 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                 if (item.DescripcionProducto4 != null)
                                                {

#line default
#line hidden
#nullable disable
                        WriteLiteral("                                                    <li class=\"text-center text-lg-start mt-2\">");
#nullable restore
#line 94 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                                                          Write(item.DescripcionProducto4);

#line default
#line hidden
#nullable disable
                        WriteLiteral("</li>\r\n");
#nullable restore
#line 95 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                 if (item.DescripcionProducto5 != null)
                                                {

#line default
#line hidden
#nullable disable
                        WriteLiteral("                                                    <li class=\"text-center text-lg-start mt-2\">");
#nullable restore
#line 98 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                                                          Write(item.DescripcionProducto5);

#line default
#line hidden
#nullable disable
                        WriteLiteral("</li>\r\n");
#nullable restore
#line 99 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                 if (item.DescripcionProducto6 != null)
                                                {

#line default
#line hidden
#nullable disable
                        WriteLiteral("                                                    <li class=\"text-center text-lg-start mt-2\">");
#nullable restore
#line 102 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                                                          Write(item.DescripcionProducto6);

#line default
#line hidden
#nullable disable
                        WriteLiteral("</li>\r\n");
#nullable restore
#line 103 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                 if (item.DescripcionProducto7 != null)
                                                {

#line default
#line hidden
#nullable disable
                        WriteLiteral("                                                    <li class=\"text-center text-lg-start mt-2\">");
#nullable restore
#line 106 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                                                          Write(item.DescripcionProducto7);

#line default
#line hidden
#nullable disable
                        WriteLiteral("</li>\r\n");
#nullable restore
#line 107 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                        WriteLiteral("                                            </ul>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                                                                           WriteLiteral(item.IdDetallePortafolioAutomotriz);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        </div>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 115 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Petronas\PortafolioLubricantes.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    var IdGamaProducto = document.getElementById(""GamaProducto"");
    IdGamaProducto.onchange = function () {
        //Se ejecuta todo lo que coloques aqui
        document.getElementById(""fmrEnviarGamaProductos"").submit();
    }

        var IdTipoAceite = document.getElementById(""TipoAceite"");
    IdTipoAceite.onchange = function () {
        //Se ejecuta todo lo que coloques aqui
        document.getElementById(""fmrEnviarTipoAceite"").submit();
    }

    var IdViscosidad = document.getElementById(""ViscosidadAceite"");
    IdViscosidad.onchange = function () {
        //Se ejecuta todo lo que coloques aqui
        document.getElementById(""fmrEnviarViscosidad"").submit();
    }
</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PortafolioLubricantes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
