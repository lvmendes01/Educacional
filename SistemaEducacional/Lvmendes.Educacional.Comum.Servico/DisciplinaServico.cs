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
    public class DisciplinaServico : IDisciplinaServico
    {

        private IDisciplinaRepositorio _repositorio;

        public DisciplinaServico(IDisciplinaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(DisciplinaEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(DisciplinaEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<DisciplinaEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<DisciplinaEntidade> ObterFiltros(Expression<Func<DisciplinaEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<DisciplinaEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos();
        }

        public DisciplinaEntidade Primeiro(Expression<Func<DisciplinaEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public DisciplinaEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
