#pragma checksum "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b1a5dded8b9f44e747ddafa89f24b90aaf92361"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Details), @"mvc.1.0.view", @"/Views/Produtos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produtos/Details.cshtml", typeof(AspNetCore.Views_Produtos_Details))]
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
#line 1 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\_ViewImports.cshtml"
using WebAvaliacoes;

#line default
#line hidden
#line 2 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\_ViewImports.cshtml"
using WebAvaliacoes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b1a5dded8b9f44e747ddafa89f24b90aaf92361", @"/Views/Produtos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115fa7ff0c266baa126039a17faf4d2dd6de420c", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAvaliacoes.ViewModels.ProdutoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(95, 139, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>ProdutoViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(235, 47, false);
#line 14 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(282, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(346, 43, false);
#line 17 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(389, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(452, 52, false);
#line 20 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DescricaoProduto));

#line default
#line hidden
            EndContext();
            BeginContext(504, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(568, 48, false);
#line 23 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DescricaoProduto));

#line default
#line hidden
            EndContext();
            BeginContext(616, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(679, 48, false);
#line 26 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorProduto));

#line default
#line hidden
            EndContext();
            BeginContext(727, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(791, 44, false);
#line 29 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayFor(model => model.ValorProduto));

#line default
#line hidden
            EndContext();
            BeginContext(835, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(898, 41, false);
#line 32 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(939, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1003, 37, false);
#line 35 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1103, 50, false);
#line 38 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataFabricacao));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1217, 46, false);
#line 41 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataFabricacao));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1326, 48, false);
#line 44 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataValidade));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1438, 44, false);
#line 47 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataValidade));

#line default
#line hidden
            EndContext();
            BeginContext(1482, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1545, 47, false);
#line 50 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FotoProduto));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1656, 43, false);
#line 53 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayFor(model => model.FotoProduto));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1762, 51, false);
#line 56 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProdutoPromocao));

#line default
#line hidden
            EndContext();
            BeginContext(1813, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1877, 47, false);
#line 59 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProdutoPromocao));

#line default
#line hidden
            EndContext();
            BeginContext(1924, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1971, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b1a5dded8b9f44e747ddafa89f24b90aaf9236111087", async() => {
                BeginContext(2017, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\src\ProClienteAvaliacoesNovo\src\WebAvaliacoes\Views\Produtos\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2025, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2033, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b1a5dded8b9f44e747ddafa89f24b90aaf9236113409", async() => {
                BeginContext(2055, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2071, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAvaliacoes.ViewModels.ProdutoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
