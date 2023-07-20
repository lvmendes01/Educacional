using Lvmendes.Educacional.Comum.Entidades;
using Lvmendes.Educacional.Comum.Servico.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiInterna.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeServico servico;

        public CidadeController(ICidadeServico _servico)
        {
            servico = _servico;
        }
      


        /// <summary>
        /// Lista os itens da To-do list.
        /// </summary>
        /// <returns>Os itens da To-do list</returns>
        /// <response code="200">Returna os itens da To-do list cadastrados</response>
        [HttpGet("ObterEstados")]
        public ActionResult<RetornoApi> ObterEstados()
        {
            var retornoChamado = servico.ListarEstado();
                
                RetornoApi retorno = new RetornoApi
            {
                Resultado = retornoChamado,
                Status = retornoChamado != null,
                Mensagem = retornoChamado == null ? "CidadeEntidades não Encontrado" : string.Empty

            };
            return retorno;
        }
        /// <summary>
        /// Lista os itens da To-do list.
        /// </summary>
        /// <returns>Os itens da To-do list</returns>
        /// <response code="200">Returna os itens da To-do list cadastrados</response>
        [HttpGet("ObterCidadePeloEstado")]
        public ActionResult<RetornoApi> ObterCidadePeloEstado(Int64 EstadoId)
        {
            var retornoChamado = servico.ListarCidadesPeloEstado(EstadoId);

            RetornoApi retorno = new RetornoApi
            {
                Resultado = retornoChamado,
                Status = retornoChamado != null,
                Mensagem = retornoChamado == null ? "CidadeEntidades não Encontrado" : string.Empty

            };
            return retorno;
        }

        /// <summary>
        /// Lista os itens da To-do list.
        /// </summary>
        /// <returns>Os itens da To-do list</returns>
        /// <response code="200">Returna os itens da To-do list cadastrados</response>
        [HttpGet("ObterEstado")]
        public ActionResult<RetornoApi> ObterEstado(Int64 EstadoId)
        {
            var retornoChamado = servico.CarregarEstadoPeloId(EstadoId);

            RetornoApi retorno = new RetornoApi
            {
                Resultado = retornoChamado,
                Status = retornoChamado != null,
                Mensagem = retornoChamado == null ? "CidadeEntidades não Encontrado" : string.Empty

            };
            return retorno;
        }

        /// <summary>
        /// Lista os itens da To-do list.
        /// </summary>
        /// <returns>Os itens da To-do list</returns>
        /// <response code="200">Returna os itens da To-do list cadastrados</response>
        [HttpGet("ObterCidade")]
        public ActionResult<RetornoApi> ObterCidade(Int64 EstadoId)
        {
            var retornoChamado = servico.CarregarCidadePeloId(EstadoId);

            RetornoApi retorno = new RetornoApi
            {
                Resultado = retornoChamado,
                Status = retornoChamado != null,
                Mensagem = retornoChamado == null ? "CidadeEntidades não Encontrado" : string.Empty

            };
            return retorno;
        }
    }
}
