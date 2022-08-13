using ERP.Models;
using System.Collections.Generic;

namespace ERP.Repositorio
{
    public interface IEstoqueRepositorio
    {
        ProdutoModel ListarPorId(int id);
        ProdutoModel Adicionar(ProdutoModel produto);
        List<ProdutoModel> BuscarTodos();
        ProdutoModel Atualizar(ProdutoModel produto);
        bool Apagar(int id);
    }
}
