using System;
using System.Collections.Generic;
using DDDPat.Domain.Entities;

namespace DDDPat.Domain.Interfaces
{
    public interface IComentarioRepository
    {
        void Adicionar(Comentario comentario);
        List<Comentario> BuscarPorPostagem(Guid postagemId);
    }
}