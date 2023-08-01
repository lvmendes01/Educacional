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
    public class CursoOfertadoServico : ICursoOfertadoServico
    {

        private ICursoOfertadoRepositorio _repositorio;

        public CursoOfertadoServico(ICursoOfertadoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(CursoOfertadoEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(CursoOfertadoEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<CursoOfertadoEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<CursoOfertadoEntidade> ObterFiltros(Expression<Func<CursoOfertadoEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<CursoOfertadoEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos();
        }

        public CursoOfertadoEntidade Primeiro(Expression<Func<CursoOfertadoEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public CursoOfertadoEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
