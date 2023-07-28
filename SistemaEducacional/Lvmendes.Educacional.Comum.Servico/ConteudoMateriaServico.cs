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
    public class ConteudoMateriaServico : IConteudoMateriaServico
    {

        private IConteudoMateriaRepositorio _repositorio;

        public ConteudoMateriaServico(IConteudoMateriaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(ConteudoMateriaEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(ConteudoMateriaEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<ConteudoMateriaEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<ConteudoMateriaEntidade> ObterFiltros(Expression<Func<ConteudoMateriaEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<ConteudoMateriaEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos();
        }

        public ConteudoMateriaEntidade Primeiro(Expression<Func<ConteudoMateriaEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public ConteudoMateriaEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
