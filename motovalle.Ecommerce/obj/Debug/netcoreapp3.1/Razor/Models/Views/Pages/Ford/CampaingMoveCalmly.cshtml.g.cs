#pragma checksum "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Pages\Ford\CampaingMoveCalmly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6227482aa2d3746ac263d84d6b0eebc3ca29439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Models_Views_Pages_Ford_CampaingMoveCalmly), @"mvc.1.0.view", @"/Models/Views/Pages/Ford/CampaingMoveCalmly.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6227482aa2d3746ac263d84d6b0eebc3ca29439", @"/Models/Views/Pages/Ford/CampaingMoveCalmly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d9751ebeea2a66464bceb63213afb7dc7c6723", @"/Models/Views/_ViewImports.cshtml")]
    public class Models_Views_Pages_Ford_CampaingMoveCalmly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<motovalle.Ecommerce.Models.ViewModels.Landing.ContactViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/landingAssets/img/svg/whatsapp-lollipop.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("7%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive center-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("wpp-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Pages\Ford\CampaingMoveCalmly.cshtml"
  
    ViewData["Title"] = "Movámonos con tranquilidad";
    Layout = "~/Views/Shared/Landing/_LayoutLandingV2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n        /*-------------- set css for different resolutions --------------*/\r\n        .full-page-intro-custom {\r\n            background: url( ");
#nullable restore
#line 12 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Pages\Ford\CampaingMoveCalmly.cshtml"
                        Write(Url.Content("~/landingAssets/img/main/ford/move-calmly/lndng-full.png"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ) no-repeat center;
            background-size: cover;
            background-repeat: no-repeat;
            -webkit-background-size: cover;
            -moz-background-size: cover;
            -o-background-size: cover;
            height: 100%;
            width: 100%;
        }

        /*.button-section {
            background-color: rgb(255, 255, 255);
            opacity: 0;*/ /*Opacidad 60% */
            /*margin-top: -7rem;
        }

        .btn-custom {
            height: 7rem;
        }*/

        ");
                WriteLiteral("@media only screen and (min-width: 1025px) {\r\n            .full-page-intro-custom {\r\n                height: 100%;\r\n            }\r\n        }\r\n\r\n        ");
                WriteLiteral("@media only screen and (max-width: 776px) {\r\n            .full-page-intro-custom {\r\n                background: url( ");
#nullable restore
#line 40 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Pages\Ford\CampaingMoveCalmly.cshtml"
                            Write(Url.Content("~/landingAssets/img/main/ford/move-calmly/lndng-mobile.png"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ) no-repeat top;
                background-size: contain;
                background-repeat: no-repeat;
                -webkit-background-size: contain;
                -moz-background-size: contain;
                -o-background-size: contain;
                height: 100%;
                width: 100%;
            }
        }
    </style>
");
            }
            );
            WriteLiteral(@"
<nav class=""navbar fixed-top navbar-expand-lg navbar-dark scrolling-navbar"">
    <div class=""container"">
        <!-- Navbar center -->
        <ul class=""navbar-nav nav-flex-icons"">
            <li class=""nav-item"" style=""display: inline-block; float:none;"">
                <a");
            BeginWriteAttribute("href", " href=\"", 1989, "\"", 2028, 2);
            WriteAttributeValue("", 1996, "https://wa.me/", 1996, 14, true);
#nullable restore
#line 58 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Pages\Ford\CampaingMoveCalmly.cshtml"
WriteAttributeValue("", 2010, TempData["Phone"], 2010, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link waves-effect waves-light\" target=\"_blank\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e6227482aa2d3746ac263d84d6b0eebc3ca294398725", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            WriteLiteral(" <span class=\"h6\">Contáctanos</span>\r\n                </a>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</nav>\r\n<!-- Navbar -->\r\n<!-- Full Page Intro -->\r\n<div class=\"view full-page-intro-custom\">\r\n</div>\r\n");
            WriteLiteral("\r\n<!--Card-->\r\n<div class=\"card out\">\r\n");
#nullable restore
#line 79 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Pages\Ford\CampaingMoveCalmly.cshtml"
       await Html.RenderPartialAsync("/Views/Shared/Landing/_ContactForm.cshtml"); 

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<!--/.Card-->\r\n<!-- Full Page Intro -->\r\n\r\n");
#nullable restore
#line 84 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Pages\Ford\CampaingMoveCalmly.cshtml"
   await Html.RenderPartialAsync("/Views/Shared/Landing/_ContactFormModal.cshtml"); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 88 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Pages\Ford\CampaingMoveCalmly.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        (async () => {\r\n            if (\'");
#nullable restore
#line 92 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Pages\Ford\CampaingMoveCalmly.cshtml"
            Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' != \'\') {\r\n                if (\'");
#nullable restore
#line 93 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Pages\Ford\CampaingMoveCalmly.cshtml"
                Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' == ""true"") {
                    document.getElementsByName(""frmInfo"").reset();
                    const ToastError = Swal.mixin({
                        toast: true,
                        position: 'top',
                        showConfirmButton: false,
                        timer: 3000,
                        timerProgressBar: true,
                        onOpen: (toast) => {
                            toast.addEventListener('mouseenter', Swal.stopTimer)
                            toast.addEventListener('mouseleave', Swal.resumeTimer)
                        }
                    })

                    await ToastError.fire({
                        icon: 'error',
                        title: '¡Ups!',
                        html: 'Ha sucedido un error al enviar tu información. &#128577;. Intenta nuevamente.',
                    });

                    openFormPopup();
                }
                else {
                    const ToastSuccess = Swal.mixin({
   ");
                WriteLiteral(@"                     toast: true,
                        position: 'top',
                        showConfirmButton: false,
                        timer: 6000,
                        timerProgressBar: true,
                        onOpen: (toast) => {
                            toast.addEventListener('mouseenter', Swal.stopTimer)
                            toast.addEventListener('mouseleave', Swal.resumeTimer)
                        }
                    })

                    await ToastSuccess.fire({
                        icon: 'success',
                        title: '<strong>¡Perfecto!..</strong>',
                        html: 'Tu información ha sido enviada correctamente. &#128512;.'
                    });

                    openFormPopup();
                };
            } else {
                openFormPopup();
            }
        })();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<motovalle.Ecommerce.Models.ViewModels.Landing.ContactViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591