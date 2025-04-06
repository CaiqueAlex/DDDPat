using System;
using System.Collections.Generic;

namespace DDDPat.Domain.Entities
{
    public class Usuario
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Curso { get; set; }

    public List<Usuario> Seguidores { get; set; } = new();
    public List<Postagem> Postagens { get; set; } = new();
}
}