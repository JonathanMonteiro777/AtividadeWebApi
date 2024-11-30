using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Exo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase    
    {
        private  readonly ProjetoRepository _projetoRepository;
        public ProjetosController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpGet]  // GET -> /api/projetos
        public IActionResult Listar()
        {
            return Ok(_projetoRepository.Listar());
        }

        // Código que completa o CRUD.
        [HttpPost] //POST -> /api/projetos
        public IActionResult Cadastrar(Projeto projeto)
        {
            _projetoRepository.Cadastrar(projeto);
            return StatusCode(201);
        }

        [HttpGet("{id}")] // GET -> /api/projetos/{id}
        public IActionResult BuscarPorId(int id)
        {
            Projeto projeto = _projetoRepository.BuscarporId(id);
            if (projeto == null)
            {
                return NotFound();
            }
            return Ok(projeto);
        }

        [HttpPut("{id}")]  // PUT -> /api/projetos/{id}
        public IActionResult Atualizar(int id, Projeto projeto)
        {
            _projetoRepository.Atualizar(id, projeto);
            return StatusCode(204);
        }
        [HttpDelete("{id}")] // DELETE -> /api/projetos/{id}
        public IActionResult Deletar(int id)
        {
            try
            {
                _projetoRepository.Deletar(id);
                return StatusCode(204);
            }
            catch ( Exception )
            {
                return BadRequest();
            }
        }
    }
}
