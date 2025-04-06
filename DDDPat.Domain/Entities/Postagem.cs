using System;

namespace DDDPat.Domain.Entities
{
    public class Postagem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid AutorId { get; set; }
    public Usuario Autor { get; set; }
    public string Conteudo { get; set; }
    public DateTime DataHora { get; set; } = DateTime.UtcNow;

    public List<Comentario> Comentarios { get; set; } = new();
    public List<Curtida> Curtidas { get; set; } = new();
}
}