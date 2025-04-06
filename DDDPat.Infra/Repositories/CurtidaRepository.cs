using System;
using System.Linq;
using DDDPat.Domain.Entities;
using DDDPat.Domain.Interfaces;
using DDDPat.Infra.Context;

namespace DDDPat.Infra.Repositories
{
    public class CurtidaRepository : ICurtidaRepository
    {
        private readonly AppDbContext _context;

        public CurtidaRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Curtir(Guid postagemId, Guid usuarioId)
        {
            var curtida = new Curtida { PostagemId = postagemId, UsuarioId = usuarioId };
            _context.Curtidas.Add(curtida);
            _context.SaveChanges();
        }

        public int ContarCurtidas(Guid postagemId)
        {
            return _context.Curtidas.Count(c => c.PostagemId == postagemId);
        }
    }
}