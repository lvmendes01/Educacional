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
    public class SalaServico : ISalaServico
    {

        private ISalaRepositorio _repositorio;

        public SalaServico(ISalaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(SalaEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(SalaEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<SalaEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<SalaEntidade> ObterFiltros(Expression<Func<SalaEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<SalaEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos(includes);
        }

        public SalaEntidade Primeiro(Expression<Func<SalaEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public SalaEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
