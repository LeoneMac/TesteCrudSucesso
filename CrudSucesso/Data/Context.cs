using CrudSucesso.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudSucesso.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Atividade> Atividades { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }

    }
}
