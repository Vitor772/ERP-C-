using ERP.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
