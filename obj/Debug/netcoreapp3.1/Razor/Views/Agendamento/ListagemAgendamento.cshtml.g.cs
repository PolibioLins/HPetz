#pragma checksum "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\Agendamento\ListagemAgendamento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64d3d8474049a0ea2e2082175a3620984680c0c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agendamento_ListagemAgendamento), @"mvc.1.0.view", @"/Views/Agendamento/ListagemAgendamento.cshtml")]
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
#line 1 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\_ViewImports.cshtml"
using atv4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\_ViewImports.cshtml"
using atv4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64d3d8474049a0ea2e2082175a3620984680c0c6", @"/Views/Agendamento/ListagemAgendamento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e321fe840d44d9400e68bf6c288bbf6f7b034a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Agendamento_ListagemAgendamento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Agendamento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\Agendamento\ListagemAgendamento.cshtml"
  
        ViewData["Title"] = "List of Appointments";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Em mudança para cards ou um sistema de listagem -->\r\n\r\n<div class=\"text-center\">\r\n        <h1>");
#nullable restore
#line 10 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\Agendamento\ListagemAgendamento.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

        <div class=""table-responsive"">
                <table class=""table"">
                        <thead>
                                <tr>
                                        <th scope=""col"" class=""textoTabela"" align-items=""center"" style=""padding: 8px;"">
                                                Tutor's Name</th>
                                        <th scope=""col"" class=""textoTabela"" align-items=""center"" style=""padding: 8px;"">
                                                Pet's Name
                                        </th>
                                        <th scope=""col"" class=""textoTabela"" align-items=""center"" style=""padding: 8px;"">
                                                Breed</th>
                                        <th scope=""col"" class=""textoTabela"" align-items=""center"" style=""padding: 8px;"">
                                                Pet's Size
                                        </th>
                                        ");
            WriteLiteral(@"<th scope=""col"" class=""textoTabela"" align-items=""center"" style=""padding: 8px;"">
                                                Service</th>
                                        <th scope=""col"" class=""textoTabela"" align-items=""center"" style=""padding: 8px;"">
                                                Appointment time</th>

                                </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 34 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\Agendamento\ListagemAgendamento.cshtml"
                                 foreach (Agendamento a in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                                <td scope=\"row\" class=\"textoTabela\" align-items=\"center\" style=\"padding: 8px;\">\r\n                                                        ");
#nullable restore
#line 38 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\Agendamento\ListagemAgendamento.cshtml"
                                                   Write(a.NomeTutor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td scope=\"row\" class=\"textoTabela\" align-items=\"center\" style=\"padding: 8px;\">\r\n                                                        ");
#nullable restore
#line 40 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\Agendamento\ListagemAgendamento.cshtml"
                                                   Write(a.NomePet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td scope=\"row\" class=\"textoTabela\" align-items=\"center\" style=\"padding: 8px;\">\r\n                                                        ");
#nullable restore
#line 42 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\Agendamento\ListagemAgendamento.cshtml"
                                                   Write(a.Raca);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td scope=\"row\" class=\"textoTabela\" align-items=\"center\" style=\"padding: 8px;\">\r\n                                                        ");
#nullable restore
#line 45 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\Agendamento\ListagemAgendamento.cshtml"
                                                   Write(a.Tamanho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td scope=\"row\" class=\"textoTabela\" align-items=\"center\" style=\"padding: 8px;\">\r\n                                                        ");
#nullable restore
#line 47 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\Agendamento\ListagemAgendamento.cshtml"
                                                   Write(a.Servico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td scope=\"row\" class=\"textoTabela\" align-items=\"center\" style=\"padding: 8px;\">\r\n                                                        ");
#nullable restore
#line 49 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\Agendamento\ListagemAgendamento.cshtml"
                                                   Write(a.DataHoraAgendamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"border-0 textoTabela\"><a class=\"textoTabela\"");
            BeginWriteAttribute("href", "\r\n                                                        href=\"", 3198, "\"", 3313, 2);
            WriteAttributeValue("", 3262, "/Agendamento/Remover?IdAgendamento=", 3262, 35, true);
#nullable restore
#line 51 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\Agendamento\ListagemAgendamento.cshtml"
WriteAttributeValue("", 3297, a.IdAgendamento, 3297, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                                        onclick=\"return confirm(\'Deseja mesmo excluir?\')\">Remover</a> |\r\n                                                        <a class=\"textoTabela\"");
            BeginWriteAttribute("href", "\r\n                                                        href=\"", 3515, "\"", 3629, 2);
            WriteAttributeValue("", 3579, "/Agendamento/Editar?IdAgendamento=", 3579, 34, true);
#nullable restore
#line 54 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\Agendamento\ListagemAgendamento.cshtml"
WriteAttributeValue("", 3613, a.IdAgendamento, 3613, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>\r\n                                                </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Usuario\Desktop\Senac\Modulo2\Atividade Integradora 2\etapa_5\atv4\Views\Agendamento\ListagemAgendamento.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n\r\n\r\n                </table>\r\n        </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Agendamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
