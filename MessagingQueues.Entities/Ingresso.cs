using System;
using System.Collections.Generic;

namespace MessagingQueues.Entities
{
    public class Ingresso
    {
        public DateTime Data { get; set; }

        public long IdSetor { get; set; }

        public decimal? TaxaServico { get; set; }

        public string GrupoDeVendas { get; set; }

        public long IdTipoDeDesconto { get; set; }

        public long IdMeioDeEntrega { get; set; }

        public List<Evento> Evento { get; set; }
    }
}
