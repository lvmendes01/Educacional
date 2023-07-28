using Lvmendes.Educacional.Comum.Entidades;
using Lvmendes.Educacional.Comum.Modelo;
using Lvmendes.Educacional.Comum.Servico.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiInterna.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        private readonly ISalaServico servico;

        public SalaController(ISalaServico _servico)
        {
            servico = _servico;
        }
        [HttpPost("Salvar")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<RetornoApi> Salvar(SalaModelo item)
        {
            var retornoChamado = servico.Adicionar(item.Transformar(item));
            return new RetornoApi
            {
                Resultado = true,
                Status = retornoChamado == "Ok",
                Mensagem = retornoChamado == "Ok" ? "Cadastrado com Sucesso!" : retornoChamado

            };
        }


        /// <summary>
        /// Lista os itens da To-do list.
        /// </summary>
        /// <returns>Os itens da To-do list</returns>
        /// <response code="200">Returna os itens da To-do list cadastrados</response>
        [HttpGet("Lista")]
        public ActionResult<RetornoApi> Lista(bool todos)
        {
            var retornoChamado = servico.ObterTodos(todos);
            RetornoApi retorno = new RetornoApi
            {
                Resultado = retornoChamado,
                Status = retornoChamado != null,
                Mensagem = retornoChamado == null ? "SalaEntidades não Encontrado" : string.Empty

            };
            return retorno;
        }

        [HttpPut("Atualizar")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<RetornoApi> Atualizar(SalaModelo item)
        {
            var retornoChamado = servico.Atualizar(item.Transformar(item));
            return new RetornoApi
            {
                Resultado = true,
                Status = retornoChamado == "Atualizar com sucesso!!",
                Mensagem = retornoChamado

            };
        }

        /// <summary>
        /// Lista os itens da To-do list.
        /// </summary>
        /// <returns>Os itens da To-do list</returns>
        /// <response code="200">Returna os itens da To-do list cadastrados</response>
        [HttpGet("Carregar")]
        public ActionResult<RetornoApi> Carregar(Int64 Id)
        {
            var retornoChamado = servico.Procurar(Id);
            RetornoApi retorno = new RetornoApi
            {
                Resultado = retornoChamado,
                Status = retornoChamado != null,
                Mensagem = retornoChamado == null ? "Item não Encontrado" : string.Empty

            };
            return retorno;
        }
    }
}
