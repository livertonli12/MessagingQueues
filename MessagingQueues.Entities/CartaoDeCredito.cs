namespace MessagingQueues.Entities
{
    public class CartaoDeCredito
    {
        public string Numero { get; set; }

        public string Vencimento { get; set; }

        public string CodigoServico { get; set; }

        public int Parcela { get; set; }

        public double ValorPago { get; set; }

        public Bin Bin { get; set; }

        public Proprietario Proprietario { get; set; }
    }
}
