#pragma checksum "C:\Users\kevin\Desktop\M-CHAT\M-CHAT\M-CHAT\Pages\Cuestionario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "401f84249efdba66a382c1eb6ba78462ed5b5302"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(M_CHAT.Pages.Pages_Cuestionario), @"mvc.1.0.razor-page", @"/Pages/Cuestionario.cshtml")]
namespace M_CHAT.Pages
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
#line 1 "C:\Users\kevin\Desktop\M-CHAT\M-CHAT\M-CHAT\Pages\_ViewImports.cshtml"
using M_CHAT;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"401f84249efdba66a382c1eb6ba78462ed5b5302", @"/Pages/Cuestionario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9af509f0af684ce5947c367170e2c04cc0c167dc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cuestionario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Resultados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Cuestionario</h1>
<P>el siguiente Cuestionario es para ver signos tempranos de autismo en nuestros niños y prevenir el autismo, para poder
    responder el cuestionario necesita poner unicamente SI/si cualquier forma es valida, o poner un NO/no, responda 
    segun los comportamientos de su niño, ya que este Cuestionario le ayudara a saber si su hijo cuenta o no con princios
    de autismo. una vez dicho lo anterior COMENCEMOS
</p>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "401f84249efdba66a382c1eb6ba78462ed5b53024911", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"ControlInput3\">¿Disfruta su hijo cuando se le balancea o se le hace saltar sobre sus rodillas? </label>\r\n        <input type=\"text\" class=\"form-control\" id=\"ControlInput3\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 732, "\"", 746, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"ControlInput3\">¿Muestra interés por otros niños o niñas? </label>\r\n        <input type=\"text\" class=\"form-control\" id=\"ControlInput3\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 945, "\"", 959, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"ControlInput3\">¿Le gusta subirse a las cosas, como sillones, escalones, juegos del parque? </label>\r\n        <input type=\"text\" class=\"form-control\" id=\"ControlInput3\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1192, "\"", 1206, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Le gusta que el adulto juegue con él o ella al “cucú-tras” (taparse los ojos y luego descubrirlos; jugar a esconderse y aparecer de repente)?</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1505, "\"", 1519, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    </div>

    <div class=""form-group"">
        <label for=""ControlInput3"">¿Alguna vez hace juegos imaginativos, por ejemplo haciendo como si hablara por teléfono, como si estuviera dando de comer a una muñeca, como si estuviera conduciendo un coche o cosas así</label>
        <input text=""text"" type=""text"" class=""form-control"" id=""ControlInput3"" form-control"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Suele señalar con el dedo para pedir algo?</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Suele señalar con el dedo para indicar que algo le llama la atención?</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Puede jugar adecuadamente con piezas o juguetes pequeños (por ejemplo cochecitos, muñequitos o bloques de construcción) sin únicamente chuparlos, ag");
                WriteLiteral(@"itarlos o tirarlos?</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Suele traerle objetos para enseñárselos</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Suele mirarle a los ojos durante unos segundos?</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Le parece demasiado sensible a ruidos poco intensos? (por ejemplo, reacciona tapándose los oídos, etc.)</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Sonríe al verle a usted o cuando usted le sonríe</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=");
                WriteLiteral(@"""ControlInput3"">¿Puede imitar o repetir gestos o acciones que usted hace? (por ejemplo, si usted hace una mueca él o ella también la hace</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Responde cuando se le llama por su nombre</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">Si usted señala con el dedo un juguete al otro lado de la habitación… ¿Dirige su hijo o hija la mirada hacia ese juguete</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Ha aprendido ya a andar</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">Si usted está mirando algo atentamente, ¿su hijo o hija se pone también a mir");
                WriteLiteral(@"arlo</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Hace su hijo o hija movimientos raros con los dedos, por ejemplo, acercándoselos a los ojos</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Intenta que usted preste atención a las actividades que él o ella está haciendo</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Alguna vez ha pensado que su hijo o hija podría tener sordera</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">¿Entiende su hijo o hija lo que la gente dice</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group");
                WriteLiteral(@""">
        <label for=""ControlInput3"">¿Se queda a veces mirando al vacío o va de un lado al otro sin propósito</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <div class=""form-group"">
        <label for=""ControlInput3"">Si su hijo o hija tiene que enfrentarse a una situación desconocida, ¿le mira primero a usted a la cara para saber cómo reaccionar</label>
        <input type=""text"" class=""form-control"" id=""ControlInput3"">
    </div>
    <br>
    <br>
    <div class=""d-flex justify-content-end"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "401f84249efdba66a382c1eb6ba78462ed5b530211837", async() => {
                    WriteLiteral("Cancelar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "401f84249efdba66a382c1eb6ba78462ed5b530213152", async() => {
                    WriteLiteral("Resultados");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<M_CHAT.Pages.CuestionarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<M_CHAT.Pages.CuestionarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<M_CHAT.Pages.CuestionarioModel>)PageContext?.ViewData;
        public M_CHAT.Pages.CuestionarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
