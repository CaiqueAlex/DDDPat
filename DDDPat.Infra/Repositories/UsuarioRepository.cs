using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DDDPat.Domain.Entities;
using DDDPat.Domain.Interfaces;
using DDDPat.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace DDDPat.Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> ObterPorIdAsync(Guid id)
        {
            return await _context.Usuarios
                                 .Include(u => u.Seguidores)
                                 .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IEnumerable<Usuario>> ObterTodosAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task AdicionarAsync(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task RemoverAsync(Guid id)
        {
            var usuario = await ObterPorIdAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
            }
        }
    }
}
