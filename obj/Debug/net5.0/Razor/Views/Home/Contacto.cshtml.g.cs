#pragma checksum "C:\Users\heave\OneDrive\Escritorio\2021 - I\PROGRAMACIÓN I\TEORÍA\pc2\PC2\pc2\Views\Home\Contacto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef14d5969ee1c61c9dc4baf0dd1abe55b9587aa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacto), @"mvc.1.0.view", @"/Views/Home/Contacto.cshtml")]
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
#line 1 "C:\Users\heave\OneDrive\Escritorio\2021 - I\PROGRAMACIÓN I\TEORÍA\pc2\PC2\pc2\Views\_ViewImports.cshtml"
using pc2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\heave\OneDrive\Escritorio\2021 - I\PROGRAMACIÓN I\TEORÍA\pc2\PC2\pc2\Views\_ViewImports.cshtml"
using pc2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef14d5969ee1c61c9dc4baf0dd1abe55b9587aa2", @"/Views/Home/Contacto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d2263d35973fa27b223c8405b50b8ff267c28bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\heave\OneDrive\Escritorio\2021 - I\PROGRAMACIÓN I\TEORÍA\pc2\PC2\pc2\Views\Home\Contacto.cshtml"
  
    ViewData["Title"] = "FORMULARIO DE CONTACTO";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\heave\OneDrive\Escritorio\2021 - I\PROGRAMACIÓN I\TEORÍA\pc2\PC2\pc2\Views\Home\Contacto.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef14d5969ee1c61c9dc4baf0dd1abe55b9587aa24125", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 155, "\"", 161, 0);
                EndWriteAttribute();
                WriteLiteral(">Nombres:</label>\r\n        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 228, "\"", 233, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 293, "\"", 299, 0);
                EndWriteAttribute();
                WriteLiteral(">Apellidos:</label>\r\n        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 368, "\"", 373, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 433, "\"", 439, 0);
                EndWriteAttribute();
                WriteLiteral(">Correo de contacto:</label>\r\n        <input type=\"email\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 518, "\"", 523, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 583, "\"", 589, 0);
                EndWriteAttribute();
                WriteLiteral(">Celular:</label>\r\n        <input type=\"number\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 658, "\"", 663, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
