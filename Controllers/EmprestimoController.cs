using Biblioteca.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace Biblioteca.Controllers
{
    
    public class EmprestimoController : Controller
    {
        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin(this); //2021 10 08

            LivroService livroService = new LivroService();
            EmprestimoService emprestimoService = new EmprestimoService();

            CadEmprestimoViewModel cadModel = new CadEmprestimoViewModel();
            cadModel.Livros = livroService.ListarDisponiveis();
            return View(cadModel);
        }

        [HttpPost]
        public IActionResult Cadastro(CadEmprestimoViewModel viewModel) //1:33:00 no vídeo passa rápido
        {
            EmprestimoService emprestimoService = new EmprestimoService();
            
            if(viewModel.Emprestimo.Id == 0)
            {
                emprestimoService.Inserir(viewModel.Emprestimo);
            }
            else
            {
                emprestimoService.Atualizar(viewModel.Emprestimo);
            }
            return RedirectToAction("Listagem");
        }
            /*
        public IActionResult Listagem(string tipoFiltro, string filtro)
        {
            Autenticacao.CheckLogin(this); //2021 10 08

            FiltrosEmprestimos objFiltro = null;
            if(!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosEmprestimos();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
            EmprestimoService emprestimoService = new EmprestimoService();
            return View(emprestimoService.ListarTodos(objFiltro));
        }  */


        public IActionResult Listagem(string tipoFiltro, string filtro, string itensPorPagina, int NumDaPagina, int PaginaAtual)/////
        {
            Autenticacao.CheckLogin(this);

            FiltrosEmprestimos objFiltro = null;
            if(!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosEmprestimos();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
                ViewData["emprestimosPorPagina"] = (string.IsNullOrEmpty(itensPorPagina) ? 10 : Int32.Parse(itensPorPagina));///////
                ViewData["PaginaAtual"] = (PaginaAtual !=0 ? PaginaAtual : 1);

            EmprestimoService emprestimoService = new EmprestimoService();
            return View(emprestimoService.ListarTodos(objFiltro));
        }














        public IActionResult Edicao(int id)
        {
            Autenticacao.CheckLogin(this); //2021 10 08
            
            LivroService livroService = new LivroService();
            EmprestimoService em = new EmprestimoService();
            Emprestimo e = em.ObterPorId(id);

            CadEmprestimoViewModel cadModel = new CadEmprestimoViewModel();
            cadModel.Livros = livroService.ListarTodos();
            cadModel.Emprestimo = e;
            
            return View(cadModel);
        }
    }
}