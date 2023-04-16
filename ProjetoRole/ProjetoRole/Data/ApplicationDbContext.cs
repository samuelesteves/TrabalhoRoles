using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoRole.Models;

namespace ProjetoRole.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Vendedor> Vendedores { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<ApplicationUser> users { get; set;}
    }
}
