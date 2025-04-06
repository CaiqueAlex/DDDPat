using System.Collections.Generic;
using DDDPat.Domain.Entities;

namespace DDDPat.Domain.Interfaces
{
    public interface IEventoRepository
    {
        void Adicionar(Evento evento);
        List<Evento> Buscar();
        void Atualizar(int id, Evento eventoAtualizado);
        void Deletar(int id);
    }
}
