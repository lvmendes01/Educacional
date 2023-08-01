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
    public class ResponsavelServico : IResponsavelServico
    {

        private IResponsavelRepositorio _repositorio;

        public ResponsavelServico(IResponsavelRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(ResponsavelEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(ResponsavelEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<ResponsavelEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<ResponsavelEntidade> ObterFiltros(Expression<Func<ResponsavelEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<ResponsavelEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos();
        }

        public ResponsavelEntidade Primeiro(Expression<Func<ResponsavelEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public ResponsavelEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
