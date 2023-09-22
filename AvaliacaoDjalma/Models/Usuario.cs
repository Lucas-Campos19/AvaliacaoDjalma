using System.ComponentModel.DataAnnotations;

namespace AvaliacaoDjalma.Models
{
        public class Usuario
        {
            public int UsuarioId { get; set; }

            
            public string UserName { get; set; }
           
            public string UserPass { get; set; }
           
            public string Nome { get; set; }
            
            public string Celular { get; set; }

            public List<Cliente> Clientes { get; set; }
        }
    
}

