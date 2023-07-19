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
    public class UsuarioServico : IUsuarioServico
    {

        private IUsuarioRepositorio _repositorio;
        private IPerfilRepositorio _repositorioPerfil;


        public UsuarioServico(IUsuarioRepositorio repositorio, IPerfilRepositorio repositorioPerfil)
        {
            _repositorio = repositorio;
            _repositorioPerfil = repositorioPerfil;
        }

        public string Adicionar(UsuarioEntidade entity)
        {
            
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(UsuarioEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<UsuarioEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<UsuarioEntidade> ObterFiltros(Expression<Func<UsuarioEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<UsuarioEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos(includes);
        }

        public UsuarioEntidade Primeiro(Expression<Func<UsuarioEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public UsuarioEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
