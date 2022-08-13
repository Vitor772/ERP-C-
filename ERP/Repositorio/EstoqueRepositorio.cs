using ERP.Data;
using ERP.Models;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Repositorio
{
    public class EstoqueRepositorio : IEstoqueRepositorio
    {
        public readonly BancoContext _bancoContext;

        public EstoqueRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<ProdutoModel> BuscarTodos()
        {
            return _bancoContext.Produtos.ToList();
        }

        public ProdutoModel Adicionar(ProdutoModel produto)
        {
            _bancoContext.Produtos.Add(produto);
            _bancoContext.SaveChanges();

            return produto;
        }

        public ProdutoModel ListarPorId(int id)
        {
            return _bancoContext.Produtos.FirstOrDefault(x => x.Id == id);
        }

        public ProdutoModel Atualizar(ProdutoModel produto)
        {
            ProdutoModel produtoDB = ListarPorId(produto.Id);

            if (produtoDB == null) throw new System.Exception("Houve um erro");

            produtoDB.NomeFornecedor = produto.NomeFornecedor;

            _bancoContext.Produtos.Update(produtoDB);
            _bancoContext.SaveChanges();

            return produtoDB;
        }

        public bool Apagar(int id)
        {
            ProdutoModel produtoDB = ListarPorId(id);

            if (produtoDB == null) throw new System.Exception("Houve um erro na deleção do nome");

            _bancoContext.Produtos.Remove(produtoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
