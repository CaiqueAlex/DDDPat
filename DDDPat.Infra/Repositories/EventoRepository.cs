using System.Collections.Generic;
using System.Linq;
using DDDPat.Domain.Entities;
using DDDPat.Domain.Interfaces;
using DDDPat.Infra.Context;

namespace DDDPat.Infra.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly AppDbContext _context;

        public EventoRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Evento evento)
        {
            _context.Eventos.Add(evento);
            _context.SaveChanges();
        }

        public List<Evento> Buscar()
        {
            return _context.Eventos.ToList();
        }

        public void Atualizar(int id, Evento eventoAtualizado)
        {
            _context.Eventos.Update(eventoAtualizado);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            var evento = _context.Eventos.Find(id);
            if (evento != null)
            {
                _context.Eventos.Remove(evento);
                _context.SaveChanges();
            }
        }
    }
}
