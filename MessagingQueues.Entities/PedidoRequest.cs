using System;
using System.Collections.Generic;

namespace MessagingQueues.Entities
{
    public class PedidoRequest
    {
        public Guid IdTransacao { get; set; }

        public string NumeroDoPedido { get; set; }

        public DateTime DataDaCompra { get; set; }

        public string Canal { get; set; }

        public string CodigoBvs { get; set; }

        public string NumeroIp { get; set; }

        public string Lote { get; set; }

        public string Token { get; set; }

        public string TipoDeEntrega { get; set; }

        public string Dispositivo { get; set; }

        public string Vendedor { get; set; }

        public string DescricaoStatusTransacao { get; set; }

        public string StatusTransacao { get; set; }

        public string EmailEntrega { get; set; }

        public decimal? Frete { get; set; }

        public decimal? ValorParcela { get; set; }

        public decimal? ValorAcrescimo { get; set; }

        public decimal? ValorDesconto { get; set; }

        public decimal? ValorJuros { get; set; }

        public bool Reanalise { get; set; }

        public Consumidor Consumidor { get; set; }

        public Endereco Endereco { get; set; }

        public List<FormaDePagamento> FormasDePagamentos { get; set; }

        public Boleto Boleto { get; set; }

        public TransferenciaOnline TransferenciaOnline { get; set; }

        public MercadoPago MercadoPago { get; set; }

        public List<CartaoDeCredito> CartaoDeCredito { get; set; }

        public List<ValePresente> ValePresente { get; set; }

        public List<PosPago> PosPago { get; set; }

        public DadosHistorico DadosHistoricos { get; set; }

        public DecisaoExterna DecisaoExterna { get; set; }

        public List<CartaoAdicional> CartoesAdicionais { get; set; }
    }
}
