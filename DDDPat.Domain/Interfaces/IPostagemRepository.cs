using System.Collections.Generic;
using DDDPat.Domain.Entities;

namespace DDDPat.Domain.Interfaces
{
    public interface IPostagemRepository
    {
        void Adicionar(Postagem postagem);
        List<Postagem> Buscar();
        void Atualizar(int id, Postagem postagemAtualizada);
        void Deletar(int id);
    }
}
