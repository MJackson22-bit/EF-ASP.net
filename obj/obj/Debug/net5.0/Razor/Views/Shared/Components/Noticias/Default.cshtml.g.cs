#pragma checksum "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Shared/Components/Noticias/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48cf565834a893861d2644abf9c8079409a5d36f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Noticias_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Noticias/Default.cshtml")]
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
#line 1 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/_ViewImports.cshtml"
using Practica_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/_ViewImports.cshtml"
using Practica_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48cf565834a893861d2644abf9c8079409a5d36f", @"/Views/Shared/Components/Noticias/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a93cac4649bf1b647e2b9ac7819af84d80899cdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Noticias_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Practica_2.Models.Noticias>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container-fluid\" style=\"margin-top: 30px;\">\n");
#nullable restore
#line 3 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Shared/Components/Noticias/Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"toast\" role=\"alert\" aria-live=\"assertive\" aria-atomic=\"true\" data-autohide=\"false\">\n            <div class=\"toast-header\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 298, "\"", 316, 1);
#nullable restore
#line 7 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Shared/Components/Noticias/Default.cshtml"
WriteAttributeValue("", 304, item.Imagen, 304, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded mr-2\" alt=\"...\">\n                <strong class=\"mr-auto\">");
#nullable restore
#line 8 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Shared/Components/Noticias/Default.cshtml"
                                   Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                <small>");
#nullable restore
#line 9 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Shared/Components/Noticias/Default.cshtml"
                  Write(item.Posteo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                <button type=""button"" class=""ml-2 mb-1 close"" data-dismiss=""toast"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""toast-body"">
                ");
#nullable restore
#line 15 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Shared/Components/Noticias/Default.cshtml"
           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n");
#nullable restore
#line 18 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Shared/Components/Noticias/Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Practica_2.Models.Noticias>> Html { get; private set; }
    }
}
#pragma warning restore 1591
