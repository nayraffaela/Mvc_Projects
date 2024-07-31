using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Games_Mvc.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        }

        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Cena> Cenas { get; set; }
        public DbSet<Personagem> Personagens { get; set; }

    }
}