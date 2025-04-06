using System;
using System.Collections.Generic;
using System.Linq;
using DDDPat.Domain.Entities;
using DDDPat.Domain.Interfaces;
using DDDPat.Infra.Context;

namespace DDDPat.Infra.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly AppDbContext _context;

        public ComentarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Comentario comentario)
        {
            _context.Comentarios.Add(comentario);
            _context.SaveChanges();
        }

        public List<Comentario> BuscarPorPostagem(Guid postagemId)
        {
            return _context.Comentarios
                           .Where(c => c.PostagemId == postagemId)
                           .ToList();
        }
    }
}