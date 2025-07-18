using Microsoft.EntityFrameworkCore;

namespace Nova_aplicacao_web
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Exemplo de DbSet para uma entidade chamada Produto
        public DbSet<Produto> Produtos { get; set; }
    }

    // Exemplo de entidade
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set;