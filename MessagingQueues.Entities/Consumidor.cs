using System;

namespace MessagingQueues.Entities
{
    public class Consumidor
    {
        public string CpfCnpj { get; set; }

        public DateTime? DataNascimento { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Sexo { get; set; }

        public string TelefoneFixo { get; set; }

        public string TelefoneComercial { get; set; }

        public string Celular { get; set; }

        public string TelefoneContato { get; set; }

        public string Nacionalidade { get; set; }

        public string NomeMae { get; set; }

        public decimal? Renda { get; set; }

        public string Contato { get; set; }

        public string CpfContato { get; set; }

        public string InscricaoEstadual { get; set; }

        public string InscricaoMunicipal { get; set; }

        public string RamoDeAtividade { get; set; }

        public string Departamento { get; set; }

        public DateTime? DataAberturaEmpresa { get; set; }

        public string EstadoCivil { get; set; }

        public string Escolaridade { get; set; }

        public string Cargo { get; set; }

        public string Empresa { get; set; }

        public Endereco Endereco { get; set; }
    }
}
