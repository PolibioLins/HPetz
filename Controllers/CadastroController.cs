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
    public class CadastroController : Controller
    {
        // Login
        public IActionResult Login()
        {
            return View();
        }
        // Login
        [HttpPost]
        public IActionResult Login(Cadastro cadastroForm)
        {
            try
            {
                CadastroRepository cr = new CadastroRepository();
                Cadastro cadastroSessao = cr.validarLogin(cadastroForm);

                if (cadastroSessao != null)
                {
                    // loclizou
                    ViewBag.Mensagem = "Você está logado!";
                    HttpContext.Session.SetInt32("IdCadastro", cadastroSessao.IdCadastro);
                    HttpContext.Session.SetString("NomeCompleto", cadastroSessao.NomeCompleto);
                    return RedirectToAction("ListagemAgendamento", "Agendamento");

                }

                else
                {
                    ViewBag.Mensagem = "Usuário/Senha errada";
                    return View();
                }
            }
            catch
            {
                ViewBag.Mensagem = "Falha na conexão com o banco de dados. Tente mais tarde!";
                return View();
            }


        }
        // Action de Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Cadastro");
        }


        public IActionResult Cadastro()
        {
            Cadastro cadastro = new Cadastro();

            return View();
        }
        // Gravar os cadastros
        [HttpPost]
        public IActionResult Cadastro(Cadastro cadastroForm)
        {
            try
            {
                cadastroForm.Senha = Criptografo.TextoCriptografado(cadastroForm.Senha);

                CadastroRepository cr = new CadastroRepository();
                cr.inserir(cadastroForm);
                ViewBag.Mensagem = "Cadastro realizado com sucesso";

                return View();
            }
            catch
            {

                ViewBag.Mensagem = "Falha na conexão com o banco de dados. Tente mais tarde!";

                return View();

            }

        }

/*
        // Editar
        public IActionResult Editar(int IdCadastro)
        {
            try
            {
                CadastroRepository cr = new CadastroRepository();
                Cadastro cadastro = cr.buscarPorId(IdCadastro);

                return View(cadastro);
            }
            catch
            {
                ViewBag.Mensagem = "Falha na conexão com o banco de dados. Tente mais tarde!";
                return RedirectToAction("Login", "Cadastro");
            }

        }

        // Editar - Gravar no banco de dados
        [HttpPost]
        public IActionResult Editar(Cadastro cadastroForm)
        {
            CadastroRepository cr = new CadastroRepository();
            cr.atualzar(cadastroForm);
            ViewBag.Mensagem = "Cadastro editado com sucesso";
            return RedirectToAction("Agendamento", "Agendamento");
        }
*/

    }
}
