#pragma checksum "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d877769c9c2a2239731209eb80dd39089b541cbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LandingPages_Index), @"mvc.1.0.view", @"/Views/LandingPages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d877769c9c2a2239731209eb80dd39089b541cbf", @"/Views/LandingPages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d9751ebeea2a66464bceb63213afb7dc7c6723", @"/Views/_ViewImports.cshtml")]
    public class Views_LandingPages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inventek.ERP.Models.Entities.Ecommerce.EcommerceCustomPages>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Page", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
  
    ViewData["Title"] = "Custom Page Admin";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12 clearfix"">
                <div class=""col-12 text-center"">
                    <h1 class=""m-0 text-dark"">Administrador de Custom Pages</h1>
                </div>
                <div class=""text-left"">
                    <button id=""btnAddPage"" onclick=""AddEditPage(0)"" class=""btn btn-secondary"">Add New Page</button>
                </div>
                <br />
                <div class=""row"">
                    <div class=""table"">
                        <table class=""table"">
                            <thead>
                                <tr>
");
#nullable restore
#line 24 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                     try
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th>\r\n                                            ");
#nullable restore
#line 27 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.PageTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 30 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.PageDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 33 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.pageKeywords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 36 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.FkEcommerceCustomMenuID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 39 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.URL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 42 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.SliderImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th></th>\r\n");
#nullable restore
#line 45 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                    }
                                    catch
                                    {

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 54 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                 try
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 60 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.PageTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 63 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.PageDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 66 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.pageKeywords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 69 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.FkEcommerceCustomMenuID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 72 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.URL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 75 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.SliderImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                <a href=\"javascript:;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3994, "\"", 4045, 3);
            WriteAttributeValue("", 4004, "AddEditPage(", 4004, 12, true);
#nullable restore
#line 78 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
WriteAttributeValue("", 4016, item.EcommerceCustomPagesId, 4016, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4044, ")", 4044, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                                                <a href=\"javascript:;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4129, "\"", 4182, 3);
            WriteAttributeValue("", 4139, "DeleteElement(", 4139, 14, true);
#nullable restore
#line 79 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
WriteAttributeValue("", 4153, item.EcommerceCustomPagesId, 4153, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4181, ")", 4181, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a> |\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d877769c9c2a2239731209eb80dd39089b541cbf13081", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                                                        WriteLiteral(item.URL);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 83 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\LandingPages\Index.cshtml"
                                     
                                }
                                catch
                                {

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </tbody>
                        </table>

                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<style>
    .e-content .e-item {
        font-size: 12px;
        padding: 10px;
        text-align: justify;
    }
</style>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        var AddEditPage = function (itemId) {
            var url;
            if (itemId > 0)
                url = ""/LandingPages/Edit/"" + itemId;
            else
                url = ""/LandingPages/Create"";

            window.location.href = url;
        }

        var DeleteElement = async function (itemId) {
            let ans = await Swal.fire({
                title: `Do you want to delete item: ""${itemId}"". Are you sure?`,
                text: ""You won't be able to revert this!"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, delete it!',
                allowOutsideClick: false,
                allowEscapeKey: false,
                focusCancel: true
            });

            if (ans.isConfirmed) {
                await Swal.fire({
                    title: 'Deleted!',
   ");
                WriteLiteral(@"                 text: 'Your record has been deleted.',
                    icon: 'success',
                    timer: 5000,
                    timerProgressBar: true
                });

                window.location.href = '/LandingPages/Delete/' + itemId;
            }
        }
        //var DeleteElement = async function (item) {
        //    let ans = await Swal.fire({
        //        title: `Do you want to delete the selected item?`,
        //        text: ""You won't be able to revert this!"",
        //        icon: 'warning',
        //        showCancelButton: true,
        //        confirmButtonColor: '#3085d6',
        //        cancelButtonColor: '#d33',
        //        confirmButtonText: 'Yes, delete it!',
        //        allowOutsideClick: false,
        //        allowEscapeKey: false,
        //        focusCancel: true
        //    });

        //    if (ans.isConfirmed) {
        //        await Swal.fire({
        //            title: 'Deleted!',
    ");
                WriteLiteral(@"    //            text: 'Your record has been deleted.',
        //            icon: 'success',
        //            timer: 5000,
        //            timerProgressBar: true
        //        });

        //        window.location.href = '/' + ItemClass + '/Delete/' + itemId;
        //    }
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inventek.ERP.Models.Entities.Ecommerce.EcommerceCustomPages>> Html { get; private set; }
    }
}
#pragma warning restore 1591
