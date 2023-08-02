using Lvmendes.Educacional.Comum.Entidades;
using Lvmendes.Educacional.Comum.Repositorio.Interfaces;
using Lvmendes.Educacional.Comum.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Servico
{
    public class InstituicaoServico : IInstituicaoServico
    {

        private ICidadeRepositorio _repositoriocidade;

        private IInstituicaoRepositorio _repositorio;

        public InstituicaoServico(IInstituicaoRepositorio repositorio, ICidadeRepositorio repositoriocidade)
        {
            _repositorio = repositorio;
            _repositoriocidade = repositoriocidade;
        }

        public string Adicionar(InstituicaoEntidade entity)
        {

            if (entity.Endereco.Cidade.Id != 0)
                entity.Endereco.Cidade = _repositoriocidade.CarregarCidadePeloId(entity.Endereco.Cidade.Id);

            if (entity.Endereco.Estado.Id != 0)
                entity.Endereco.Estado = _repositoriocidade.CarregarEstadoPeloId(entity.Endereco.Estado.Id);



            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(InstituicaoEntidade entity)
        {
            if (entity.Endereco.Cidade.Id != 0)
                entity.Endereco.Cidade = _repositoriocidade.CarregarCidadePeloId(entity.Endereco.Cidade.Id);

            if (entity.Endereco.Estado.Id != 0)
                entity.Endereco.Estado = _repositoriocidade.CarregarEstadoPeloId(entity.Endereco.Estado.Id);
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<InstituicaoEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<InstituicaoEntidade> ObterFiltros(Expression<Func<InstituicaoEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<InstituicaoEntidade> ObterTodos(bool includes = false)
        {
            if (includes)
            {
                String[] includesdados = new String[4] { "Endereco", "Endereco.Cidade", "Endereco.Estado", "Telefones" };

                return _repositorio.ObterTodos(include: includesdados);
            }
            return _repositorio.ObterTodos();
        }

        public InstituicaoEntidade Primeiro(Expression<Func<InstituicaoEntidade, bool>> predicate)
        {
            String[] includes = new String[4] { "Endereco", "Endereco.Cidade", "Endereco.Estado", "Telefones" };

            var retorno = _repositorio.Primeiro(predicate, includes);

            return retorno;
        }

        public InstituicaoEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
