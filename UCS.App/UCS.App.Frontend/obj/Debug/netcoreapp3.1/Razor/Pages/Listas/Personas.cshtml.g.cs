#pragma checksum "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7182f058bf1f2b7b34ee7eb78c738f9bb41854c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UCS.App.Frontend.Pages.Listas.Pages_Listas_Personas), @"mvc.1.0.razor-page", @"/Pages/Listas/Personas.cshtml")]
namespace UCS.App.Frontend.Pages.Listas
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
#line 1 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\_ViewImports.cshtml"
using UCS.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7182f058bf1f2b7b34ee7eb78c738f9bb41854c1", @"/Pages/Listas/Personas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80c648aa65a011f36a118bf2bcc9d747325a648a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_Personas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Detalles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Lista de Directivos</h1>\r\n<table class=\"table\">\r\n    \r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Nombre</th>\r\n        <th>Apellido</th>\r\n        <th>Unidad Que desempeña </th>\r\n        <th>detalles </th>\r\n        \r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
 foreach (var Directivo in Model.Directivos)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(Directivo.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(Directivo.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(Directivo.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(Directivo.unidadDesempeña);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            \r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7182f058bf1f2b7b34ee7eb78c738f9bb41854c15152", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-info-circle\"></i> Detalle Directivo\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-directivoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
                                                                                      WriteLiteral(Directivo.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["directivoId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-directivoId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["directivoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n    </tr>\r\n");
#nullable restore
#line 31 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<h1>Lista de Profesores</h1>\r\n<table class=\"table\">\r\n    \r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Nombre</th>\r\n        <th>Apellido</th>\r\n        <th>Departamento </th>\r\n        <th>detalles </th>\r\n    </tr>\r\n");
#nullable restore
#line 44 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
 foreach (var profesor in Model.Profesores_S)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n            <td>");
#nullable restore
#line 47 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(profesor.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(profesor.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 49 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(profesor.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 50 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(profesor.departamento);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            \r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7182f058bf1f2b7b34ee7eb78c738f9bb41854c19330", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-info-circle\"></i> Detalle Profesor\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-profesorId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
                                                                                     WriteLiteral(profesor.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["profesorId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-profesorId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["profesorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n    </tr>\r\n");
#nullable restore
#line 58 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n<h1>Lista de estudiantes</h1>\r\n<table class=\"table\">\r\n    \r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Nombre</th>\r\n        <th>Apellido</th>\r\n        <th>Carrera</th>\r\n        <th>detalles </th>\r\n    </tr>\r\n");
#nullable restore
#line 72 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
 foreach (var estudiante in Model.Estudiantes)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n            <td>");
#nullable restore
#line 75 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(estudiante.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 76 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(estudiante.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 77 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(estudiante.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 78 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(estudiante.carrera);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7182f058bf1f2b7b34ee7eb78c738f9bb41854c113503", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-info-circle\"></i> Detalle Estudiante\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-estudianteId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
                                                                                       WriteLiteral(estudiante.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudianteId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-estudianteId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudianteId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n    </tr>\r\n");
#nullable restore
#line 86 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<h1>Lista de Personal de Aseo</h1>\r\n<table class=\"table\">\r\n    \r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Nombre</th>\r\n        <th>Apellido</th>\r\n        <th>Turno de servicio </th>\r\n        <th>detalles </th>\r\n        \r\n    </tr>\r\n");
#nullable restore
#line 100 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
 foreach (var PersonalAseo in Model.PersonaldeAseo)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n            <td>");
#nullable restore
#line 103 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(PersonalAseo.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 104 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(PersonalAseo.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 105 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(PersonalAseo.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 106 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
           Write(PersonalAseo.turnoServicio);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            \r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7182f058bf1f2b7b34ee7eb78c738f9bb41854c117744", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-info-circle\"></i> Detalle Personal Aseo\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-personalAseoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
                                                                                         WriteLiteral(PersonalAseo.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["personalAseoId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-personalAseoId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["personalAseoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n    </tr>\r\n");
#nullable restore
#line 115 "C:\neuromante-1984-1\UCS.App\UCS.App.Frontend\Pages\Listas\Personas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UCS.App.Frontend.Pages.PersonasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UCS.App.Frontend.Pages.PersonasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UCS.App.Frontend.Pages.PersonasModel>)PageContext?.ViewData;
        public UCS.App.Frontend.Pages.PersonasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
