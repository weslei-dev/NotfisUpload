#pragma checksum "C:\Users\wesle\OneDrive\Documentos\Online APP\Notfis_Upload\NotfisUpload\NotfisUpload\Views\Home\Monitoramento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da50da8a81d10c918f3c299c964b867ce1195843"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Monitoramento), @"mvc.1.0.view", @"/Views/Home/Monitoramento.cshtml")]
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
#line 1 "C:\Users\wesle\OneDrive\Documentos\Online APP\Notfis_Upload\NotfisUpload\NotfisUpload\Views\_ViewImports.cshtml"
using NotfisUpload;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wesle\OneDrive\Documentos\Online APP\Notfis_Upload\NotfisUpload\NotfisUpload\Views\_ViewImports.cshtml"
using NotfisUpload.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da50da8a81d10c918f3c299c964b867ce1195843", @"/Views/Home/Monitoramento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5085d703f9a713a40a549a679c25df8335a32ea5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Monitoramento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NotfisUpload.Entidade.NotaFiscal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<br />\r\n<div class=\"panel panel-default\">\r\n    <div class=\"panel-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da50da8a81d10c918f3c299c964b867ce11958434122", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-sm-5 col-xs-12"">
                    <input type=""text"" class=""form-control input-sm"" placeholder=""Pesquise por chaveNFE"" id=""ChaveNFE"" name=""ChaveNfe"">
                </div>
                <div class=""col-sm-3 col-xs-12"">
                    <label class=""sr-only"">Nro. NF</label>
                    <input type=""text"" class=""form-control input-sm"" placeholder=""Pesquise por Pedido"" id=""Pedido"" name=""Pedido"">
                </div>
                <div class=""col-sm-3 col-xs-12"">
                    <input type=""submit"" class=""btn btn-info btn-sm btn-block"" value=""Filtrar"">
                </div>
            </div>
            <br />

            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th style=""width: 30px;"">Id</th>
                        <th style=""width: 30px;"">Pedido</th>
                        <th style=""width: 200px;"">Chave</th>
                    ");
                WriteLiteral("    <th style=\"width: 250px;\">Natureza</th>\r\n                        <th style=\"width: 100px;\">Emissao</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\wesle\OneDrive\Documentos\Online APP\Notfis_Upload\NotfisUpload\NotfisUpload\Views\Home\Monitoramento.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\wesle\OneDrive\Documentos\Online APP\Notfis_Upload\NotfisUpload\NotfisUpload\Views\Home\Monitoramento.cshtml"
                       Write(Html.DisplayFor(modelitem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\wesle\OneDrive\Documentos\Online APP\Notfis_Upload\NotfisUpload\NotfisUpload\Views\Home\Monitoramento.cshtml"
                       Write(Html.DisplayFor(modelitem => item.Pedido));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\wesle\OneDrive\Documentos\Online APP\Notfis_Upload\NotfisUpload\NotfisUpload\Views\Home\Monitoramento.cshtml"
                       Write(Html.DisplayFor(modelitem => item.ChaveNFE));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\wesle\OneDrive\Documentos\Online APP\Notfis_Upload\NotfisUpload\NotfisUpload\Views\Home\Monitoramento.cshtml"
                       Write(Html.DisplayFor(modelitem => item.Natureza));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\wesle\OneDrive\Documentos\Online APP\Notfis_Upload\NotfisUpload\NotfisUpload\Views\Home\Monitoramento.cshtml"
                       Write(Html.DisplayFor(modelitem => item.DataDaEmissao));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 42 "C:\Users\wesle\OneDrive\Documentos\Online APP\Notfis_Upload\NotfisUpload\NotfisUpload\Views\Home\Monitoramento.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<!-- Grid -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NotfisUpload.Entidade.NotaFiscal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
