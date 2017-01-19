using System;

namespace MessagingQueues.Entities
{
    public class CartaoAdicional
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime? DataNascimento { get; set; }

        public string Parentesco { get; set; }
    }
}
