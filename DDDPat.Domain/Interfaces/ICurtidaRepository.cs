using System;
using DDDPat.Domain.Entities;

namespace DDDPat.Domain.Interfaces
{
    public interface ICurtidaRepository
    {
        void Curtir(Guid postagemId, Guid usuarioId);
        int ContarCurtidas(Guid postagemId);
    }
}