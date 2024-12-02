global using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) //o base é o construtor/base da classe mãe
        {

        }
  
        public DbSet<SuperHero> SuperHeroes { get; set; } //DbSet é a representação da tabela no banco de dados
    }
}
