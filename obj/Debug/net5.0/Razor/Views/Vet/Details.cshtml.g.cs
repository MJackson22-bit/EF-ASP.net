#pragma checksum "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Vet/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e0f93a63e984869e15f0cdb6aa644007ab40e31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vet_Details), @"mvc.1.0.view", @"/Views/Vet/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0f93a63e984869e15f0cdb6aa644007ab40e31", @"/Views/Vet/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a93cac4649bf1b647e2b9ac7819af84d80899cdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Vet_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Practica_2.ViewModels.VeterinariaNoticiasViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("styles", async() => {
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"noticia_style.css\" type=\"text/css\">\n");
            }
            );
            WriteLiteral("<div class=\"row\">\n    <h1 style=\"padding-left: 40%;\">");
#nullable restore
#line 6 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Vet/Details.cshtml"
                              Write(Model.Veterinaria.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <br><br><br>\n</div>\n<div class=\"container\">\n  <div class=\"col-md-3\" > \n      <img style=\"padding-left: 90%\"");
            BeginWriteAttribute("src", " src=\"", 341, "\"", 377, 1);
#nullable restore
#line 11 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Vet/Details.cshtml"
WriteAttributeValue("", 347, Model.Veterinaria.ImageDetail, 347, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"imagen\" alt=\"...\">\n     \n    </div>\n</div>\n");
            DefineSection("Rigth", async() => {
                WriteLiteral("\n <div class=\"col-md-14\">\n      <div class=\"card-body\">\n        <p class=\"card-text\">");
#nullable restore
#line 18 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Vet/Details.cshtml"
                        Write(Model.Veterinaria.Descripcion);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        <p class=\"card-text\"><small class=\"text-muted\">Aplicable a: ");
#nullable restore
#line 19 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Vet/Details.cshtml"
                                                               Write(Model.Veterinaria.Aplicabilidad);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 19 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Vet/Details.cshtml"
                                                                                                  Write(Model.Veterinaria.Modo);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</small></p>
        <div class=""accordion"" id=""accordionExample"">
            <div class=""card"">
                    <div class=""card-header"" id=""headingOne"">
                        <h2 class=""mb-0"">
                            <button class=""btn btn-link"" type=""button"" data-toggle=""collapse"" data-target=""#collapseOne""
                                aria-expanded=""true"" aria-controls=""collapseOne"">
                                Formulación
                            </button>
                        </h2>
                    </div>

                    <div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne""
                        data-parent=""#accordionExample"">
                        <div class=""card-body"">
                            ");
#nullable restore
#line 34 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Vet/Details.cshtml"
                       Write(Model.Veterinaria.Formulacion);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"" id=""headingTwo"">
                        <h2 class=""mb-0"">
                            <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse""
                                data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                                Indicaciones
                            </button>
                        </h2>
                    </div>
                    <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionExample"">
                        <div class=""card-body"">
                            ");
#nullable restore
#line 49 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Vet/Details.cshtml"
                       Write(Model.Veterinaria.Indicaciones);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"" id=""headingThree"">
                        <h2 class=""mb-0"">
                            <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse""
                                data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                                Dosis y Administración
                            </button>
                        </h2>
                    </div>
                    <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree""
                        data-parent=""#accordionExample"">
                        <div class=""card-body"">
                            ");
#nullable restore
#line 65 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Vet/Details.cshtml"
                       Write(Model.Veterinaria.DosisAdm);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"" id=""headingFour"">
                        <h2 class=""mb-0"">
                            <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse""
                                data-target=""#collapseFour"" aria-expanded=""false"" aria-controls=""collapseFour"">
                                Presentación Comercial
                            </button>
                        </h2>
                    </div>
                    <div id=""collapseFour"" class=""collapse"" aria-labelledby=""headingFour""
                        data-parent=""#accordionExample"">
                        <div class=""card-body"">
                            ");
#nullable restore
#line 81 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Vet/Details.cshtml"
                       Write(Model.Veterinaria.Presentacion);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n        </div>\n        <a href=\"/Vet\" class=\"btn btn-outline-dark\" style=\"margin-top: 12px;\">Regresar</a>\n      </div>\n      \n    </div>\n");
            }
            );
            DefineSection("Footer", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 92 "/home/sansepi0l/Documentos/Proyectos_-_ASP.NET/Practica_4/Views/Vet/Details.cshtml"
Write(Html.Partial("Noticias", Model.ListNoticias));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Practica_2.ViewModels.VeterinariaNoticiasViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
