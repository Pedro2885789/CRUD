using Microsoft.AspNetCore.Mvc;
using CRUD.Dominio;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace CRUD.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PecaController : ControllerBase
    {
        private readonly IRepositorio _repositorio;

        public PecaController(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            try
            {
                var lista = _repositorio.ObterTodos();

                return lista == null
                        ? NotFound()
                        : Ok(lista);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        [HttpGet("{id}")]
        public IActionResult ObeterPorId(int id)
        {
            try
            {
                var peca = _repositorio.ObterPorId(id);

                return peca == null
                    ? NotFound($"Peça não encontrada com id [{id}]")
                    : Ok(peca);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }
        [HttpPost]
        public IActionResult Adicionar([FromBody][Required] Peca pecaNova)
        {
            try
            {
                var erros = Servico.ValidarCampos(pecaNova);

                if (erros.Any())
                {
                    return BadRequest(erros)
;
                }

                _repositorio.Adicionar(pecaNova);
                return Ok(new { id = pecaNova, peca = pecaNova });

            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Editar(int id, [FromBody] Peca pecaEditada)
        {
            try
            {
                var pecaObtidaPeloId = _repositorio.ObterPorId(id);

                if (pecaObtidaPeloId == null)
                {
                    return NotFound($"Peca não encontrada com id [{id}]");
                }

                pecaEditada.Id = pecaObtidaPeloId.Id;
                var erros = Servico.ValidarCampos(pecaEditada);

                if (!string.IsNullOrEmpty(erros))
                {
                    return Conflict(erros);
                }

                _repositorio.Editar(id, pecaEditada);
                return Ok(pecaEditada);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            try
            {
                var pecaObtidaPeloId = _repositorio.ObterPorId(id);

                if (pecaObtidaPeloId == null)
                {
                    return NotFound($"Peça não encontrada com id [{id}]");
                }

                _repositorio.Remover(pecaObtidaPeloId.Id);

                return NoContent();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }

        }
    }
}
