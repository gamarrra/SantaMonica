#pragma checksum "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9e2c664685c604c29118f7cb87669d153d6d00e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Agregar), @"mvc.1.0.view", @"/Views/Productos/Agregar.cshtml")]
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
#line 1 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\_ViewImports.cshtml"
using HPPParcial2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\_ViewImports.cshtml"
using HPPParcial2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9e2c664685c604c29118f7cb87669d153d6d00e", @"/Views/Productos/Agregar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb989f5403b0fd7694b75725eb880ddc358167df", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Agregar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Productos>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"content\">\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Nuevo Producto</h1>\r\n        <br>\r\n        ");
#nullable restore
#line 8 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
   Write(Html.ActionLink("Volver sin guardar cambios","Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br>\r\n        <br>\r\n");
#nullable restore
#line 11 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
         using (@Html.BeginForm(null,null,FormMethod.Post,new {enctype="multipart/form-data"}))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 14 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
           Write(Html.LabelFor(m=> m.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
           Write(Html.TextBoxFor(m => m.Nombre,
            new {@class="form-control"}
                ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 20 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
           Write(Html.LabelFor(m=>m.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
           Write(Html.TextBoxFor(m=>m.Marca,
            new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 25 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
           Write(Html.LabelFor(m=>m.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
           Write(Html.TextBoxFor(m=>m.Stock,
            new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 30 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
           Write(Html.LabelFor(m=>m.Costo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 31 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
           Write(Html.TextBoxFor(m=>m.Costo,
            new {@class="form-control"} ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 35 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
           Write(Html.LabelFor(m=>m.Detalle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 36 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
           Write(Html.TextBoxFor(m=>m.Detalle,
            new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 40 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
           Write(Html.LabelFor(m=>m.Ingreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 41 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
           Write(Html.EditorFor(m => m.Ingreso, new { htmlAttributes = new { @class = "form-control", min = "2020-11-01", max = "2050-01-01" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 45 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
           Write(Html.LabelFor(p=>p.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"custom-file\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
               Write(Html.TextBoxFor(p=>p.Foto, new {type="file",@class="form-control custom-file-input"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 48 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
               Write(Html.LabelFor(p=>p.Foto,"Seleccionar Foto",new { @class="custom-file-label"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group form-check\">\r\n                Formato:\r\n                Verduleria: ");
#nullable restore
#line 53 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
                       Write(Html.RadioButtonFor(m => m.TipoProductoId,1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Almacen: ");
#nullable restore
#line 54 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
                    Write(Html.RadioButtonFor(m => m.TipoProductoId,2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Heladera: ");
#nullable restore
#line 55 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
                     Write(Html.RadioButtonFor(m => m.TipoProductoId,3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Congelados: ");
#nullable restore
#line 56 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
                       Write(Html.RadioButtonFor(m => m.TipoProductoId,4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Cosmética: ");
#nullable restore
#line 57 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
                      Write(Html.RadioButtonFor(m => m.TipoProductoId,5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Limpieza: ");
#nullable restore
#line 58 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
                     Write(Html.RadioButtonFor(m => m.TipoProductoId,6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n");
#nullable restore
#line 61 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
                 if (!ViewData.ModelState.IsValid)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
               Write(Html.ValidationSummary(false,"Solucionar los siguientes errores:",
            new { @class="text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
                                         
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            <input type=\"submit\" value=\"Guardar nuevo\" />\r\n");
#nullable restore
#line 68 "C:\Users\camar\Documents\ISTEA\2020\2do Semestre\05 Herramientas de Programacion\HPPFinal\Views\Productos\Agregar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
        <script>
        $(document).ready(function(){
            $('.custom-file-input').on(""change"",function(){
                var nombreArchivo=$(this).val().split(""\\"").pop();
                $(this).next('.custom-file-label').html(nombreArchivo);
            });
        });
        </script>
");
            }
            );
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Productos> Html { get; private set; }
    }
}
#pragma warning restore 1591