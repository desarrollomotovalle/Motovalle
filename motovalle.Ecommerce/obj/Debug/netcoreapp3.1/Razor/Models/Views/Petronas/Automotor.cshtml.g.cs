#pragma checksum "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\Automotor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c9839041dbd40f31362735e10f6737730b90add"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Models_Views_Petronas_Automotor), @"mvc.1.0.view", @"/Models/Views/Petronas/Automotor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c9839041dbd40f31362735e10f6737730b90add", @"/Models/Views/Petronas/Automotor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d9751ebeea2a66464bceb63213afb7dc7c6723", @"/Models/Views/_ViewImports.cshtml")]
    public class Models_Views_Petronas_Automotor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark bg-white p-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Petronas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LubricanteVehiculosLivianos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark  p-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LubricanteMotocicletas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LubricanteVehiculosComerciales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Petronas\Automotor.cshtml"
  
    ViewData["Title"] = "Petronas - Automor";
    Layout = "~/Views/Shared/_LayoutPetronas.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- ======= Sección banner automotor ======= -->\r\n");
            WriteLiteral(@"
<div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
    <div class=""carousel-inner"">
        <div class=""carousel-item active"">
            <div class=""banner banner-home-automotor img-fluid"">
                <div class=""container"">
                    <div class=""banner-texto text-center text-ms-center text-md-start text-lg-start d-inline"">
                        <span class="" border-start border-4 border-white  ps-md-4 ps-lg-4 p-sm-0 m-0 p-0 d-block ps-sm-0 border__sm__left__0"" style=""width:100%;"">
                            AUTOMOTOR
                        </span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- ======= Sección fila impar ======= -->
<div class=""bg-white"">
    <div class=""container"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c9839041dbd40f31362735e10f6737730b90add7266", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-12 col-sm-12 col-lg-6  tarjeta-linea-impar"">
                    <div class=""bloque"">
                        <div class=""titulo-tarjeta-izquierda-impar mb-2 mt-0"">
                            LUBRICANTES PARA AUTOMÓVILES Y CAMIONETAS
                        </div>
                        <div>
                            <p class=""text-tarjeta-izquierda-impar mt-lg-3 mt-0 "">
                                Los aceites PETRONAS para vehículos están desarrollados con la ultima tecnología, brindando la máxima protección al motor. Desarrollando el rendimiento máximo con una conducción suave. Tu vehículo merece lo mejor, tu vehículo merece Petronas.
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-sm-12 col-lg-6 tarjeta-centrar-imagen col-sm-12"">
                    <img class=""p-3 p-lg-0 img-fluid"" src=""/Image/imagen-automotor-automo");
                WriteLiteral("vil.png\" alt=\"Alternate Text\" style=\"width: 337px; height: 191px;\" />\r\n                </div>\r\n                <label class=\"text-center pb-2 texto-ver-mas\">VER MÁS </label>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<!-- ======= Sección fila par ======= -->\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c9839041dbd40f31362735e10f6737730b90add10334", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""ocultar-imagen tarjeta-centrar-imagen"">
                    <img class=""p-3 p-lg-0 img-fluid"" src=""/Image/imagen-automotor-motocicleta.png"" alt=""Alternate Text"" style=""width: 337px; height: 191px;"" />
                </div>
                <div class=""tarjeta-linea-par "">
                    <div class=""bloque"">
                        <div class=""titulo-tarjeta-derecha-par mb-2"">
                            LUBRICANTES PARA MOTOS
                        </div>
                        <div>
                            <p class=""text-tarjeta-derecha-par"">
                                Conocemos las tensiones a las que se someten los motores de las motocicletas todos los días. Es por esto que hemos creado un aceite que no lo defraudará y le dará una conducción más larga y suave. Nuestros lubricantes protegen tu motor para que puedas concentrarte en la carretera.
                            </p>
                        </div>

         ");
                WriteLiteral(@"           </div>
                </div>
                <div class=""cambiar-posicion-imagen"">
                    <div class=""tarjeta-centrar-imagen"">
                        <img class=""p-3 p-lg-0 img-fluid"" src=""/Image/imagen-automotor-motocicleta.png"" alt=""Alternate Text"" style=""width: 337px; height: 191px;"" />
                    </div>
                    <label class=""text-center pb-2 texto-ver-mas"">VER MÁS </label>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<!-- ======= Sección fila impar ======= -->\r\n<div class=\"bg-white\">\r\n    <div class=\"container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c9839041dbd40f31362735e10f6737730b90add13698", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-lg-6 col-12 tarjeta-linea-impar"">
                    <div class=""bloque align-content-end m-0 p-0"">
                        <div class=""titulo-tarjeta-izquierda-impar p-0 mb-2"">
                            LUBRICANTE PARA VEHÍCULOS COMERCIALES
                        </div>
                        <div>
                            <p class=""text-tarjeta-izquierda-impar p-0 mt-lg-3"">
                                La vida se trata de evitar los obstáculos ocultos en el camino. Entendemos la importancia de poder confiar en nuestros vehículos para que los negocios y la vida siempre avancen en la dirección correcta. Nuestra gana de aceites de motos de alta calidad esta diseñada para mantener tus negocios en el camino.
                            </p>
                        </div>

                    </div>
                </div>
                <div class=""col-lg-6 col-12 tarjeta-centrar-imagen col-sm-12 p-0"">
                    <");
                WriteLiteral(@"img class=""p-3 p-lg-0 img-fluid"" src=""/Image/imagen-automotor-camion.png"" alt=""Alternate Text"" style=""width: 337px; height: 191px;"" />
                </div>
                <label class=""text-center pb-2 texto-ver-mas"">VER MÁS </label>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
