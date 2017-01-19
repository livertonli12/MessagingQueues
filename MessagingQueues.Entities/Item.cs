namespace MessagingQueues.Entities
{
    public class Item
    {
        public int Quantidade { get; set; }

        public double ValorTotal { get; set; }

        public Produto Produtos { get; set; }

        public decimal ValorDesconto { get; set; }

        public decimal ValorAcrescimo { get; set; }
    }
}
