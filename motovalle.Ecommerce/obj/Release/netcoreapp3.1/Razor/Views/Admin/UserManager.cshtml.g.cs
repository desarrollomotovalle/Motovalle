#pragma checksum "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28465fdd5d0adcdc415649d2257810e97fce2e95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserManager), @"mvc.1.0.view", @"/Views/Admin/UserManager.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28465fdd5d0adcdc415649d2257810e97fce2e95", @"/Views/Admin/UserManager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d9751ebeea2a66464bceb63213afb7dc7c6723", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UserManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<motovalle.Ecommerce.Models.ViewModels.Admin.UserManagerViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
  
    ViewData["Title"] = "UserManager";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content"">
    <div class=""container"">
        <div>
            <div class=""col-12 text-center"">
                <h1 class=""m-0 text-dark"">Administrador de usuarios</h1>
            </div>
        </div>
        <div class=""table"">
            <table id=""dtUserManagerId"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
                <thead>
                    <tr>
                        <th class=""th-sm"">
                            Id
                        </th>
                        <th class=""th-sm"">
                            Nombres
                        </th>
                        <th class=""th-sm"">
                            Correo/Usuario
                        </th>
                        <th class=""th-sm"">
                            ¿Correo confirmado?
                        </th>
                        <th class=""th-lg"">
                            Cuenta bloqueada hasta
                        </th>
   ");
            WriteLiteral(@"                     <th class=""th-lg"">
                            Role
                        </th>
                        <th class=""th-lg"">
                            Role Manager
                        </th>
                        <th class=""th-lg"">
                            Desbloquear cuenta
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 46 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 49 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                           Write(item.ApplicationUser.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 50 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                           Write(item.ApplicationUser.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                           Write(item.ApplicationUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 52 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                                                Write(item.ApplicationUser.EmailConfirmed ? "Si" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 53 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                                               Write(item.ApplicationUser.LockoutEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">\r\n");
#nullable restore
#line 55 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                                  var content = string.Empty;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                                 if (item.Roles.Count > 0)
                                {
                                    foreach (var role in item.Roles)
                                    {
                                        content += string.Concat(role, ", ");
                                    }

                                    content = content.Substring(0, content.Length - 2);
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 66 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                           Write(content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-center\">");
#nullable restore
#line 68 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                                               Write(Html.ActionLink("Role manager", "RoleManager", "Admin", new { userId = item.ApplicationUser.Id }, new { @class = "btn btn-success", style = "width:100%;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 69 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                             if (item.ApplicationUser.LockoutEnd != null && item.ApplicationUser.LockoutEnd > DateTime.Now)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><button type=\"button\" class=\"btn btn-info btn-block\" style=\"width:100%\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3255, "\"", 3306, 3);
            WriteAttributeValue("", 3265, "unlockoutUser(\'", 3265, 15, true);
#nullable restore
#line 71 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
WriteAttributeValue("", 3280, item.ApplicationUser.Id, 3280, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3304, "\')", 3304, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Desbloquear usuario</button></td>\r\n");
#nullable restore
#line 72 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><button type=\"button\" class=\"btn btn-info btn-block\" style=\"width:100%\" disabled");
            BeginWriteAttribute("onclick", " onclick=\"", 3555, "\"", 3606, 3);
            WriteAttributeValue("", 3565, "unlockoutUser(\'", 3565, 15, true);
#nullable restore
#line 75 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
WriteAttributeValue("", 3580, item.ApplicationUser.Id, 3580, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3604, "\')", 3604, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Desbloquear usuario</button></td>\r\n");
#nullable restore
#line 76 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 78 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Views\Admin\UserManager.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#dtUserManagerId').DataTable({
                ""autoWidth"": true,
                ""paging"": true,
                ""ordering"": true,
                ""scrollY"": true,
                ""searching"": true,
            });

            $('.dataTables_length').addClass('bs-select');
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<motovalle.Ecommerce.Models.ViewModels.Admin.UserManagerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
