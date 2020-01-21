using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebAvaliacoes.ViewModels;

namespace WebAvaliacoes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebAvaliacoes.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }

    }
}
