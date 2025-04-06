using System;

namespace DDDPat.Domain.Entities
{
    public class Evento
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public bool RequerInscricao { get; set; }
    }
}