#pragma checksum "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba12a123d9144a5e5ffd0e95e54b047ecb045998"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Index), @"mvc.1.0.view", @"/Views/Productos/Index.cshtml")]
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
#line 3 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba12a123d9144a5e5ffd0e95e54b047ecb045998", @"/Views/Productos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52178d788630418f58f9c3422fb88981e12cf405", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectoAvance1.Models.Producto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
  
    ViewData["Title"] = "Productos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- HEADER -->\r\n<header class=\"container-fluid\">\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 14 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
         using (Html.BeginForm("Index", "Productos", FormMethod.Get))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"" id=""header"">
                <div class=""col-md-9"">
                    <!-- CATEGORIES AND SEARCH -->
                    <div class=""row"">
                        <!-- CATEGORIES BUTTONS -->
                        <div class=""col-md-4 backColor text-right"" id=""btnCategories"">
                            <p>
                                CATEGORIAS
                                <span class=""pl-3"">
                                    <i class=""fa fa-bars"" aria-hidden=""true""></i>
                                </span>
                            </p>
                        </div>
                        <!-- CATEGORIES BUTTONS -->
                        <div class=""col-md-8 input-group pl-0"" id=""search"">
                            <input id=""searchProducto"" type=""search"" name=""searchProducto"" class=""form-control"" placeholder=""Buscar......"" />
                            <button class=""d-none"" type=""submit""");
            BeginWriteAttribute("value", " value=\"", 1291, "\"", 1299, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"buscadorProd\" id=\"buscadorProd\">btn</button>\r\n                            <span class=\"input-group-btn\">\r\n                                <button class=\"btn btn-default backColor\" type=\"submit\"");
            BeginWriteAttribute("value", " value=\"", 1500, "\"", 1508, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""buscadorProd"" id=""searchProdButton"">
                                    <i class=""fa fa-search""></i>
                                </button>
                            </span>
                        </div>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <!-- CART -->
                    <div class=""row"">
                        <div class=""input-group"" id=""cart"">
                            <a href=""productos/carrito"" class=""btn btn-default backColor"" id=""cartLogo"">
                                <i class=""fa fa-shopping-cart""></i>
                            </a>
                            <p class=""w-50"">TOTAL PRODUCTOS <span class=""quantityCart pl-2 font-weight-bold""></span> <br> TOTAL USD <span class=""sumCart pl-4 font-weight-bold""></span></p>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 53 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</header>\r\n\r\n<!-- CATEGORIES -->\r\n<div class=\"col-md-12 backColor\" id=\"categories\" style=\"display:none\">\r\n    <div class=\"row mb-2\">\r\n");
#nullable restore
#line 60 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
         using (Html.BeginForm("Index", "Productos", FormMethod.Get, new { @class = "row w-100" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
             foreach (var categoria in ViewBag.Categorias)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 text-center\">\r\n                    <h5 class=\"p-2\">\r\n                        <a href=\"#\" class=\"pixelCategories buscadorCat\" name=\"buscadorCat\"");
            BeginWriteAttribute("id", " id=\"", 2985, "\"", 3015, 2);
            WriteAttributeValue("", 2990, "buscadorCat_", 2990, 12, true);
#nullable restore
#line 66 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
WriteAttributeValue("", 3002, categoria.Id, 3002, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("catId", " catId=\"", 3016, "\"", 3037, 1);
#nullable restore
#line 66 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
WriteAttributeValue("", 3024, categoria.Id, 3024, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                                                                                                                           Write(categoria.NombreCategoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </h5>\r\n                </div>\r\n");
#nullable restore
#line 69 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"d-none\" type=\"submit\"");
            BeginWriteAttribute("value", " value=\"", 3185, "\"", 3193, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"buscadorCat\" id=\"buscadorCat\">btn</button>\r\n");
#nullable restore
#line 71 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<!--PRODUCTS BAR -->
<div class=""container-fluid well well-sm barProducts"">
    <div class=""container"">
        <div class=""row mb-3"">
            <div class=""col-sm-6 col-xs-12 text-left"">
                <button class=""btn btn-sm backColor"" id=""btnMostrarTodos""> TODOS </button>
                <div class=""btn-group"">
                    <button type=""button"" class=""btn btn-default dropdown-toggle"" data-toggle=""dropdown"">Ordenar Productos<span class=""caret""></span></button>
                    <ul class=""dropdown-menu"" role=""menu"">
                        <li><a href=""#"">Más reciente</a></li>
                        <li><a href=""#"">Más antiguos</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<!--PRODUCTS LIST -->
<div class=""container-fluid products"">
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 97 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
             if (ViewBag.Productos == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-xs-12 error404 text-center\">\r\n                    <h1><small>¡Oops!</small></h1>\r\n                    <h2>Aun no hay productos en esta sección!</h2>\r\n                </div>\r\n");
#nullable restore
#line 103 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul class=\"grid0\">\r\n");
#nullable restore
#line 107 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                     foreach (var producto in ViewBag.Productos)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"col-xs-12\">\r\n                            <figure>\r\n                                <a href=\"#\" class=\"pixelProduct\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 4812, "\"", 4832, 1);
#nullable restore
#line 112 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
WriteAttributeValue("", 4818, producto.Foto, 4818, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                                </a>\r\n                            </figure>\r\n                            ");
#nullable restore
#line 115 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                       Write(producto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <h4>\r\n                                <small>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5086, "\"", 5093, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"pixelProduct\">\r\n                                        ");
#nullable restore
#line 119 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                   Write(producto.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                                        <span style=\"color:rgba(0,0,0,0)\">-</span>\r\n");
#nullable restore
#line 121 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                         if (producto.Nuevo != 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"label label-warning fontSize\">Nuevo</span>\r\n");
#nullable restore
#line 124 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                         if (producto.Oferta != 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"label label-warning fontSize\">");
#nullable restore
#line 127 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                                                                  Write(producto.Descuento);

#line default
#line hidden
#nullable disable
            WriteLiteral(" % OFF</span>\r\n");
#nullable restore
#line 128 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </a>
                                </small>
                            </h4>
                            <div class=""col-xs-6 price"">
                                <div class=""row"">
                                    <div class=""col-xs-6 pl-4"">
");
#nullable restore
#line 135 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                         if (producto.Precio == 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h2><small>GRATIS</small></h2>\r\n");
#nullable restore
#line 138 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                        }
                                        else
                                        {
                                            if (producto.Oferta != 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <h2>\r\n                                                    <small>\r\n                                                        <strong class=\"offer\"> USD $ ");
#nullable restore
#line 145 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                                                                Write(producto.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                                    </small>\r\n                                                    <small>$ ");
#nullable restore
#line 147 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                                        Write(producto.PrecioOferta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                                </h2>\r\n");
#nullable restore
#line 149 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <h2><small>USD $ ");
#nullable restore
#line 152 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                                            Write(producto.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></h2>\r\n");
#nullable restore
#line 153 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <div class=\"col-xs-6 pl-4\">\r\n                                        <button class=\"btn backColor agregarCarrito\" data-idproducto=\"");
#nullable restore
#line 157 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                                                                                                 Write(producto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("codproducto", " codproducto=\"", 7519, "\"", 7549, 1);
#nullable restore
#line 157 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
WriteAttributeValue("", 7533, producto.Codigo, 7533, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("descproducto", " descproducto=\"", 7550, "\"", 7586, 1);
#nullable restore
#line 157 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
WriteAttributeValue("", 7565, producto.Descripcion, 7565, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("precio", " precio=\"", 7587, "\"", 7612, 1);
#nullable restore
#line 157 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
WriteAttributeValue("", 7596, producto.Precio, 7596, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("imgpath", " imgpath=\"", 7613, "\"", 7637, 1);
#nullable restore
#line 157 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
WriteAttributeValue("", 7623, producto.Foto, 7623, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Agregar a Carrito</button>\r\n                                    </div>\r\n\r\n                                </div>\r\n\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 164 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n");
#nullable restore
#line 166 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"clearfix\"></div>\r\n        </div>\r\n    </div>\r\n    <div class=\"paginationDiv fondoContainer\">\r\n        ");
#nullable restore
#line 171 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Index.cshtml"
   Write(Html.PagedListPager((IPagedList)ViewBag.Productos, page => Url.Action("Index", new { page = page }),
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //Corregir error en estilos de paginacion
        $(document).ready(function () {
            $('ul.pagination > li.disabled > a').addClass('page-link');

            //Verificar totales de carrito
            var carrito = JSON.parse(localStorage.getItem('listaCarrito'));
            let cuentaCarrito = 0;
            let totalCarrito = 0;

            if (carrito) {

                cuentaCarrito = carrito.length;

                for (var i = 0; i < cuentaCarrito; i++) {
                    totalCarrito = totalCarrito + parseFloat(carrito[i].subTotal);
                }

                $('.quantityCart').html(cuentaCarrito);
                $('.sumCart').html(""$ "" + totalCarrito);
                $('#cartLogo').removeClass('backColor');
                $('#cartLogo').addClass('bg-success');
            } else {
                $('.quantityCart').html(0);
                $('.sumCart').html(""$ 0.00"");
                $('#cartLogo').removeClass('bg-success');
");
                WriteLiteral(@"                $('#cartLogo').addClass('backColor');
            }


            //Filtrar Productos por Categoria
            $("".buscadorCat"").on('click', function () {
                let catId = $(this).attr('catid');
                $(""#buscadorCat"").val(catId);
                $(""#buscadorCat"").click();
            });

            //Filtrar Productos por string input ""search""
            $(""#searchProducto"").on('keypress', function (e) {
                if (e.which === 13) {
                    let stringSearch = $(this).val();
                    $(""#buscadorProd"").val(stringSearch);
                    $(""#buscadorProd"").click();
                }
            });

            //Filtrar Productos por string button ""searchProdButton""
            $(""#searchProdButton"").on('click', function () {
                let stringSearch = $(""#searchProducto"").val();
                $(this).val(stringSearch);

                console.log(stringSearch);
                console.log($(this)");
                WriteLiteral(@".val());
            });

            //Quitar Filtro de Categoria y producto
            $(""#btnMostrarTodos"").on('click', function () {
                $(""#buscadorCat"").val();
                $(""#buscadorCat"").click();
            });

            //Expandir Categorias
            $(""#btnCategories"").on('click', function () {

                if (window.matchMedia(""(max-width:767px)"").matches) {

                    $(""#btnCategories"").after($(""#categories"").slideToggle(""fast""))

                } else {

                    $(""#header"").after($(""#categories"").slideToggle(""fast""))

                }


            })

            //Agregar producto a Carrito de Compras
            $('.agregarCarrito').on('click', function () {

                // Array para carrito de compras, si existe llenara array con elementos de LocalStorage
                var name = localStorage.getItem('listaCarrito');
                var listaProductosCarrito = [];

                if (name) {
     ");
                WriteLiteral(@"               listaProductosCarrito = JSON.parse(localStorage.getItem('listaCarrito'));
                }

                let idProducto = $(this).data('idproducto');
                let codProducto = $(this).attr('codproducto');
                let descProducto = $(this).attr('descproducto');
                let imgProducto = $(this).attr('imgpath');
                let precioItem = $(this).attr('precio');
                let cantProducto = 1;
                let totalValor = parseFloat(totalCarrito) + parseFloat(precioItem);

                Swal.fire({
                    title: 'Esta seguro?',
                    text: ""Esta por agregar el producto: "" + idProducto + "" / "" + codProducto + "" / "" + descProducto + "" al Carrito de Compras!"",
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    cancelButtonText: 'Cancelar',
                    con");
                WriteLiteral(@"firmButtonText: 'Sí, agregar a mi carrito!'
                }).then((result) => {
                    if (result.isConfirmed) {
                        //Agrgar producto a variable
                        listaProductosCarrito.push({
                            ""idProducto"": idProducto,
                            ""codProducto"": codProducto,
                            ""descProducto"": descProducto,
                            ""imagen"": imgProducto,
                            ""precio"": precioItem,
                            ""cantProducto"": cantProducto,
                            ""subTotal"": parseFloat(precioItem) * parseFloat(cantProducto)
                        })

                        //Enviar arreglo de carrito a variable de localStorage y actualizar totales de carrito
                        localStorage.setItem('listaCarrito', JSON.stringify(listaProductosCarrito));
                        //Actualizar totales de carrito
                        $('.quantityCart').html(listaProduct");
                WriteLiteral(@"osCarrito.length);
                        $('.sumCart').html(""$ "" + totalValor);
                        //Cambiar color a logo
                        $('#cartLogo').removeClass('backColor');
                        $('#cartLogo').addClass('bg-success');

                        Swal.fire(
                            'Agregado!',
                            'Producto agregado a carrito de compras.',
                            'success'
                        )
                    }
                })
            });

            /*=============================================
            DISPLAY GRID OR LIST
            =============================================*/
            var btnList = $("".btnList"");

            for (var i = 0; i < btnList.length; i++) {

                $(""#btnGrid"" + i).click(function () {

                    var number = $(this).attr(""id"").substr(-1);

                    $("".list"" + number).hide();
                    $("".grid"" + number).show();

");
                WriteLiteral(@"                    $(""#btnGrid"" + number).addClass(""backColor"");
                    $(""#btnList"" + number).removeClass(""backColor"");
                })

                $(""#btnList"" + i).click(function () {

                    var number = $(this).attr(""id"").substr(-1);

                    $("".list"" + number).show();
                    $("".grid"" + number).hide();

                    $(""#btnGrid"" + number).removeClass(""backColor"");
                    $(""#btnList"" + number).addClass(""backColor"");
                })
            }


            /*=======================================
            =            ZOOM EFFECT                =
            =======================================*/
            $("".productInfo figure.visor img"").mouseover(function (event) {

                var captureImg = $(this).attr(""src"");

                $("".zoom img"").attr(""src"", captureImg);
                $("".zoom"").fadeIn(""fast"");
                $("".zoom"").css({
                    ""height"":");
                WriteLiteral(@" $("".visorImg"").height() + ""px"",
                    ""background"": ""#eee"",
                    ""width"": ""100%""
                })
            })

            $("".productInfo figure.visor img"").mouseout(function (event) {

                $("".zoom"").fadeOut(""fast"");
            })

            $("".productInfo figure.visor img"").mousemove(function (event) {
                var posX = event.offsetX;
                var posY = event.offsetY;

                $("".zoom img"").css({
                    ""margin-left"": -posX + ""px"",
                    ""margin-top"": -posY + ""px""
                })
            })

            /*=======================================
            =         COMMENTS HEIGHT               =
            =======================================*/
            $("".comments"").css({
                ""height"": $("".comments .heightComment"").height() + ""px"",
                ""overflow"": ""hidden"",
                ""margin-botton"": ""20px""
            })

            $(""#seeMo");
                WriteLiteral(@"re"").click(function (e) {

                e.preventDefault();

                if ($(""#seeMore"").html() == ""VER MAS"") {

                    $("".comments"").css({ ""overflow"": ""inherit"" });
                    $(""#seeMore"").html(""VER MENOS"");

                } else {

                    $("".comments"").css({
                        ""height"": $("".comments .heightComment"").height() + ""px"",
                        ""overflow"": ""hidden"",
                        ""margin-botton"": ""20px""
                    })
                    $(""#seeMore"").html(""VER MAS"");
                }

            })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectoAvance1.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591