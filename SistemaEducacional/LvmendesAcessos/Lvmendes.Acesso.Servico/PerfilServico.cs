using Lvmendes.Acesso.Entidades;
using Lvmendes.Acesso.Repositorio.Interfaces;
using Lvmendes.Educacional.Comum.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Servico
{
    public class PerfilServico : IPerfilServico
    {

        private IPerfilRepositorio _repositorio;

        public PerfilServico(IPerfilRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(PerfilEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(PerfilEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<PerfilEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<PerfilEntidade> ObterFiltros(Expression<Func<PerfilEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<PerfilEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos(includes);
        }

        public PerfilEntidade Primeiro(Expression<Func<PerfilEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public PerfilEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
