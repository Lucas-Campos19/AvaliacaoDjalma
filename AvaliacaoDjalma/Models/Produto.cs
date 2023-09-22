using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace AvaliacaoDjalma.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }

    }
}
