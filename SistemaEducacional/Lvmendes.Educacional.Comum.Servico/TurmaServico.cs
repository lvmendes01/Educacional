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
    public class TurmaServico : ITurmaServico
    {

        private ITurmaRepositorio _repositorio;

        public TurmaServico(ITurmaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(TurmaEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(TurmaEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<TurmaEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<TurmaEntidade> ObterFiltros(Expression<Func<TurmaEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<TurmaEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos();
        }

        public TurmaEntidade Primeiro(Expression<Func<TurmaEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public TurmaEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
