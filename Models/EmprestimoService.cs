using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Biblioteca.Models
{
    public class EmprestimoService 
    {
        public void Inserir(Emprestimo e)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Emprestimos.Add(e);
                bc.SaveChanges();
            }
        }

        public void Atualizar(Emprestimo e)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Emprestimo emprestimo = bc.Emprestimos.Find(e.Id);
                emprestimo.NomeUsuario = e.NomeUsuario;
                emprestimo.Telefone = e.Telefone;
                emprestimo.LivroId = e.LivroId;
                emprestimo.DataEmprestimo = e.DataEmprestimo;
                emprestimo.DataDevolucao = e.DataDevolucao;
                emprestimo.Devolvido = e.Devolvido;  //2021 10 09 agora o checkbox registra

                bc.SaveChanges();
            }
        }

/*
        public ICollection<Emprestimo> ListarTodos(FiltrosEmprestimos filtro)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Emprestimos.Include(e => e.Livro).ToList();
            }
        }

*/



        public ICollection<Emprestimo> ListarTodos( FiltrosEmprestimos filtro =null)   //aqui  //mexi de novo 2021 10 10  /*, int pag = 1, int tamanho = 5*/
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                IQueryable<Emprestimo> query; //aqui
                //int pular = (pag -1) * tamanho;  //mexi aqui 2021 10 10  
                
                if(filtro != null)
                {
                    //definindo dinamicamente a filtragem
                    switch(filtro.TipoFiltro)
                    {
                        case "Usuario": //aqui 1h37:50 Lucas 1h42
                            query = bc.Emprestimos.Include(e => e.Livro).Where(e => e.NomeUsuario.Contains(filtro.Filtro)); //aqui
                        break;

                        case "Livro": //aqui
                            query = bc.Emprestimos.Include(e => e.Livro).Where(e => e.Livro.Titulo.Contains(filtro.Filtro));  //aqui
                        break;

                        default:
                            query = bc.Emprestimos.Include(e => e.Livro); //aqui
                        break;
                    }
                }
                else
                {
                    // caso filtro não tenha sido informado
                    query = bc.Emprestimos.Include(e => e.Livro); //aqui
                }
                
                //ordenação padrão
                //return query.Skip(pular).Take(tamanho).OrderByDescending(e => e.DataDevolucao).ToList(); //aqui
                return query.OrderByDescending(e => e.DataDevolucao).ToList(); //aqui
            }
        }





/*

        public ICollection<Emprestimo> ListarTodos(FiltrosEmprestimos filtro =null)   //aqui
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                IQueryable<Emprestimo> query; //aqui
                
                if(filtro != null)
                {
                    //definindo dinamicamente a filtragem
                    switch(filtro.TipoFiltro)
                    {
                        case "Usuario": //aqui
                            query = bc.Emprestimos.Include(e => e.Livro).Where(e => e.NomeUsuario.Contains(filtro.Filtro)); //aqui
                        break;

                        case "Livro": //aqui
                            query = bc.Emprestimos.Include(e => e.Livro).Where(e => e.Livro.Titulo.Contains(filtro.Filtro));  //aqui
                        break;

                        default:
                            query = bc.Emprestimos.Include(e => e.Livro); //aqui
                        break;
                    }
                }
                else
                {
                    // caso filtro não tenha sido informado
                    query = bc.Emprestimos.Include(e => e.Livro); //aqui
                }
                
                //ordenação padrão
                return query.OrderByDescending(e => e.DataDevolucao).ToList(); //aqui
            }
        }
        */







        public Emprestimo ObterPorId(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Emprestimos.Find(id);
            }
        }
    }
}