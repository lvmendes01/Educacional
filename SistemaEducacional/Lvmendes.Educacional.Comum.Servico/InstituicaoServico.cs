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
    public class InstituicaoServico : IInstituicaoServico
    {

        private IInstituicaoRepositorio _repositorio;

        public InstituicaoServico(IInstituicaoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(InstituicaoEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(InstituicaoEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<InstituicaoEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<InstituicaoEntidade> ObterFiltros(Expression<Func<InstituicaoEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<InstituicaoEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos();
        }

        public InstituicaoEntidade Primeiro(Expression<Func<InstituicaoEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public InstituicaoEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
