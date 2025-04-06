using System.Collections.Generic;
using System.Linq;
using DDDPat.Domain.Entities;
using DDDPat.Domain.Interfaces;
using DDDPat.Infra.Context;

namespace DDDPat.Infra.Repositories
{
    public class PostagemRepository : IPostagemRepository
    {
        private readonly AppDbContext _context;

        public PostagemRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Postagem postagem)
        {
            _context.Postagens.Add(postagem);
            _context.SaveChanges();
        }

        public List<Postagem> Buscar()
        {
            return _context.Postagens.ToList();
        }

        public void Atualizar(int id, Postagem postagemAtualizada)
        {
            _context.Postagens.Update(postagemAtualizada);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            var postagem = _context.Postagens.Find(id);
            if (postagem != null)
            {
                _context.Postagens.Remove(postagem);
                _context.SaveChanges();
            }
        }
    }
}
