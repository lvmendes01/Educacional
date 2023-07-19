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
    public class CursoServico : ICursoServico
    {

        private ICursoRepositorio _repositorio;

        public CursoServico(ICursoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(CursoEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(CursoEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<CursoEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<CursoEntidade> ObterFiltros(Expression<Func<CursoEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<CursoEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos(includes);
        }

        public CursoEntidade Primeiro(Expression<Func<CursoEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public CursoEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
