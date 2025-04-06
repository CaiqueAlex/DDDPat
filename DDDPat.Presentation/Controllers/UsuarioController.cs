using Microsoft.AspNetCore.Mvc;
using DDDPat.Domain.Entities;
using DDDPat.Domain.Interfaces;

namespace DDDPat.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _repo;

        public UsuariosController(IUsuarioRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var usuarios = await _repo.ObterTodosAsync();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var usuario = await _repo.ObterPorIdAsync(id);
            return usuario == null ? NotFound() : Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Usuario usuario)
        {
            await _repo.AdicionarAsync(usuario);
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] Usuario usuario)
        {
            usuario.Id = id;
            await _repo.AtualizarAsync(usuario);
            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _repo.RemoverAsync(id);
            return NoContent();
        }
    }
}