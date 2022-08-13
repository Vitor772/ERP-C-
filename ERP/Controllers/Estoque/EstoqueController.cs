using ERP.Models;
using ERP.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ERP.Controllers.Estoque
{
    public class EstoqueController : Controller
    {
        private readonly IEstoqueRepositorio _estoqueRepositorio;
        public EstoqueController(IEstoqueRepositorio estoqueRepositorio)
        {
            _estoqueRepositorio = estoqueRepositorio;
        }
        public IActionResult Index()
        {
            List<ProdutoModel> produtos = _estoqueRepositorio.BuscarTodos();
            
            return View(produtos);
        }
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
           ProdutoModel produto = _estoqueRepositorio.ListarPorId(id);
            return View(produto);
        }

        [HttpPost]
        public IActionResult Criar(ProdutoModel produto)
        {
            _estoqueRepositorio.Adicionar(produto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(ProdutoModel produto)
        {
            _estoqueRepositorio.Atualizar(produto);
            return RedirectToAction("Index");
        }

        public IActionResult Apagar(int id)
        {
            _estoqueRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
    }
}
