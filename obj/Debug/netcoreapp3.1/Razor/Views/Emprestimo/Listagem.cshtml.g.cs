#pragma checksum "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3dcc65dd1b945fc0b2c02d55c5c4f58c63416b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Listagem), @"mvc.1.0.view", @"/Views/Emprestimo/Listagem.cshtml")]
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
#line 1 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3dcc65dd1b945fc0b2c02d55c5c4f58c63416b1", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "15", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "30", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--model List<Emprestimo> //  model ICollection<Emprestimo>  -->\r\n");
#nullable restore
#line 3 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Empréstimos";
    string Classe = "";
    //alterado para melhorias de itens por pagina 2021 10 10

    int FiltroPorPag = Int32.Parse(ViewData["EmprestimosPorPagina"].ToString());
    int PaginaAtual = Int32.Parse(ViewData["PaginaAtual"].ToString());
    int NumEmprestimoPorPag = (Model.Count < FiltroPorPag ? Model.Count : FiltroPorPag);
    int NumTotalDePag = (Model.Count / NumEmprestimoPorPag) + (Model.Count % NumEmprestimoPorPag == 0 ? 0 : 1);

    //fim melhoria aqui



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3dcc65dd1b945fc0b2c02d55c5c4f58c63416b16655", async() => {
                WriteLiteral("\r\n            <div class=\"form-group mb-2\">\r\n                <select name=\"TipoFiltro\" class=\"form-control\">\r\n\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3dcc65dd1b945fc0b2c02d55c5c4f58c63416b17055", async() => {
                    WriteLiteral("Usuário");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3dcc65dd1b945fc0b2c02d55c5c4f58c63416b18299", async() => {
                    WriteLiteral("Livro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>
            <div class=""form-group mb-2 mx-sm-3"">
                <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
            </div>




            <!--continuação melhoria 2021 10 10 -->

            <div>
                <select name=""itensPorPagina"" id=""itensPorPagina"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3dcc65dd1b945fc0b2c02d55c5c4f58c63416b19917", async() => {
                    WriteLiteral("10");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3dcc65dd1b945fc0b2c02d55c5c4f58c63416b111156", async() => {
                    WriteLiteral("15");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3dcc65dd1b945fc0b2c02d55c5c4f58c63416b112396", async() => {
                    WriteLiteral("30");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3dcc65dd1b945fc0b2c02d55c5c4f58c63416b113636", async() => {
                    WriteLiteral("50");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3dcc65dd1b945fc0b2c02d55c5c4f58c63416b114876", async() => {
                    WriteLiteral("Exibir Tudo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
                       WriteLiteral(Model.Count);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>

            <!-- fim melhoria -->


            <button type=""submit"" class=""btn btn-primary mb-2"">Pesquisar</button>

            <!-- melhoria 2021 10 10 -->

            <div id=""SeletorPaginas"">
                <span>Página:</span>
");
#nullable restore
#line 56 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
                 for (int i = 1; i <= NumTotalDePag; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <span><a");
                BeginWriteAttribute("href", " href=\"", 2000, "\"", 2042, 2);
                WriteAttributeValue("", 2007, "/Emprestimo/Listagem?PaginaAtual=", 2007, 33, true);
#nullable restore
#line 58 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 2040, i, 2040, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 58 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
                                                                   Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(", </a></span>\r\n");
#nullable restore
#line 59 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
                    /////////////////
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <!--melhoria-->\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 72 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
         if (Model.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!-- adicionado if 2021 10 09-->
            <table class=""table table-striped"">
                <!-- mexi aqui 2021 09 21 -->
                <!-- <table > -->
            <thead>
                    <tr>
                        <th>Id</th>
                        <th>Registro do aluno</th>
                        <th>Nome do aluno</th>
                        <th>Data da avaliação</th>
                        <th>Nota</th>
                        <th></th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <!--(a)foreach(Emprestimo e in Model)
                        {-->
                    <!--
                            if((System.DateTime.Compare(System.DateTime.Now, e.DataDevolucao)>0) )
                                {
                                    Classe = ""text-danger""; //fica vermelho se passou a data e não devolveu
                                    if(e.Devolvido == true){
   ");
            WriteLiteral(@"                                     Classe =""text-primary""; //texto azul se devolvido for checado e se a data passou para continuar azul
                                    }
                                }else{   }
                            -->




");
#nullable restore
#line 105 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
                     for (int i = (PaginaAtual - 1) * NumEmprestimoPorPag; i < (NumEmprestimoPorPag * PaginaAtual < Model.Count ?
                   NumEmprestimoPorPag * PaginaAtual : Model.Count); i++)
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!--foreach (Emprestimo e in Model)\r\n                                    {-->\r\n");
#nullable restore
#line 112 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
                        if ((System.DateTime.Compare(System.DateTime.Now, Model[i].DataDevolucao) > 0))
                        {
                            Classe = "text-danger"; //fica vermelho se passou a data e não devolveu
                            if ( Model[i].Devolvido == true)
                            {
                                Classe = "text-primary"; //texto azul se devolvido for checado e se a data passou para continuar azul
                            }
                        }
                        else { Classe = ""; }




#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("class", " class=\"", 4525, "\"", 4540, 1);
#nullable restore
#line 124 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 4533, Classe, 4533, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#nullable restore
#line 125 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 126 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 127 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 128 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 129 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 130 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
                           Write(Model[i].Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 4977, "\"", 5015, 2);
            WriteAttributeValue("", 4984, "/Emprestimo/Edicao/", 4984, 19, true);
#nullable restore
#line 131 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 5003, Model[i].Id, 5003, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 133 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                    <!--
                        <tr class=""(a)Classe""> 
                            <td>(a)e.Id</td>
                            <td>(a)e.NomeUsuario</td>
                            <td>(a)e.DataEmprestimo.ToString(""dd/MM/yyyy"")</td>
                            <td>(a)e.DataDevolucao.ToString(""dd/MM/yyyy"")</td>
                            <td>(a)e.Livro.Titulo</td>
                            <td>(a)e.Livro.Autor</td>
                            <td><a href=""/Emprestimo/Edicao/(a)e.Id"">Editar</a></td>
                        </tr>-->


                    <!--}  esse é do foreach-->
            </tbody>
            </table>
            <!--
            <a href=""?=1"">Página Anterior</a>

            <a href=""?=2"">Próxima Página</a>
            -->
");
#nullable restore
#line 158 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Nenhum registro encontrado.</p>\r\n");
#nullable restore
#line 162 "C:\Users\maril\Desktop\PI_univesp\Sistema_de_notas\Views\Emprestimo\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591