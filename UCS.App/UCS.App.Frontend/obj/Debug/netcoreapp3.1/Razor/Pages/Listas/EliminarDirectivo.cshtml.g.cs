#pragma checksum "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\EliminarDirectivo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb32fba5fcaed2dbe40a927e293832726b71c239"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UCS.App.Frontend.Pages.Listas.Pages_Listas_EliminarDirectivo), @"mvc.1.0.razor-page", @"/Pages/Listas/EliminarDirectivo.cshtml")]
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
#line 1 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\_ViewImports.cshtml"
using UCS.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb32fba5fcaed2dbe40a927e293832726b71c239", @"/Pages/Listas/EliminarDirectivo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c8c5fd5d3f68e1b134cc931c292312641165c7c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_EliminarDirectivo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Se va a Eliminar el Directivo</h1>\n\n<table class=\"table\">\n\n    <tr><td>Nombre:</td><td>");
#nullable restore
#line 9 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\EliminarDirectivo.cshtml"
                       Write(Model.Directivo.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n    <tr><td>Apellido:</td> <td>");
#nullable restore
#line 10 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\EliminarDirectivo.cshtml"
                          Write(Model.Directivo.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n    <tr><td>Identificación:</td> <td>");
#nullable restore
#line 11 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\EliminarDirectivo.cshtml"
                                Write(Model.Directivo.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n    <tr><td>Edad:</td> <td>");
#nullable restore
#line 12 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\EliminarDirectivo.cshtml"
                      Write(Model.Directivo.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><tr></tr>\n    <tr><td>Estado Covid:</td> <td>");
#nullable restore
#line 13 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\EliminarDirectivo.cshtml"
                              Write(Model.Directivo.EstadoCovid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n    <tr><td>Unidad Desempeña:</td> <td>");
#nullable restore
#line 14 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\EliminarDirectivo.cshtml"
                                  Write(Model.Directivo.unidadDesempeña);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n\n</table>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb32fba5fcaed2dbe40a927e293832726b71c2396210", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fb32fba5fcaed2dbe40a927e293832726b71c2396470", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 18 "D:\Thomas\c3_desarrollo_software\proyectos\neuromante1984GrupalTemporal-master\UCS.App\UCS.App.Frontend\Pages\Listas\EliminarDirectivo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Directivo.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <button type=\"submit\" class=\"btn btn-primary\">Confirmar Eliminar</button>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UCS.App.Frontend.Pages.EliminarDirectivoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UCS.App.Frontend.Pages.EliminarDirectivoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UCS.App.Frontend.Pages.EliminarDirectivoModel>)PageContext?.ViewData;
        public UCS.App.Frontend.Pages.EliminarDirectivoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
