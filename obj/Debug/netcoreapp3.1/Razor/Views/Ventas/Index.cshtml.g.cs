#pragma checksum "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27905fa5b65ee2a3c57df8aa1441e5908fbdb95d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ventas_Index), @"mvc.1.0.view", @"/Views/Ventas/Index.cshtml")]
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
#line 1 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\_ViewImports.cshtml"
using ProjectoAvance1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\_ViewImports.cshtml"
using ProjectoAvance1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27905fa5b65ee2a3c57df8aa1441e5908fbdb95d", @"/Views/Ventas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52178d788630418f58f9c3422fb88981e12cf405", @"/Views/_ViewImports.cshtml")]
    public class Views_Ventas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectoAvance1.Models.Venta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
  
    ViewData["Title"] = "Ventas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container px-3 my-5 clearfix"">
    <div class=""row"">
        <table class=""table table-sm table-hover table-striped table-bordered"">
            <thead class=""text-center"">
                <tr>
                    <th>Id</th>
                    <th>Fecha</th>
                    <th>Cliente</th>
                    <th>Email</th>
                    <th>Tel??fono</th>
                    <th>Pa??s</th>
                    <th>Ciudad/Departamento</th>
                    <th>Tipo de Pago</th>
                    <th>Valor</th>
                    <th>Acciones</th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 30 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
                 foreach (var item in ViewBag.Ventas)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"no-wrap\">\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
                       Write(item.Fecha.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
                       Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
                                    Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
                       Write(item.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
                       Write(item.Pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
                       Write(item.Departamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
                       Write(item.TipoPago);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>$");
#nullable restore
#line 41 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
                        Write(item.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>
                            <a class=""btn btn-sm btn-primary"" href=""#""><i class=""fa-solid fa-list-ol""></i></a>
                            <a class=""btn btn-sm btn-secondary"" href=""#""><i class=""fa-solid fa-pencil""></i></a>
                            <a class=""btn btn-sm btn-danger"" href=""#""><i class=""fa-solid fa-trash-can""></i></a>
                        </td>
                    </tr>
");
#nullable restore
#line 48 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div class=\"paginationDiv fondoContainer\">\r\n    ");
#nullable restore
#line 54 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Ventas\Index.cshtml"
Write(Html.PagedListPager((IPagedList)ViewBag.Ventas, page => Url.Action("Index", new { page = page }),
    new X.PagedList.Mvc.Common.PagedListRenderOptions
    {
        DisplayItemSliceAndTotal = true,
        ContainerDivClasses = new[] { "page-item" },
        LiElementClasses = new[] { "page-item" },
        PageClasses = new[] { "page-link" },
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        //Corregir error en estilos de paginacion\r\n        $(document).ready(function () {\r\n            $(\'ul.pagination > li.disabled > a\').addClass(\'page-link\');\r\n        })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectoAvance1.Models.Venta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
