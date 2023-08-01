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
    public class MatriculaServico : IMatriculaServico
    {

        private IMatriculaRepositorio _repositorio;

        public MatriculaServico(IMatriculaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(MatriculaEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(MatriculaEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<MatriculaEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<MatriculaEntidade> ObterFiltros(Expression<Func<MatriculaEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<MatriculaEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos();
        }

        public MatriculaEntidade Primeiro(Expression<Func<MatriculaEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public MatriculaEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
