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
    public class PeriodoServico : IPeriodoServico
    {

        private IPeriodoRepositorio _repositorio;

        public PeriodoServico(IPeriodoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(PeriodoEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(PeriodoEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<PeriodoEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<PeriodoEntidade> ObterFiltros(Expression<Func<PeriodoEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<PeriodoEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos();
        }

        public PeriodoEntidade Primeiro(Expression<Func<PeriodoEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public PeriodoEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
