using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SucessoCRUD.Models
{
    public class Usuario
    {
        [Key]
        public int CodPar { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Telefone { get; set; }

    }
    public class AuxParticipantePacote
    {
        [Key]
        public int ParId { get; set; }
    }

    public class AuxParticipanteAtiv
    {
        [Key]
        public int AtivId { get; set; }
    }

    public class Pacotes
    {
        [Key]
        public int PackId { get; set; }
        public decimal Preço { get; set; }

        public string Descrição { get; set; }
    }

    public class Atividades
    {
        [Key]
        public int CodAtv { get; set; }

        public string DescAtv { get; set; }

        public int Vagas { get; set; }

        public float PreçoAtv { get; set; }
    }

}
