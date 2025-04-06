using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DDDPat.Domain.Entities;

namespace DDDPat.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Usuario>> ObterTodosAsync();
        Task AdicionarAsync(Usuario usuario);
        Task AtualizarAsync(Usuario usuario);
        Task RemoverAsync(Guid id);
    }
}
