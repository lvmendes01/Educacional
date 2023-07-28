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
    public class MateriasServico : IMateriasServico
    {

        private IMateriasRepositorio _repositorio;

        public MateriasServico(IMateriasRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(MateriasEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(MateriasEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<MateriasEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<MateriasEntidade> ObterFiltros(Expression<Func<MateriasEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<MateriasEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos(includes);
        }

        public MateriasEntidade Primeiro(Expression<Func<MateriasEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public MateriasEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
