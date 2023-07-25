using Lvmendes.Educacional.Comum.Entidades;
using Lvmendes.Educacional.Comum.Servico.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiInterna.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorarioController : ControllerBase
    {
        private readonly IHorariosServico servico;

        public HorarioController(IHorariosServico _servico)
        {
            servico = _servico;
        }
        [HttpPost("Salvar")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<RetornoApi> Salvar(HorarioEntidade item)
        {
            servico.Adicionar(item);
            return new RetornoApi
            {
                Resultado = true,
                Status = true
            };
        }


        /// <summary>
        /// Lista os itens da To-do list.
        /// </summary>
        /// <returns>Os itens da To-do list</returns>
        /// <response code="200">Returna os itens da To-do list cadastrados</response>
        [HttpGet("ObterHorario")]
        public ActionResult<RetornoApi> ObterHorario(bool todos)
        {
            var retornoChamado = servico.ObterTodos(todos);
            RetornoApi retorno = new RetornoApi
            {
                Resultado = retornoChamado,
                Status = retornoChamado != null,
                Mensagem = retornoChamado == null ? "HorarioEntidades não Encontrado" : string.Empty

            };
            return retorno;
        }
    }
}
