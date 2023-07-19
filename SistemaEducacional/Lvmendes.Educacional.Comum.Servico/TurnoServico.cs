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
    public class TurnoServico : ITurnoServico
    {

        private ITurnoRepositorio _repositorio;

        public TurnoServico(ITurnoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(TurnoEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(TurnoEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<TurnoEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<TurnoEntidade> ObterFiltros(Expression<Func<TurnoEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<TurnoEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos(includes);
        }

        public TurnoEntidade Primeiro(Expression<Func<TurnoEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public TurnoEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
