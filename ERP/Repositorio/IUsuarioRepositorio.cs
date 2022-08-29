using ERP.Models;
using System.Collections.Generic;

namespace ERP.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorID(int id);
        UsuarioModel Adicionar(UsuarioModel produto);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Atualizar(UsuarioModel produto);
        bool Apagar(int id);
    }
}
