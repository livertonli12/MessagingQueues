using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingQueues.Entities
{
    public class Evento
    {
        public string Codigo { get; set; }

        public string Nome { get; set; }

        public DateTime Data { get; set; }

        public Endereco Endereco { get; set; }

        public long IdCategoria { get; set; }

        public long IdMidia { get; set; }

        public long IdPublicoAlvo { get; set; }
    }
}
