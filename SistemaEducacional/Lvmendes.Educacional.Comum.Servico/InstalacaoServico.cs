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
    public class InstalacaoServico : IInstalacaoServico
    {

        private IInstalacaoRepositorio _repositorio;

        public InstalacaoServico(IInstalacaoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(InstalacaoEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(InstalacaoEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<InstalacaoEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<InstalacaoEntidade> ObterFiltros(Expression<Func<InstalacaoEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<InstalacaoEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos();
        }

        public InstalacaoEntidade Primeiro(Expression<Func<InstalacaoEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public InstalacaoEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
