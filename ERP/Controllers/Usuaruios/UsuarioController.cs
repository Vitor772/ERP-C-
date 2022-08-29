using ERP.Models;
using ERP.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ERP.Controllers.Usuaruios
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepositorio.BuscarTodos();
            
            return View(usuarios);
        }
    }
}
