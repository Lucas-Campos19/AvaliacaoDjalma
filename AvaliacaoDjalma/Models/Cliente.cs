using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaliacaoDjalma.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public string Celular { get; set; }

        [Required]
        public string DataNasc { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
