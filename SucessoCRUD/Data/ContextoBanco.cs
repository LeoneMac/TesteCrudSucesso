using SucessoCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace SucessoCRUD.Data
{
    public class ContextoBanco : DbContext
    {
        public ContextoBanco(DbContextOptions<ContextoBanco> options) : base(options)
        { 
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<AuxParticipantePacote> AuxParticipantePacote { get; set; }
        public DbSet<AuxParticipanteAtiv> AuxParticipanteAtiv { get; set; }
        public DbSet<Pacotes> Pacotes { get; set; }
        public DbSet<Atividades> Atividades { get; set; }

    }
}
