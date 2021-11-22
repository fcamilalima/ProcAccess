using Microsoft.EntityFrameworkCore;
using ProcAccess.Models;

namespace ProcAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
        public DbSet<Processo> Processos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }    

}
}
