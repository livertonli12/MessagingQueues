using System.Collections.Generic;

namespace MessagingQueues.Entities
{
    public class Produto
    {
        public string CodigoProdutoEmpresa { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public string Ncm { get; set; }

        public Categoria Categoria { get; set; }

        public List<Ingresso> Ingresso { get; set; }
    }
}
