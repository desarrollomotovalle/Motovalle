#pragma checksum "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Blog\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec7005a2a4600b2e880336f38c0f2e835727c8d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Models_Views_Blog_Post), @"mvc.1.0.view", @"/Models/Views/Blog/Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7005a2a4600b2e880336f38c0f2e835727c8d8", @"/Models/Views/Blog/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d9751ebeea2a66464bceb63213afb7dc7c6723", @"/Models/Views/_ViewImports.cshtml")]
    public class Models_Views_Blog_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<inventek_blog.Models.Entities.Posts>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Blog\Post.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""b-article"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-9 col-xs-12"">
                <div class=""b-article__main"">
                    <div class=""b-blog__posts-one"">
                        <div class=""row m-noBlockPadding"">
                            <div class=""col-sm-1 col-xs-2"">
");
            WriteLiteral(@"                            </div>
                            <div class=""col-sm-11 col-xs-10"">
                                <div class=""b-blog__posts-one-body"">
                                    <header class=""b-blog__posts-one-body-head wow zoomInUp"" data-wow-delay=""0.5s"">
                                        <h1 class=""s-titleDet"">");
#nullable restore
#line 33 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Blog\Post.cshtml"
                                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                        <div class=""b-blog__posts-one-body-head-notes"">
                                            <span class=""b-blog__posts-one-body-head-notes-note""><span class=""fa fa-user""></span>Motovalle</span>
                                            <span class=""b-blog__posts-one-body-head-notes-note""><span class=""fa fa-calendar-o""></span>");
#nullable restore
#line 36 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Blog\Post.cshtml"
                                                                                                                                  Write(Model.PostedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <span class=\"b-blog__posts-one-body-head-notes-note\"><span class=\"fa fa-pencil\"></span>");
#nullable restore
#line 37 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Blog\Post.cshtml"
                                                                                                                              Write(Model.FkCategories.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </div>
                                    </header>
                                    <div class=""b-blog__posts-one-body-main wow zoomInUp"" data-wow-delay=""0.5s"">
                                        <div class=""b-blog__posts-one-body-main-img"">
                                            <img loading=""lazy"" class=""img-responsive""");
            BeginWriteAttribute("src", " src=\"", 2803, "\"", 2824, 1);
#nullable restore
#line 42 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Blog\Post.cshtml"
WriteAttributeValue("", 2809, Model.ImageURL, 2809, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2825, "\"", 2843, 1);
#nullable restore
#line 42 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Blog\Post.cshtml"
WriteAttributeValue("", 2831, Model.Title, 2831, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        </div>\r\n                                        ");
#nullable restore
#line 44 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Blog\Post.cshtml"
                                   Write(Html.Raw(@Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                    
                                </div>
                            </div>
                        </div>
                    </div>
                    
                </div>
            </div>
            <div class=""col-md-3 col-xs-12"">
                <aside class=""b-blog__aside"">
");
            WriteLiteral(@"                    <div class=""b-blog__aside-categories wow zoomInUp"" data-wow-delay=""0.5s"">
                        <header class=""s-lineDownLeft"">
                            <h2 class=""s-titleDet"">CATEGORIES</h2>
                        </header>
                        <nav>
                            ");
#nullable restore
#line 66 "E:\Desarrollos\Motovalle\motovalle.Ecommerce\Models\Views\Blog\Post.cshtml"
                       Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </nav>\r\n                    </div>\r\n                </aside>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section><!--b-article-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<inventek_blog.Models.Entities.Posts> Html { get; private set; }
    }
}
#pragma warning restore 1591
