using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using atv4.Models;
using Microsoft.AspNetCore.Http;

namespace atv4.Controllers
{
    public class AgendamentoController : Controller
    {

        // Lista
        public IActionResult ListagemAgendamento()
        {
            try
            {
                if (HttpContext.Session.GetInt32("IdCadastro") == null)
                {
                    return RedirectToAction("Login", "Cadastro");
                }


                // Objetivo: 
                AgendamentoRepository ar = new AgendamentoRepository();
                List<Agendamento> Listagem = ar.listar();
                return View(Listagem);
            }
            catch
            {
                ViewBag.Mensagem = "Falha na conexão com o banco de dados. Tente mais tarde!";
                return RedirectToAction("Login", "Cadastro");
            }



        }
        // Remover
        public IActionResult Remover(int IdAgendamento)
        {
            try
            {
                AgendamentoRepository ar = new AgendamentoRepository();
                Agendamento agendamento = ar.buscarPorId(IdAgendamento);
                ar.remover(agendamento);

                return RedirectToAction("ListagemAgendamento", "Agendamento");
            }
            catch
            {
                ViewBag.Mensagem = "Falha na conexão com o banco de dados. Tente mais tarde!";
                return RedirectToAction("Login", "Cadastro");
            }


        }

        public IActionResult Agendamento()
        {

            if (HttpContext.Session.GetInt32("IdCadastro") == null)
            {
                return RedirectToAction("Login", "Cadastro");
            }
            
            Agendamento agendamento = new Agendamento();

            return View();
        }
        // Gravar os cadastros
        [HttpPost]
        public IActionResult Agendamento(Agendamento agendamentoForm)
        {
            try
            {
                AgendamentoRepository ar = new AgendamentoRepository();
                ar.inserir(agendamentoForm);
                ViewBag.Mensagem = "Agendamento realizado com sucesso";
                return View();
            }
            catch
            {
                ViewBag.Mensagem = "Falha na conexão com o banco de dados. Tente mais tarde!";
                return View();

            }

        }

        // Editar
        public IActionResult Editar(int IdAgendamento)
        {
            try
            {
                AgendamentoRepository ar = new AgendamentoRepository();
                Agendamento agendamento = ar.buscarPorId(IdAgendamento);

                return View(agendamento);
            }

            catch
            {
                ViewBag.Mensagem = "Falha na conexão com o banco de dados. Tente mais tarde!";
                return RedirectToAction("Login", "Cadastro");
            }
        }

        // Editar - Gravar no banco de dados
        [HttpPost]
        public IActionResult Editar(Agendamento agendamentoForm)
        {
            try
            {
                AgendamentoRepository ar = new AgendamentoRepository();
                ar.atualzar(agendamentoForm);
                return RedirectToAction("ListagemAgendamento", "Agendamento");
            }

            catch
            {
                ViewBag.Mensagem = "Falha na conexão com o banco de dados. Tente mais tarde!";
                return View();
            }
        }

    }
}