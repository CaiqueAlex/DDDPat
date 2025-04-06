using System;

namespace DDDPat.Domain.Entities
{
    public class Comentario
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid PostagemId { get; set; }
        public Postagem Postagem { get; set; }
        public Guid AutorId { get; set; }
        public Usuario Autor { get; set; }
        public string Texto { get; set; }
        public DateTime DataHora { get; set; } = DateTime.UtcNow;
    }
}