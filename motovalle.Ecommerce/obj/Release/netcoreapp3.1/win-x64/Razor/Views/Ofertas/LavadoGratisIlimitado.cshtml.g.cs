#pragma checksum "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Ofertas\LavadoGratisIlimitado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69d9c93052b890664be1d70f0ef33f0daecd62d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ofertas_LavadoGratisIlimitado), @"mvc.1.0.view", @"/Views/Ofertas/LavadoGratisIlimitado.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d9c93052b890664be1d70f0ef33f0daecd62d8", @"/Views/Ofertas/LavadoGratisIlimitado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d9751ebeea2a66464bceb63213afb7dc7c6723", @"/Views/_ViewImports.cshtml")]
    public class Views_Ofertas_LavadoGratisIlimitado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<motovalle.Ecommerce.Models.ViewModels.Landing.ContactLavadoGratisViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Ofertas\LavadoGratisIlimitado.cshtml"
  
    ViewData["Title"] = "Carshow";
    Layout = "~/Views/Shared/Landing/_LayoutLanding.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--<nav class=""navbar fixed-top navbar-expand-lg navbar-dark scrolling-navbar"">
    <div class=""container"">-->
        <!-- Navbar center -->
        <!--<ul class=""navbar-nav nav-flex-icons"" style=""float:none; margin:0 auto; display: block; text-align: center;"">
            <li class=""nav-item"" style=""display: inline-block; float:none;"">
                <a href=""https://wa.me/");
#nullable restore
#line 13 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Ofertas\LavadoGratisIlimitado.cshtml"
                                  Write(TempData["Phone"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""nav-link waves-effect waves-light"" target=""_blank"">
                    <img src=""/landingAssets/img/svg/whatsapp-lollipop.png"" width=""7%"" class=""img-responsive center-block"" alt=""wpp-logo"">  Contáctanos
                </a>
            </li>
        </ul>
    </div>
</nav>-->
<!-- Navbar -->
<!-- Full Page Intro -->
<div class=""view full-page-intro-carshow"">

    <div class=""propia"">

                <label class=""encabezados""> Nombre completo</label>

                <input class=""cuerpo text-black-50"" type=""text""/>                
    </div>
    
    <!-- Mask & flexbox options-->
");
            WriteLiteral("    <div class=\"mask d-flex justify-content-center align-items-center\">\r\n\r\n        <!-- Content -->\r\n        <div class=\"container-fluid\">\r\n\r\n            <!--Grid row-->\r\n");
            WriteLiteral("            <div class=\"row justify-content-end\"> ");
            WriteLiteral("\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1642, "\"", 1650, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <!--Card-->\r\n                    <div class=\"card s-form\" id=\"fmrLavadoIlimitadoGratis\">\r\n");
#nullable restore
#line 44 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Ofertas\LavadoGratisIlimitado.cshtml"
                           await Html.RenderPartialAsync("/Views/Shared/Landing/_ContactFormLavadoGratis.cshtml"); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <!--/.Card-->

                </div>
                <!--Grid column-->

            </div>
            <!--Grid row-->

        </div>
        <!-- Content -->

    </div>
    <!-- Mask & flexbox options-->

</div>
<!-- Full Page Intro -->
<!--Card-->
");
            WriteLiteral("<!--/.Card-->\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 71 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Ofertas\LavadoGratisIlimitado.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script type=""text/javascript"">
        window.onload = () => {
            document.querySelector(""#FullName"").value = """";
            document.querySelector(""#Email"").value = """";
            document.querySelector(""#PhoneNumber"").value = """";
            document.querySelector(""#Message"").value = """";
            document.querySelector(""#City"").value = """";
        }
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<motovalle.Ecommerce.Models.ViewModels.Landing.ContactLavadoGratisViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
