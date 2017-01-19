namespace MessagingQueues.Entities
{
    public class Debito
    {
        public string Numero { get; set; }

        public double ValorPago { get; set; }

        public Bin Bin { get; set; }
    }
}
