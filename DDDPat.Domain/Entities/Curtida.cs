using System;

namespace DDDPat.Domain.Entities
{
    public class Curtida
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PostagemId { get; set; }
    public Postagem Postagem { get; set; }
    public Guid UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}
}