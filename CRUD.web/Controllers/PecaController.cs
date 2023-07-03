using Microsoft.AspNetCore.Mvc;
using CRUD.Dominio;
using System.ComponentModel.DataAnnotations;

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
                        ? NotFound()
                        : Ok(peca);
            }catch (Exception)
            {
                throw new Exception();
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
;               }

                _repositorio.Adicionar(pecaNova);
                return Ok(new { id = pecaNova, peca = pecaNova });

            }catch(Exception)
            {
                throw new Exception();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Editar(int id, [FromBody] Peca pecaEditada)
        {

        }

    }
}
