#pragma checksum "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Carrito.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcbc4b173c66c5ce0ec6c3884bece16accab8edf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Carrito), @"mvc.1.0.view", @"/Views/Productos/Carrito.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcbc4b173c66c5ce0ec6c3884bece16accab8edf", @"/Views/Productos/Carrito.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52178d788630418f58f9c3422fb88981e12cf405", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Carrito : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectoAvance1.Models.Producto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eduardo Trujillo\Documents\ChifungOneDrive\OneDrive\UDB\2022\2022-1\DAS901\Unidad_3\Proyecto1\ProjectoAvance1\Views\Productos\Carrito.cshtml"
  
    ViewData["Title"] = "Carrito";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container px-3 my-5 clearfix"">
    <!-- Shopping cart table -->
    <div class=""card"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-4 pl-4"">
                    <h2>Carrito de Compras</h2>
                </div>
                <div class=""col-4""></div>
                <div class=""col-4 text-right"">
                    <button class=""btn btn-sm btn-danger mt-2"" onclick=""borrarCarrito()"">Vaciar Carrito</button>
                </div>
            </div>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered m-0""  id=""detalleCarrito"">
                    <thead>
                        <tr>
                            <!-- Set columns width -->
                            <th class=""text-center py-3 px-4"" style=""min-width: 300px;"">Nombre Producto &amp; Detalles</th>
                            <th class=""text-right py-3 px-4"" style=""width: 150");
            WriteLiteral(@"px;"">Precio</th>
                            <th class=""text-center py-3 px-4"" style=""width: 120px;"">Cantidad</th>
                            <th class=""text-right py-3 px-4"" style=""width: 150px;"">Total</th>
                            <th class=""text-center align-middle py-3 px-0"" style=""width: 40px;""><a href=""#"" class=""shop-tooltip float-none text-light""");
            BeginWriteAttribute("title", " title=\"", 1482, "\"", 1490, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-original-title=""Clear cart""><i class=""ino ion-md-trash""></i></a></th>
                        </tr>
                    </thead>
                    <tbody>
                        <!--Cargar dinamicamente detalle-->
                    </tbody>
                </table>
            </div>
            <!-- / Shopping cart table -->

            <div class=""row justify-content-end"">
                    <div>
                        <div class=""mt-4 mr-5 pr-3 text-center"">
                            <label class=""text-muted font-weight-normal m-0"">Total price</label>
                            <div class=""text-large font-weight-bold totalCarrito border border-success rounded"" style=""width:100px""></div>
                        </div>
                    </div>
            </div>

            <div class=""row justify-content-end"">
                    <a href=""/productos"" class=""btn btn-lg btn-secondary md-btn-flat mt-2 mr-3"">Back to shopping</a>
                    <a href=""checkout"" cl");
            WriteLiteral("ass=\"btn btn-lg btn-primary mt-2\">Checkout</a>\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //Cargar datos de Carrito
        var carrito = JSON.parse(localStorage.getItem('listaCarrito'));
        let cuentaCarrito = 0;
        let totalCarrito = 0;

        if (carrito) {

            cuentaCarrito = carrito.length;

            for (var i = 0; i < cuentaCarrito; i++) {
                totalCarrito = totalCarrito + parseFloat(carrito[i].subTotal);

                //Llenar tabla de detalle
                $('table#detalleCarrito tbody').append(
                    '<tr>'+
                        '<td class=""p-4"">'+
                            '<div class=""media align-items-center"">'+
                                '<img src=""'+carrito[i].imagen+'"" class=""d-block ui-w-40 ui-bordered mr-4 thumbnail"" style=""width:100px;lentgth:100px"" alt="""">'+
                                    '<div class=""media-body"">'+
                                        '<a href=""#"" class=""d-block text-dark"">' + carrito[i].codProducto +'</a>'+
                                     ");
                WriteLiteral(@"   '<small>'+
                                            '<span class=""text-muted"">' + carrito[i].descProducto +'</span>'+
                                        '</small>'+
                                    '</div>'+
                                '</div>'+
                        '</td>'+
                        '<td class=""text-right font-weight-semibold align-middle p-4""> $ ' + carrito[i].precio +'</td>'+
                        '<td class=""align-middle p-4""><input type=""text"" class=""form-control text-center"" value=""' + carrito[i].cantProducto +'""></td>'+
                        '<td class=""text-right font-weight-semibold align-middle p-4"">$ ' + carrito[i].subTotal +'</td>'+
                        '<td class=""text-center align-middle px-0""><a href=""#"" class=""shop-tooltip close float-none text-danger removerItem"" title="""" data-original-title=""Remove"" data-id=""'+i+'"">×</a></td>'+
                        '</tr>'
                );
            }

            //Actualizar total carrito
   ");
                WriteLiteral(@"         $('.totalCarrito').html(""$ "" + totalCarrito);
        } else {
            $('.quantityCart').html(0);
            $('.sumCart').html(""$ 0.00"");
        }


        //remover item del carrito de compras
        $('.removerItem').on('click', function () {

            let itemBorrar = $(this).data('id');

            Swal.fire({
                title: 'Esta seguro?',
                text: ""Esta seguro de querer borrar este artículo?"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                cancelButtonText: 'Cancelar',
                confirmButtonText: 'Sí, remover artículo de mi carrito de compras!'
            }).then((result) => {
                if (result.isConfirmed) {
                    //Eliminar artículo
                    for (var i = 0; i < carrito.length; i++) {
                        if (i === itemBorrar) {
                            car");
                WriteLiteral(@"rito.splice(i, 1);
                        }
                    }

                    //Actualizar localStorage con array actualizado
                    localStorage.setItem('listaCarrito', JSON.stringify(carrito));

                    //Recargar pagina carrito
                    location.reload();
                }
            })
        });

        //Borrar carrito de compras
        function borrarCarrito() {
            Swal.fire({
                title: 'Esta seguro?',
                text: ""Esta seguro de borrar todo el contenido del Carrito de Compras!"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                cancelButtonText:'Cancelar',
                confirmButtonText: 'Sí, borrar contenido de carrito!'
            }).then((result) => {
                if (result.isConfirmed) {
                    //Eliminar localStorage
                    local");
                WriteLiteral(@"Storage.removeItem('listaCarrito');

                    Swal.fire(
                        'Borrado!',
                        'Contenido de Carrito de Compras eliminado!',
                        'success'
                    )

                    window.location.href = '/productos';
                }
            })
        };
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