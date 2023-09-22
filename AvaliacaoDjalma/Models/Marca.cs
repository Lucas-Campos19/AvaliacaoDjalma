namespace AvaliacaoDjalma.Models
{
    public class Marca
    {
        public int MarcaId { get; set; }

        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; }

    }
}
